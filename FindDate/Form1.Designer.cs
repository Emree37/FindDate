namespace FindDate
{
    partial class Form1
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
            this.cmbDayWeek = new System.Windows.Forms.ComboBox();
            this.cmbDayWeekCount = new System.Windows.Forms.ComboBox();
            this.mcStartDate = new System.Windows.Forms.MonthCalendar();
            this.mcEndDate = new System.Windows.Forms.MonthCalendar();
            this.lstDays = new System.Windows.Forms.ListBox();
            this.Monday = new System.Windows.Forms.Button();
            this.Tuesday = new System.Windows.Forms.Button();
            this.Wednesday = new System.Windows.Forms.Button();
            this.Thursday = new System.Windows.Forms.Button();
            this.Friday = new System.Windows.Forms.Button();
            this.Saturday = new System.Windows.Forms.Button();
            this.Sunday = new System.Windows.Forms.Button();
            this.flpDays = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDayWeek
            // 
            this.cmbDayWeek.FormattingEnabled = true;
            this.cmbDayWeek.Location = new System.Drawing.Point(74, 13);
            this.cmbDayWeek.Name = "cmbDayWeek";
            this.cmbDayWeek.Size = new System.Drawing.Size(121, 21);
            this.cmbDayWeek.TabIndex = 0;
            this.cmbDayWeek.SelectedIndexChanged += new System.EventHandler(this.cmbDayWeek_SelectedIndexChanged);
            // 
            // cmbDayWeekCount
            // 
            this.cmbDayWeekCount.FormattingEnabled = true;
            this.cmbDayWeekCount.Location = new System.Drawing.Point(74, 68);
            this.cmbDayWeekCount.Name = "cmbDayWeekCount";
            this.cmbDayWeekCount.Size = new System.Drawing.Size(121, 21);
            this.cmbDayWeekCount.TabIndex = 1;
            this.cmbDayWeekCount.SelectedIndexChanged += new System.EventHandler(this.cmbDayWeekCount_SelectedIndexChanged);
            // 
            // mcStartDate
            // 
            this.mcStartDate.Location = new System.Drawing.Point(455, 13);
            this.mcStartDate.Name = "mcStartDate";
            this.mcStartDate.TabIndex = 2;
            // 
            // mcEndDate
            // 
            this.mcEndDate.Location = new System.Drawing.Point(455, 193);
            this.mcEndDate.Name = "mcEndDate";
            this.mcEndDate.TabIndex = 3;
            // 
            // lstDays
            // 
            this.lstDays.FormattingEnabled = true;
            this.lstDays.Location = new System.Drawing.Point(722, 13);
            this.lstDays.Name = "lstDays";
            this.lstDays.Size = new System.Drawing.Size(192, 342);
            this.lstDays.TabIndex = 4;
            // 
            // Monday
            // 
            this.Monday.Location = new System.Drawing.Point(3, 3);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(75, 23);
            this.Monday.TabIndex = 5;
            this.Monday.Text = "Pazartesi";
            this.Monday.UseVisualStyleBackColor = true;
            this.Monday.Click += new System.EventHandler(this.Monday_Click);
            // 
            // Tuesday
            // 
            this.Tuesday.Location = new System.Drawing.Point(84, 3);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(75, 23);
            this.Tuesday.TabIndex = 6;
            this.Tuesday.Text = "Salı";
            this.Tuesday.UseVisualStyleBackColor = true;
            this.Tuesday.Click += new System.EventHandler(this.Tuesday_Click);
            // 
            // Wednesday
            // 
            this.Wednesday.Location = new System.Drawing.Point(165, 3);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(75, 23);
            this.Wednesday.TabIndex = 7;
            this.Wednesday.Text = "Çarşamba";
            this.Wednesday.UseVisualStyleBackColor = true;
            this.Wednesday.Click += new System.EventHandler(this.Wednesday_Click);
            // 
            // Thursday
            // 
            this.Thursday.Location = new System.Drawing.Point(3, 32);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(75, 23);
            this.Thursday.TabIndex = 8;
            this.Thursday.Text = "Perşembe";
            this.Thursday.UseVisualStyleBackColor = true;
            this.Thursday.Click += new System.EventHandler(this.Thursday_Click);
            // 
            // Friday
            // 
            this.Friday.Location = new System.Drawing.Point(84, 32);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(75, 23);
            this.Friday.TabIndex = 9;
            this.Friday.Text = "Cuma";
            this.Friday.UseVisualStyleBackColor = true;
            this.Friday.Click += new System.EventHandler(this.Friday_Click);
            // 
            // Saturday
            // 
            this.Saturday.Location = new System.Drawing.Point(165, 32);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(75, 23);
            this.Saturday.TabIndex = 10;
            this.Saturday.Text = "Cumartesi";
            this.Saturday.UseVisualStyleBackColor = true;
            this.Saturday.Click += new System.EventHandler(this.Saturday_Click);
            // 
            // Sunday
            // 
            this.Sunday.Location = new System.Drawing.Point(3, 61);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(75, 23);
            this.Sunday.TabIndex = 11;
            this.Sunday.Text = "Pazar";
            this.Sunday.UseVisualStyleBackColor = true;
            this.Sunday.Click += new System.EventHandler(this.Sunday_Click);
            // 
            // flpDays
            // 
            this.flpDays.Controls.Add(this.Monday);
            this.flpDays.Controls.Add(this.Tuesday);
            this.flpDays.Controls.Add(this.Wednesday);
            this.flpDays.Controls.Add(this.Thursday);
            this.flpDays.Controls.Add(this.Friday);
            this.flpDays.Controls.Add(this.Saturday);
            this.flpDays.Controls.Add(this.Sunday);
            this.flpDays.Location = new System.Drawing.Point(74, 155);
            this.flpDays.Name = "flpDays";
            this.flpDays.Size = new System.Drawing.Size(286, 135);
            this.flpDays.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 551);
            this.Controls.Add(this.flpDays);
            this.Controls.Add(this.lstDays);
            this.Controls.Add(this.mcEndDate);
            this.Controls.Add(this.mcStartDate);
            this.Controls.Add(this.cmbDayWeekCount);
            this.Controls.Add(this.cmbDayWeek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flpDays.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDayWeek;
        private System.Windows.Forms.ComboBox cmbDayWeekCount;
        private System.Windows.Forms.MonthCalendar mcStartDate;
        private System.Windows.Forms.MonthCalendar mcEndDate;
        private System.Windows.Forms.ListBox lstDays;
        private System.Windows.Forms.Button Monday;
        private System.Windows.Forms.Button Tuesday;
        private System.Windows.Forms.Button Wednesday;
        private System.Windows.Forms.Button Thursday;
        private System.Windows.Forms.Button Friday;
        private System.Windows.Forms.Button Saturday;
        private System.Windows.Forms.Button Sunday;
        private System.Windows.Forms.FlowLayoutPanel flpDays;
    }
}

