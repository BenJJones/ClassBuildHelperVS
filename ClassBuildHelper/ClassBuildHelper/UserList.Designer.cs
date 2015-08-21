namespace ClassBuildHelper
{
    partial class UserList
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.EmailListBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClassCodeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProfName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProfEmail = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.AcceptsReturn = true;
            this.FirstName.AllowDrop = true;
            this.FirstName.Location = new System.Drawing.Point(13, 30);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FirstName.Size = new System.Drawing.Size(203, 361);
            this.FirstName.TabIndex = 1;
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(16, 398);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 2;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // EmailListBox
            // 
            this.EmailListBox.AcceptsReturn = true;
            this.EmailListBox.AllowDrop = true;
            this.EmailListBox.Location = new System.Drawing.Point(431, 28);
            this.EmailListBox.Multiline = true;
            this.EmailListBox.Name = "EmailListBox";
            this.EmailListBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmailListBox.Size = new System.Drawing.Size(203, 361);
            this.EmailListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email List";
            // 
            // ClassNameBox
            // 
            this.ClassNameBox.Location = new System.Drawing.Point(641, 28);
            this.ClassNameBox.Name = "ClassNameBox";
            this.ClassNameBox.Size = new System.Drawing.Size(282, 20);
            this.ClassNameBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Class Code (ex. CS399)";
            // 
            // ClassCodeBox
            // 
            this.ClassCodeBox.Location = new System.Drawing.Point(641, 67);
            this.ClassCodeBox.Name = "ClassCodeBox";
            this.ClassCodeBox.Size = new System.Drawing.Size(100, 20);
            this.ClassCodeBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Professor Name";
            // 
            // ProfName
            // 
            this.ProfName.Location = new System.Drawing.Point(641, 104);
            this.ProfName.Name = "ProfName";
            this.ProfName.Size = new System.Drawing.Size(282, 20);
            this.ProfName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Professor Email";
            // 
            // ProfEmail
            // 
            this.ProfEmail.Location = new System.Drawing.Point(640, 144);
            this.ProfEmail.Name = "ProfEmail";
            this.ProfEmail.Size = new System.Drawing.Size(282, 20);
            this.ProfEmail.TabIndex = 11;
            // 
            // LastName
            // 
            this.LastName.AcceptsReturn = true;
            this.LastName.AllowDrop = true;
            this.LastName.Location = new System.Drawing.Point(222, 28);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LastName.Size = new System.Drawing.Size(203, 361);
            this.LastName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last Name";
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(640, 193);
            this.EndDate.Name = "EndDate";
            this.EndDate.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(641, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Class End Date";
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 429);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProfEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProfName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClassCodeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClassNameBox);
            this.Controls.Add(this.EmailListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Name = "UserList";
            this.Text = "User List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TextBox EmailListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClassCodeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProfName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProfEmail;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar EndDate;
        private System.Windows.Forms.Label label8;
    }
}

