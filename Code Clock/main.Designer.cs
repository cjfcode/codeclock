namespace Code_Clock
{
    partial class v_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.v_startbtn = new System.Windows.Forms.Button();
            this.v_stopbtn = new System.Windows.Forms.Button();
            this.v_progtitle = new System.Windows.Forms.Label();
            this.v_statsbox = new System.Windows.Forms.GroupBox();
            this.v_gboverallvalue = new System.Windows.Forms.Label();
            this.v_gboveralllabel = new System.Windows.Forms.Label();
            this.v_gbcurrentvalue = new System.Windows.Forms.Label();
            this.v_gbcurrentlabel = new System.Windows.Forms.Label();
            this.v_hrsremaininglbl = new System.Windows.Forms.Label();
            this.v_gbhrs = new System.Windows.Forms.Label();
            this.v_statsbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // v_startbtn
            // 
            this.v_startbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.v_startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_startbtn.Location = new System.Drawing.Point(12, 369);
            this.v_startbtn.Name = "v_startbtn";
            this.v_startbtn.Size = new System.Drawing.Size(175, 40);
            this.v_startbtn.TabIndex = 0;
            this.v_startbtn.Text = "START";
            this.v_startbtn.UseVisualStyleBackColor = true;
            this.v_startbtn.Click += new System.EventHandler(this.v_startbtn_Click);
            // 
            // v_stopbtn
            // 
            this.v_stopbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.v_stopbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_stopbtn.Location = new System.Drawing.Point(197, 369);
            this.v_stopbtn.Name = "v_stopbtn";
            this.v_stopbtn.Size = new System.Drawing.Size(175, 40);
            this.v_stopbtn.TabIndex = 1;
            this.v_stopbtn.Text = "STOP";
            this.v_stopbtn.UseVisualStyleBackColor = true;
            this.v_stopbtn.Click += new System.EventHandler(this.v_stopbtn_Click);
            // 
            // v_progtitle
            // 
            this.v_progtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.v_progtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_progtitle.Location = new System.Drawing.Point(0, 30);
            this.v_progtitle.Margin = new System.Windows.Forms.Padding(0);
            this.v_progtitle.Name = "v_progtitle";
            this.v_progtitle.Size = new System.Drawing.Size(382, 55);
            this.v_progtitle.TabIndex = 2;
            this.v_progtitle.Text = "Code Clock";
            this.v_progtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_statsbox
            // 
            this.v_statsbox.Controls.Add(this.v_gbhrs);
            this.v_statsbox.Controls.Add(this.v_hrsremaininglbl);
            this.v_statsbox.Controls.Add(this.v_gboverallvalue);
            this.v_statsbox.Controls.Add(this.v_gboveralllabel);
            this.v_statsbox.Controls.Add(this.v_gbcurrentvalue);
            this.v_statsbox.Controls.Add(this.v_gbcurrentlabel);
            this.v_statsbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_statsbox.Location = new System.Drawing.Point(12, 98);
            this.v_statsbox.Margin = new System.Windows.Forms.Padding(0);
            this.v_statsbox.Name = "v_statsbox";
            this.v_statsbox.Size = new System.Drawing.Size(360, 265);
            this.v_statsbox.TabIndex = 3;
            this.v_statsbox.TabStop = false;
            this.v_statsbox.Text = "Statistics";
            // 
            // v_gboverallvalue
            // 
            this.v_gboverallvalue.AutoSize = true;
            this.v_gboverallvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_gboverallvalue.Location = new System.Drawing.Point(206, 80);
            this.v_gboverallvalue.Name = "v_gboverallvalue";
            this.v_gboverallvalue.Size = new System.Drawing.Size(115, 24);
            this.v_gboverallvalue.TabIndex = 3;
            this.v_gboverallvalue.Text = "00:00:00:000";
            // 
            // v_gboveralllabel
            // 
            this.v_gboveralllabel.AutoSize = true;
            this.v_gboveralllabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_gboveralllabel.Location = new System.Drawing.Point(22, 80);
            this.v_gboveralllabel.Name = "v_gboveralllabel";
            this.v_gboveralllabel.Size = new System.Drawing.Size(74, 24);
            this.v_gboveralllabel.TabIndex = 2;
            this.v_gboveralllabel.Text = "Overall:";
            // 
            // v_gbcurrentvalue
            // 
            this.v_gbcurrentvalue.AutoSize = true;
            this.v_gbcurrentvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_gbcurrentvalue.Location = new System.Drawing.Point(206, 44);
            this.v_gbcurrentvalue.Name = "v_gbcurrentvalue";
            this.v_gbcurrentvalue.Size = new System.Drawing.Size(115, 24);
            this.v_gbcurrentvalue.TabIndex = 1;
            this.v_gbcurrentvalue.Text = "00:00:00:000";
            // 
            // v_gbcurrentlabel
            // 
            this.v_gbcurrentlabel.AutoSize = true;
            this.v_gbcurrentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_gbcurrentlabel.Location = new System.Drawing.Point(22, 44);
            this.v_gbcurrentlabel.Name = "v_gbcurrentlabel";
            this.v_gbcurrentlabel.Size = new System.Drawing.Size(149, 24);
            this.v_gbcurrentlabel.TabIndex = 0;
            this.v_gbcurrentlabel.Text = "Current Session:";
            // 
            // v_hrsremaininglbl
            // 
            this.v_hrsremaininglbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.v_hrsremaininglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_hrsremaininglbl.Location = new System.Drawing.Point(0, 150);
            this.v_hrsremaininglbl.Name = "v_hrsremaininglbl";
            this.v_hrsremaininglbl.Size = new System.Drawing.Size(360, 25);
            this.v_hrsremaininglbl.TabIndex = 4;
            this.v_hrsremaininglbl.Text = "Hours Remaining to Mastery";
            this.v_hrsremaininglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_gbhrs
            // 
            this.v_gbhrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.v_gbhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_gbhrs.Location = new System.Drawing.Point(0, 188);
            this.v_gbhrs.Margin = new System.Windows.Forms.Padding(0);
            this.v_gbhrs.Name = "v_gbhrs";
            this.v_gbhrs.Size = new System.Drawing.Size(360, 55);
            this.v_gbhrs.TabIndex = 5;
            this.v_gbhrs.Text = "10000";
            this.v_gbhrs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 436);
            this.Controls.Add(this.v_statsbox);
            this.Controls.Add(this.v_progtitle);
            this.Controls.Add(this.v_stopbtn);
            this.Controls.Add(this.v_startbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 475);
            this.Name = "v_main";
            this.Text = "Code Clock";
            this.v_statsbox.ResumeLayout(false);
            this.v_statsbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button v_startbtn;
        private System.Windows.Forms.Button v_stopbtn;
        private System.Windows.Forms.Label v_progtitle;
        private System.Windows.Forms.GroupBox v_statsbox;
        private System.Windows.Forms.Label v_gbcurrentvalue;
        private System.Windows.Forms.Label v_gbcurrentlabel;
        private System.Windows.Forms.Label v_gboverallvalue;
        private System.Windows.Forms.Label v_gboveralllabel;
        private System.Windows.Forms.Label v_gbhrs;
        private System.Windows.Forms.Label v_hrsremaininglbl;
    }
}

