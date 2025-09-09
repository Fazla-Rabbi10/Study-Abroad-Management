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
            this.std_role_comboBox = new System.Windows.Forms.ComboBox();
            this.student_submit_button = new System.Windows.Forms.Button();
            this.std_pass_textBox = new System.Windows.Forms.TextBox();
            this.std_count_textBox = new System.Windows.Forms.TextBox();
            this.std_email_textBox = new System.Windows.Forms.TextBox();
            this.std_pass_label = new System.Windows.Forms.Label();
            this.ad_gender_label = new System.Windows.Forms.Label();
            this.std_nationality_label = new System.Windows.Forms.Label();
            this.std_email_label = new System.Windows.Forms.Label();
            this.stdage_textBox = new System.Windows.Forms.TextBox();
            this.std_name_textBox = new System.Windows.Forms.TextBox();
            this.std_role_label = new System.Windows.Forms.Label();
            this.std_age_reg_label = new System.Windows.Forms.Label();
            this.std_reg_name_label = new System.Windows.Forms.Label();
            this.Student_reg_label = new System.Windows.Forms.Label();
            this.student_menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StudentbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Std_backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Std_exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentclearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.student_menuStrip1.SuspendLayout();
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
            this.std_gender_comboBox.TabIndex = 43;
            // 
            // std_role_comboBox
            // 
            this.std_role_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.std_role_comboBox.FormattingEnabled = true;
            this.std_role_comboBox.Items.AddRange(new object[] {
            "student"});
            this.std_role_comboBox.Location = new System.Drawing.Point(378, 449);
            this.std_role_comboBox.Name = "std_role_comboBox";
            this.std_role_comboBox.Size = new System.Drawing.Size(121, 24);
            this.std_role_comboBox.TabIndex = 42;
            // 
            // student_submit_button
            // 
            this.student_submit_button.Location = new System.Drawing.Point(480, 554);
            this.student_submit_button.Name = "student_submit_button";
            this.student_submit_button.Size = new System.Drawing.Size(211, 47);
            this.student_submit_button.TabIndex = 41;
            this.student_submit_button.Text = "Submit";
            this.student_submit_button.UseVisualStyleBackColor = true;
            this.student_submit_button.Click += new System.EventHandler(this.student_submit_button_Click);
            // 
            // std_pass_textBox
            // 
            this.std_pass_textBox.Location = new System.Drawing.Point(378, 376);
            this.std_pass_textBox.Name = "std_pass_textBox";
            this.std_pass_textBox.Size = new System.Drawing.Size(100, 22);
            this.std_pass_textBox.TabIndex = 40;
            // 
            // std_count_textBox
            // 
            this.std_count_textBox.Location = new System.Drawing.Point(733, 297);
            this.std_count_textBox.Name = "std_count_textBox";
            this.std_count_textBox.Size = new System.Drawing.Size(100, 22);
            this.std_count_textBox.TabIndex = 38;
            // 
            // std_email_textBox
            // 
            this.std_email_textBox.Location = new System.Drawing.Point(733, 230);
            this.std_email_textBox.Name = "std_email_textBox";
            this.std_email_textBox.Size = new System.Drawing.Size(100, 22);
            this.std_email_textBox.TabIndex = 37;
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
            this.stdage_textBox.TabIndex = 31;
            // 
            // std_name_textBox
            // 
            this.std_name_textBox.Location = new System.Drawing.Point(378, 230);
            this.std_name_textBox.Name = "std_name_textBox";
            this.std_name_textBox.Size = new System.Drawing.Size(100, 22);
            this.std_name_textBox.TabIndex = 30;
            // 
            // std_role_label
            // 
            this.std_role_label.AutoSize = true;
            this.std_role_label.Location = new System.Drawing.Point(293, 457);
            this.std_role_label.Name = "std_role_label";
            this.std_role_label.Size = new System.Drawing.Size(36, 16);
            this.std_role_label.TabIndex = 29;
            this.std_role_label.Text = "Role";
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
            // student_menuStrip1
            // 
            this.student_menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.student_menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentbackToolStripMenuItem});
            this.student_menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.student_menuStrip1.Name = "student_menuStrip1";
            this.student_menuStrip1.Size = new System.Drawing.Size(1152, 28);
            this.student_menuStrip1.TabIndex = 44;
            this.student_menuStrip1.Text = "menuStrip1";
            // 
            // StudentbackToolStripMenuItem
            // 
            this.StudentbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Std_backToolStripMenuItem,
            this.Std_exitToolStripMenuItem,
            this.StudentclearToolStripMenuItem});
            this.StudentbackToolStripMenuItem.Name = "StudentbackToolStripMenuItem";
            this.StudentbackToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.StudentbackToolStripMenuItem.Text = "View";
            // 
            // Std_backToolStripMenuItem
            // 
            this.Std_backToolStripMenuItem.Name = "Std_backToolStripMenuItem";
            this.Std_backToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Std_backToolStripMenuItem.Text = "Back";
            this.Std_backToolStripMenuItem.Click += new System.EventHandler(this.Std_backToolStripMenuItem_Click);
            // 
            // Std_exitToolStripMenuItem
            // 
            this.Std_exitToolStripMenuItem.Name = "Std_exitToolStripMenuItem";
            this.Std_exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Std_exitToolStripMenuItem.Text = "Exit";
            this.Std_exitToolStripMenuItem.Click += new System.EventHandler(this.Std_exitToolStripMenuItem_Click);
            // 
            // StudentclearToolStripMenuItem
            // 
            this.StudentclearToolStripMenuItem.Name = "StudentclearToolStripMenuItem";
            this.StudentclearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.StudentclearToolStripMenuItem.Text = "Clear";
            this.StudentclearToolStripMenuItem.Click += new System.EventHandler(this.StudentclearToolStripMenuItem_Click);
            // 
            // Studen_REG_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 726);
            this.Controls.Add(this.std_gender_comboBox);
            this.Controls.Add(this.std_role_comboBox);
            this.Controls.Add(this.student_submit_button);
            this.Controls.Add(this.std_pass_textBox);
            this.Controls.Add(this.std_count_textBox);
            this.Controls.Add(this.std_email_textBox);
            this.Controls.Add(this.std_pass_label);
            this.Controls.Add(this.ad_gender_label);
            this.Controls.Add(this.std_nationality_label);
            this.Controls.Add(this.std_email_label);
            this.Controls.Add(this.stdage_textBox);
            this.Controls.Add(this.std_name_textBox);
            this.Controls.Add(this.std_role_label);
            this.Controls.Add(this.std_age_reg_label);
            this.Controls.Add(this.std_reg_name_label);
            this.Controls.Add(this.Student_reg_label);
            this.Controls.Add(this.student_menuStrip1);
            this.Name = "Studen_REG_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studen_REG_Form";
            this.student_menuStrip1.ResumeLayout(false);
            this.student_menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox std_gender_comboBox;
        private System.Windows.Forms.ComboBox std_role_comboBox;
        private System.Windows.Forms.Button student_submit_button;
        private System.Windows.Forms.TextBox std_pass_textBox;
        private System.Windows.Forms.TextBox std_count_textBox;
        private System.Windows.Forms.TextBox std_email_textBox;
        private System.Windows.Forms.Label std_pass_label;
        private System.Windows.Forms.Label ad_gender_label;
        private System.Windows.Forms.Label std_nationality_label;
        private System.Windows.Forms.Label std_email_label;
        private System.Windows.Forms.TextBox stdage_textBox;
        private System.Windows.Forms.TextBox std_name_textBox;
        private System.Windows.Forms.Label std_role_label;
        private System.Windows.Forms.Label std_age_reg_label;
        private System.Windows.Forms.Label std_reg_name_label;
        private System.Windows.Forms.Label Student_reg_label;
        private System.Windows.Forms.MenuStrip student_menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StudentbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Std_backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Std_exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentclearToolStripMenuItem;
    }
}