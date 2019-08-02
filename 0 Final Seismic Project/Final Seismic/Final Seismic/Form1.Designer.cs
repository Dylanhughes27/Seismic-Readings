namespace Final_Seismic
{
    partial class rip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rip));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.siteClass1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.spectralResponse1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spectralResponse2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SC1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SC2 = new System.Windows.Forms.TextBox();
            this.Sms = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Sds = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Sm1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Sd1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.PGA = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.SQL = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(700, 376);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(711, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(700, 376);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // siteClass1
            // 
            this.siteClass1.FormattingEnabled = true;
            this.siteClass1.Items.AddRange(new object[] {
            "A Har dRock",
            "B Rock",
            "C Very Dense Soil and Soft Rock",
            "D Stiff Soil",
            "E Soft Soil"});
            this.siteClass1.Location = new System.Drawing.Point(272, 452);
            this.siteClass1.Name = "siteClass1";
            this.siteClass1.Size = new System.Drawing.Size(189, 21);
            this.siteClass1.TabIndex = 2;
            this.siteClass1.Text = "Site Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select your Site Class";
            // 
            // spectralResponse1
            // 
            this.spectralResponse1.Location = new System.Drawing.Point(668, 452);
            this.spectralResponse1.Name = "spectralResponse1";
            this.spectralResponse1.Size = new System.Drawing.Size(81, 20);
            this.spectralResponse1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Spectral Response @ 0.2 sec (Left Image)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "% g";
            // 
            // spectralResponse2
            // 
            this.spectralResponse2.Location = new System.Drawing.Point(1031, 453);
            this.spectralResponse2.Name = "spectralResponse2";
            this.spectralResponse2.Size = new System.Drawing.Size(100, 20);
            this.spectralResponse2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(952, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select Spectral Response @ 1.0 sec (Right Image)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1137, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "% g";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // SC1
            // 
            this.SC1.Location = new System.Drawing.Point(483, 563);
            this.SC1.Name = "SC1";
            this.SC1.Size = new System.Drawing.Size(151, 20);
            this.SC1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Site Coefficient @ 0.2 sec - Fa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(776, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Site Coefficient @ 1.0 sec - Fv";
            // 
            // SC2
            // 
            this.SC2.Location = new System.Drawing.Point(779, 563);
            this.SC2.Name = "SC2";
            this.SC2.Size = new System.Drawing.Size(151, 20);
            this.SC2.TabIndex = 14;
            // 
            // Sms
            // 
            this.Sms.Location = new System.Drawing.Point(426, 601);
            this.Sms.Name = "Sms";
            this.Sms.Size = new System.Drawing.Size(100, 20);
            this.Sms.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 601);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sms";
            // 
            // Sds
            // 
            this.Sds.Location = new System.Drawing.Point(426, 650);
            this.Sds.Name = "Sds";
            this.Sds.Size = new System.Drawing.Size(100, 20);
            this.Sds.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 654);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Sds";
            // 
            // Sm1
            // 
            this.Sm1.Location = new System.Drawing.Point(668, 600);
            this.Sm1.Name = "Sm1";
            this.Sm1.Size = new System.Drawing.Size(81, 20);
            this.Sm1.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(634, 603);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Sm1";
            // 
            // Sd1
            // 
            this.Sd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sd1.Location = new System.Drawing.Point(668, 647);
            this.Sd1.Name = "Sd1";
            this.Sd1.Size = new System.Drawing.Size(81, 20);
            this.Sd1.TabIndex = 21;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(636, 650);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(26, 13);
            this.text2.TabIndex = 22;
            this.text2.Text = "Sd1";
            // 
            // PGA
            // 
            this.PGA.Location = new System.Drawing.Point(996, 605);
            this.PGA.Name = "PGA";
            this.PGA.Size = new System.Drawing.Size(100, 20);
            this.PGA.TabIndex = 23;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(824, 608);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(166, 13);
            this.text.TabIndex = 24;
            this.text.Text = "Peak Ground Accerleration (PGA)";
            // 
            // SQL
            // 
            this.SQL.Location = new System.Drawing.Point(996, 651);
            this.SQL.Name = "SQL";
            this.SQL.Size = new System.Drawing.Size(100, 20);
            this.SQL.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(857, 654);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Seismic Qualification Level";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1103, 605);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "g";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(529, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(351, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "Click on the image to pick your location...";
            // 
            // rip
            // 
            this.ClientSize = new System.Drawing.Size(1417, 701);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SQL);
            this.Controls.Add(this.text);
            this.Controls.Add(this.PGA);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.Sd1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Sm1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Sds);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Sms);
            this.Controls.Add(this.SC2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SC1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spectralResponse2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.spectralResponse1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siteClass1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rip";
            this.Text = "Seismic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox SiteClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox siteClass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox spectralResponse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox spectralResponse2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SC1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SC2;
        private System.Windows.Forms.TextBox Sms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Sds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Sm1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Sd1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.TextBox PGA;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox SQL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
    }
}

