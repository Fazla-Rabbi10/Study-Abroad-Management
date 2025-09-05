namespace Study_Abroad_Management
{
    partial class Log_In_Form
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
            this.ID_label_login = new System.Windows.Forms.Label();
            this.Pass_login_label = new System.Windows.Forms.Label();
            this.Lof_in_button = new System.Windows.Forms.Button();
            this.Sign_Up_button = new System.Windows.Forms.Button();
            this.UR_button = new System.Windows.Forms.Button();
            this.Admin_button = new System.Windows.Forms.Button();
            this.Student_button = new System.Windows.Forms.Button();
            this.LG_ID_textBox = new System.Windows.Forms.TextBox();
            this.Lg_Password_textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Study Abroad Solution";
            // 
            // ID_label_login
            // 
            this.ID_label_login.AutoSize = true;
            this.ID_label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label_login.Location = new System.Drawing.Point(411, 181);
            this.ID_label_login.Name = "ID_label_login";
            this.ID_label_login.Size = new System.Drawing.Size(46, 25);
            this.ID_label_login.TabIndex = 1;
            this.ID_label_login.Text = "ID :";
            // 
            // Pass_login_label
            // 
            this.Pass_login_label.AutoSize = true;
            this.Pass_login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_login_label.Location = new System.Drawing.Point(348, 242);
            this.Pass_login_label.Name = "Pass_login_label";
            this.Pass_login_label.Size = new System.Drawing.Size(109, 22);
            this.Pass_login_label.TabIndex = 2;
            this.Pass_login_label.Text = "Password :";
            // 
            // Lof_in_button
            // 
            this.Lof_in_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lof_in_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lof_in_button.Location = new System.Drawing.Point(500, 335);
            this.Lof_in_button.Name = "Lof_in_button";
            this.Lof_in_button.Size = new System.Drawing.Size(75, 41);
            this.Lof_in_button.TabIndex = 4;
            this.Lof_in_button.Text = "Log in";
            this.Lof_in_button.UseVisualStyleBackColor = false;
            // 
            // Sign_Up_button
            // 
            this.Sign_Up_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sign_Up_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_button.Location = new System.Drawing.Point(603, 335);
            this.Sign_Up_button.Name = "Sign_Up_button";
            this.Sign_Up_button.Size = new System.Drawing.Size(89, 41);
            this.Sign_Up_button.TabIndex = 5;
            this.Sign_Up_button.Text = "Sign Up?";
            this.Sign_Up_button.UseVisualStyleBackColor = false;
            this.Sign_Up_button.Click += new System.EventHandler(this.Sign_Up_button_Click);
            // 
            // UR_button
            // 
            this.UR_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UR_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UR_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UR_button.Location = new System.Drawing.Point(448, 565);
            this.UR_button.Name = "UR_button";
            this.UR_button.Size = new System.Drawing.Size(277, 43);
            this.UR_button.TabIndex = 6;
            this.UR_button.Text = "University Representative";
            this.UR_button.UseVisualStyleBackColor = true;
            this.UR_button.Visible = false;
            this.UR_button.Click += new System.EventHandler(this.UR_button_Click);
            // 
            // Admin_button
            // 
            this.Admin_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Admin_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Admin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_button.Location = new System.Drawing.Point(454, 479);
            this.Admin_button.Name = "Admin_button";
            this.Admin_button.Size = new System.Drawing.Size(271, 42);
            this.Admin_button.TabIndex = 7;
            this.Admin_button.Text = "Admin";
            this.Admin_button.UseVisualStyleBackColor = true;
            this.Admin_button.Visible = false;
            this.Admin_button.Click += new System.EventHandler(this.Admin_button_Click);
            // 
            // Student_button
            // 
            this.Student_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Student_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Student_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_button.Location = new System.Drawing.Point(454, 645);
            this.Student_button.Name = "Student_button";
            this.Student_button.Size = new System.Drawing.Size(271, 43);
            this.Student_button.TabIndex = 8;
            this.Student_button.Text = "Student";
            this.Student_button.UseVisualStyleBackColor = true;
            this.Student_button.Visible = false;
            this.Student_button.Click += new System.EventHandler(this.Student_button_Click);
            // 
            // LG_ID_textBox
            // 
            this.LG_ID_textBox.Location = new System.Drawing.Point(500, 181);
            this.LG_ID_textBox.Name = "LG_ID_textBox";
            this.LG_ID_textBox.Size = new System.Drawing.Size(160, 22);
            this.LG_ID_textBox.TabIndex = 9;
            // 
            // Lg_Password_textBox2
            // 
            this.Lg_Password_textBox2.Location = new System.Drawing.Point(500, 244);
            this.Lg_Password_textBox2.Name = "Lg_Password_textBox2";
            this.Lg_Password_textBox2.Size = new System.Drawing.Size(160, 22);
            this.Lg_Password_textBox2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(976, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Log_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 726);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lg_Password_textBox2);
            this.Controls.Add(this.LG_ID_textBox);
            this.Controls.Add(this.Student_button);
            this.Controls.Add(this.Admin_button);
            this.Controls.Add(this.UR_button);
            this.Controls.Add(this.Sign_Up_button);
            this.Controls.Add(this.Lof_in_button);
            this.Controls.Add(this.Pass_login_label);
            this.Controls.Add(this.ID_label_login);
            this.Controls.Add(this.label1);
            this.Name = "Log_In_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_In_Form";
            this.Load += new System.EventHandler(this.Log_In_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID_label_login;
        private System.Windows.Forms.Label Pass_login_label;
        private System.Windows.Forms.Button Lof_in_button;
        private System.Windows.Forms.Button Sign_Up_button;
        private System.Windows.Forms.Button UR_button;
        private System.Windows.Forms.Button Admin_button;
        private System.Windows.Forms.Button Student_button;
        private System.Windows.Forms.TextBox LG_ID_textBox;
        private System.Windows.Forms.TextBox Lg_Password_textBox2;
        private System.Windows.Forms.Button button1;
    }
}