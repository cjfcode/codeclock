using System;
using System.Windows.Forms;

/*      TODO:
 *            (1) Add 10k hour checking
 *            (2) Make sure the timer works correctly when it hits 24 hours and rolls over to days (may need to add days label)
 *            (3) Make sure timer is accurate
 *            (4) Get code reviews
 */

namespace Code_Clock
{
    public partial class v_main : Form
    {
        DateTime start;

        /// <summary>
        /// Intermediate TimeSpan used to record the sum of the current session and the
        /// previously elapsed time at every one second interval of the timer tick.
        /// </summary>
        TimeSpan elapsed;
        Timer clock = new Timer();
        bool running = false;

        public v_main()
        {
            InitializeComponent();
            clock.Tick += new EventHandler(clock_tick);

            /* set the overall time display on program start based on values stored in properties */
            elapsed = Properties.Settings.Default.totalelapsedtime;
            v_gboverallvalue.Text = Properties.Settings.Default.totalelapsedtime.Hours.ToString("00") + ":" +
                                    Properties.Settings.Default.totalelapsedtime.Minutes.ToString("00") + ":" +
                                    Properties.Settings.Default.totalelapsedtime.Seconds.ToString("00") + ":" +
                                    Properties.Settings.Default.totalelapsedtime.Milliseconds.ToString("00");

            //Properties.Settings.Default.totalelapsedtime = new TimeSpan(2273, 0, 3); // timespan for testing mastery hours counter
            v_gbhrs.Text = (10000 - (Properties.Settings.Default.totalelapsedtime.Days * 24 +
                           Properties.Settings.Default.totalelapsedtime.Hours)).ToString(); // may need to set this in timer tick for realtime updates
        }

        private void v_startbtn_Click(object sender, EventArgs e)
        {
            if(!running)
            {
                clock.Start();
                running = true;
                start = DateTime.Now;
            }
        }

        private void v_stopbtn_Click(object sender, EventArgs e)
        {
            if(running)
            {
                clock.Stop();
                running = false;
                elapsed = Properties.Settings.Default.totalelapsedtime;
                //Properties.Settings.Default.Save(); // uncomment this to save and also add a save in formclosing event if removing save from clock_tick event
            }
        }

        private void clock_tick(object sender, EventArgs e)
        {
            Properties.Settings.Default.currentsessiontime = DateTime.Now - start;
            Properties.Settings.Default.totalelapsedtime = elapsed + Properties.Settings.Default.currentsessiontime;

            /* saving after every timer tick saves the results even if the program is closed, but make sure 
               it doesn't introduce high disk I/O. */
            Properties.Settings.Default.Save();

            v_gbcurrentvalue.Text = Properties.Settings.Default.currentsessiontime.Hours.ToString("00") + ":" +
                                    Properties.Settings.Default.currentsessiontime.Minutes.ToString("00") + ":" +
                                    Properties.Settings.Default.currentsessiontime.Seconds.ToString("00") + ":" +
                                    Properties.Settings.Default.currentsessiontime.Milliseconds.ToString("00");

            v_gboverallvalue.Text = Properties.Settings.Default.totalelapsedtime.Hours.ToString("00") + ":" +
                                    Properties.Settings.Default.totalelapsedtime.Minutes.ToString("00") + ":" +
                                    Properties.Settings.Default.totalelapsedtime.Seconds.ToString("00") + ":" +
                                    Properties.Settings.Default.totalelapsedtime.Milliseconds.ToString("00");
        }
    }
}