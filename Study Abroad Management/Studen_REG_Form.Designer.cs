namespace Study_Abroad_Management
{
    partial class Studen_REG_Form
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
            this.std_gender_comboBox = new System.Windows.Forms.ComboBox();
            this.student_submit_button = new System.Windows.Forms.Button();
            this.std_pass_textBox = new System.Windows.Forms.TextBox();
            this.std_email_textBox = new System.Windows.Forms.TextBox();
            this.std_pass_label = new System.Windows.Forms.Label();
            this.ad_gender_label = new System.Windows.Forms.Label();
            this.std_nationality_label = new System.Windows.Forms.Label();
            this.std_email_label = new System.Windows.Forms.Label();
            this.stdage_textBox = new System.Windows.Forms.TextBox();
            this.std_name_textBox = new System.Windows.Forms.TextBox();
            this.std_age_reg_label = new System.Windows.Forms.Label();
            this.std_reg_name_label = new System.Windows.Forms.Label();
            this.Student_reg_label = new System.Windows.Forms.Label();
            this.BackbuttonStd = new System.Windows.Forms.Button();
            this.ExitbuttonStd = new System.Windows.Forms.Button();
            this.CLEARbutton = new System.Windows.Forms.Button();
            this.Std_count_comboBox = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // std_gender_comboBox
            // 
            this.std_gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.std_gender_comboBox.FormattingEnabled = true;
            this.std_gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.std_gender_comboBox.Location = new System.Drawing.Point(733, 376);
            this.std_gender_comboBox.Name = "std_gender_comboBox";
            this.std_gender_comboBox.Size = new System.Drawing.Size(121, 24);
            this.std_gender_comboBox.TabIndex = 6;
            // 
            // student_submit_button
            // 
            this.student_submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_submit_button.Location = new System.Drawing.Point(378, 554);
            this.student_submit_button.Name = "student_submit_button";
            this.student_submit_button.Size = new System.Drawing.Size(211, 47);
            this.student_submit_button.TabIndex = 7;
            this.student_submit_button.Text = "Submit";
            this.student_submit_button.UseVisualStyleBackColor = true;
            this.student_submit_button.Click += new System.EventHandler(this.student_submit_button_Click);
            // 
            // std_pass_textBox
            // 
            this.std_pass_textBox.Location = new System.Drawing.Point(378, 376);
            this.std_pass_textBox.Name = "std_pass_textBox";
            this.std_pass_textBox.Size = new System.Drawing.Size(100, 22);
            this.std_pass_textBox.TabIndex = 5;
            // 
            // std_email_textBox
            // 
            this.std_email_textBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.std_email_textBox.Location = new System.Drawing.Point(733, 230);
            this.std_email_textBox.Name = "std_email_textBox";
            this.std_email_textBox.Size = new System.Drawing.Size(121, 22);
            this.std_email_textBox.TabIndex = 1;
            this.std_email_textBox.Text = "abc@gmail.com";
            this.std_email_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.std_email_textBox.TextChanged += new System.EventHandler(this.std_email_textBox_TextChanged);
            // 
            // std_pass_label
            // 
            this.std_pass_label.AutoSize = true;
            this.std_pass_label.Location = new System.Drawing.Point(271, 382);
            this.std_pass_label.Name = "std_pass_label";
            this.std_pass_label.Size = new System.Drawing.Size(67, 16);
            this.std_pass_label.TabIndex = 36;
            this.std_pass_label.Text = "Password";
            // 
            // ad_gender_label
            // 
            this.ad_gender_label.AutoSize = true;
            this.ad_gender_label.Location = new System.Drawing.Point(639, 382);
            this.ad_gender_label.Name = "ad_gender_label";
            this.ad_gender_label.Size = new System.Drawing.Size(52, 16);
            this.ad_gender_label.TabIndex = 34;
            this.ad_gender_label.Text = "Gender";
            // 
            // std_nationality_label
            // 
            this.std_nationality_label.AutoSize = true;
            this.std_nationality_label.Location = new System.Drawing.Point(572, 303);
            this.std_nationality_label.Name = "std_nationality_label";
            this.std_nationality_label.Size = new System.Drawing.Size(119, 16);
            this.std_nationality_label.TabIndex = 33;
            this.std_nationality_label.Text = "Nationality/Country";
            // 
            // std_email_label
            // 
            this.std_email_label.AutoSize = true;
            this.std_email_label.Location = new System.Drawing.Point(644, 233);
            this.std_email_label.Name = "std_email_label";
            this.std_email_label.Size = new System.Drawing.Size(47, 16);
            this.std_email_label.TabIndex = 32;
            this.std_email_label.Text = "Email :";
            // 
            // stdage_textBox
            // 
            this.stdage_textBox.Location = new System.Drawing.Point(378, 300);
            this.stdage_textBox.Name = "stdage_textBox";
            this.stdage_textBox.Size = new System.Drawing.Size(100, 22);
            this.stdage_textBox.TabIndex = 3;
            // 
            // std_name_textBox
            // 
            this.std_name_textBox.Location = new System.Drawing.Point(378, 230);
            this.std_name_textBox.Name = "std_name_textBox";
            this.std_name_textBox.Size = new System.Drawing.Size(100, 22);
            this.std_name_textBox.TabIndex = 0;
            // 
            // std_age_reg_label
            // 
            this.std_age_reg_label.AutoSize = true;
            this.std_age_reg_label.Location = new System.Drawing.Point(271, 306);
            this.std_age_reg_label.Name = "std_age_reg_label";
            this.std_age_reg_label.Size = new System.Drawing.Size(32, 16);
            this.std_age_reg_label.TabIndex = 28;
            this.std_age_reg_label.Text = "Age";
            // 
            // std_reg_name_label
            // 
            this.std_reg_name_label.AutoSize = true;
            this.std_reg_name_label.Location = new System.Drawing.Point(271, 236);
            this.std_reg_name_label.Name = "std_reg_name_label";
            this.std_reg_name_label.Size = new System.Drawing.Size(44, 16);
            this.std_reg_name_label.TabIndex = 27;
            this.std_reg_name_label.Text = "Name";
            // 
            // Student_reg_label
            // 
            this.Student_reg_label.AutoSize = true;
            this.Student_reg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_reg_label.Location = new System.Drawing.Point(446, 92);
            this.Student_reg_label.Name = "Student_reg_label";
            this.Student_reg_label.Size = new System.Drawing.Size(250, 29);
            this.Student_reg_label.TabIndex = 26;
            this.Student_reg_label.Text = "Student Registration";
            // 
            // BackbuttonStd
            // 
            this.BackbuttonStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackbuttonStd.Location = new System.Drawing.Point(41, 45);
            this.BackbuttonStd.Name = "BackbuttonStd";
            this.BackbuttonStd.Size = new System.Drawing.Size(94, 39);
            this.BackbuttonStd.TabIndex = 45;
            this.BackbuttonStd.Text = "Back";
            this.BackbuttonStd.UseVisualStyleBackColor = true;
            this.BackbuttonStd.Click += new System.EventHandler(this.BackbuttonStd_Click);
            // 
            // ExitbuttonStd
            // 
            this.ExitbuttonStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitbuttonStd.Location = new System.Drawing.Point(1016, 45);
            this.ExitbuttonStd.Name = "ExitbuttonStd";
            this.ExitbuttonStd.Size = new System.Drawing.Size(94, 39);
            this.ExitbuttonStd.TabIndex = 46;
            this.ExitbuttonStd.Text = "Exit";
            this.ExitbuttonStd.UseVisualStyleBackColor = true;
            this.ExitbuttonStd.Click += new System.EventHandler(this.ExitbuttonStd_Click);
            // 
            // CLEARbutton
            // 
            this.CLEARbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEARbutton.Location = new System.Drawing.Point(643, 554);
            this.CLEARbutton.Name = "CLEARbutton";
            this.CLEARbutton.Size = new System.Drawing.Size(211, 47);
            this.CLEARbutton.TabIndex = 47;
            this.CLEARbutton.Text = "Clear";
            this.CLEARbutton.UseVisualStyleBackColor = true;
            this.CLEARbutton.Click += new System.EventHandler(this.CLEARbutton_Click);
            // 
            // Std_count_comboBox
            // 
            this.Std_count_comboBox.FormattingEnabled = true;
            this.Std_count_comboBox.Items.AddRange(new object[] {
            "United States",
            "",
            "India",
            "",
            "Canada",
            "",
            "Australia",
            "",
            "Bangladesh",
            "",
            "United Kingdom",
            "",
            "Japan",
            "",
            "Germany",
            "",
            "Brazil",
            "",
            "France",
            "",
            "Italy",
            "",
            "Russia",
            "",
            "China",
            "",
            "Mexico",
            "",
            "South Korea",
            "",
            "Spain",
            "",
            "Saudi Arabia",
            "",
            "Argentina",
            "",
            "South Africa",
            "",
            "Egypt"});
            this.Std_count_comboBox.Location = new System.Drawing.Point(733, 303);
            this.Std_count_comboBox.Name = "Std_count_comboBox";
            this.Std_count_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Std_count_comboBox.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(278, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(614, 61);
            this.Title.TabIndex = 51;
            this.Title.Text = "Abroad Higher Study Soltuin";
            // 
            // Studen_REG_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 726);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Std_count_comboBox);
            this.Controls.Add(this.CLEARbutton);
            this.Controls.Add(this.ExitbuttonStd);
            this.Controls.Add(this.BackbuttonStd);
            this.Controls.Add(this.std_gender_comboBox);
            this.Controls.Add(this.student_submit_button);
            this.Controls.Add(this.std_pass_textBox);
            this.Controls.Add(this.std_email_textBox);
            this.Controls.Add(this.std_pass_label);
            this.Controls.Add(this.ad_gender_label);
            this.Controls.Add(this.std_nationality_label);
            this.Controls.Add(this.std_email_label);
            this.Controls.Add(this.stdage_textBox);
            this.Controls.Add(this.std_name_textBox);
            this.Controls.Add(this.std_age_reg_label);
            this.Controls.Add(this.std_reg_name_label);
            this.Controls.Add(this.Student_reg_label);
            this.MaximizeBox = false;
            this.Name = "Studen_REG_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studen_REG_Form";
            this.Load += new System.EventHandler(this.Studen_REG_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox std_gender_comboBox;
        private System.Windows.Forms.Button student_submit_button;
        private System.Windows.Forms.TextBox std_pass_textBox;
        private System.Windows.Forms.TextBox std_email_textBox;
        private System.Windows.Forms.Label std_pass_label;
        private System.Windows.Forms.Label ad_gender_label;
        private System.Windows.Forms.Label std_nationality_label;
        private System.Windows.Forms.Label std_email_label;
        private System.Windows.Forms.TextBox stdage_textBox;
        private System.Windows.Forms.TextBox std_name_textBox;
        private System.Windows.Forms.Label std_age_reg_label;
        private System.Windows.Forms.Label std_reg_name_label;
        private System.Windows.Forms.Label Student_reg_label;
        private System.Windows.Forms.Button BackbuttonStd;
        private System.Windows.Forms.Button ExitbuttonStd;
        private System.Windows.Forms.Button CLEARbutton;
        private System.Windows.Forms.ComboBox Std_count_comboBox;
        private System.Windows.Forms.Label Title;
    }
}