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
            this.Student_button = new System.Windows.Forms.Button();
            this.LG_ID_textBox = new System.Windows.Forms.TextBox();
            this.Lg_Password_textBox2 = new System.Windows.Forms.TextBox();
            this.Login_Exit_button = new System.Windows.Forms.Button();
            this.LogIN_Clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1052, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Abroad Higher Study Solution";
            // 
            // ID_label_login
            // 
            this.ID_label_login.AutoSize = true;
            this.ID_label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label_login.Location = new System.Drawing.Point(616, 283);
            this.ID_label_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_label_login.Name = "ID_label_login";
            this.ID_label_login.Size = new System.Drawing.Size(70, 37);
            this.ID_label_login.TabIndex = 1;
            this.ID_label_login.Text = "ID :";
            // 
            // Pass_login_label
            // 
            this.Pass_login_label.AutoSize = true;
            this.Pass_login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_login_label.Location = new System.Drawing.Point(522, 378);
            this.Pass_login_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pass_login_label.Name = "Pass_login_label";
            this.Pass_login_label.Size = new System.Drawing.Size(169, 33);
            this.Pass_login_label.TabIndex = 2;
            this.Pass_login_label.Text = "Password :";
            // 
            // Lof_in_button
            // 
            this.Lof_in_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lof_in_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lof_in_button.Location = new System.Drawing.Point(783, 525);
            this.Lof_in_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lof_in_button.Name = "Lof_in_button";
            this.Lof_in_button.Size = new System.Drawing.Size(112, 64);
            this.Lof_in_button.TabIndex = 4;
            this.Lof_in_button.Text = "Log in";
            this.Lof_in_button.UseVisualStyleBackColor = false;
            this.Lof_in_button.Click += new System.EventHandler(this.Lof_in_button_Click);
            // 
            // Sign_Up_button
            // 
            this.Sign_Up_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sign_Up_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_button.Location = new System.Drawing.Point(954, 525);
            this.Sign_Up_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sign_Up_button.Name = "Sign_Up_button";
            this.Sign_Up_button.Size = new System.Drawing.Size(134, 64);
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
            this.UR_button.Location = new System.Drawing.Point(646, 786);
            this.UR_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UR_button.Name = "UR_button";
            this.UR_button.Size = new System.Drawing.Size(416, 67);
            this.UR_button.TabIndex = 6;
            this.UR_button.Text = "University Representative";
            this.UR_button.UseVisualStyleBackColor = true;
            this.UR_button.Visible = false;
            this.UR_button.Click += new System.EventHandler(this.UR_button_Click);
            // 
            // Student_button
            // 
            this.Student_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Student_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Student_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_button.Location = new System.Drawing.Point(646, 905);
            this.Student_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Student_button.Name = "Student_button";
            this.Student_button.Size = new System.Drawing.Size(416, 67);
            this.Student_button.TabIndex = 8;
            this.Student_button.Text = "Student";
            this.Student_button.UseVisualStyleBackColor = true;
            this.Student_button.Visible = false;
            this.Student_button.Click += new System.EventHandler(this.Student_button_Click);
            // 
            // LG_ID_textBox
            // 
            this.LG_ID_textBox.Location = new System.Drawing.Point(750, 283);
            this.LG_ID_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LG_ID_textBox.Name = "LG_ID_textBox";
            this.LG_ID_textBox.Size = new System.Drawing.Size(238, 31);
            this.LG_ID_textBox.TabIndex = 9;
            // 
            // Lg_Password_textBox2
            // 
            this.Lg_Password_textBox2.Location = new System.Drawing.Point(750, 381);
            this.Lg_Password_textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lg_Password_textBox2.Name = "Lg_Password_textBox2";
            this.Lg_Password_textBox2.Size = new System.Drawing.Size(238, 31);
            this.Lg_Password_textBox2.TabIndex = 10;
            // 
            // Login_Exit_button
            // 
            this.Login_Exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Exit_button.Location = new System.Drawing.Point(1464, 72);
            this.Login_Exit_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_Exit_button.Name = "Login_Exit_button";
            this.Login_Exit_button.Size = new System.Drawing.Size(123, 48);
            this.Login_Exit_button.TabIndex = 11;
            this.Login_Exit_button.Text = "Exit";
            this.Login_Exit_button.UseVisualStyleBackColor = true;
            this.Login_Exit_button.Click += new System.EventHandler(this.Login_Exit_button_Click);
            // 
            // LogIN_Clear_button
            // 
            this.LogIN_Clear_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogIN_Clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIN_Clear_button.Location = new System.Drawing.Point(624, 527);
            this.LogIN_Clear_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogIN_Clear_button.Name = "LogIN_Clear_button";
            this.LogIN_Clear_button.Size = new System.Drawing.Size(112, 62);
            this.LogIN_Clear_button.TabIndex = 12;
            this.LogIN_Clear_button.Text = "Clear";
            this.LogIN_Clear_button.UseVisualStyleBackColor = false;
            this.LogIN_Clear_button.Click += new System.EventHandler(this.LogIN_Clear_button_Click);
            // 
            // Log_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1728, 1134);
            this.Controls.Add(this.LogIN_Clear_button);
            this.Controls.Add(this.Login_Exit_button);
            this.Controls.Add(this.Lg_Password_textBox2);
            this.Controls.Add(this.LG_ID_textBox);
            this.Controls.Add(this.Student_button);
            this.Controls.Add(this.UR_button);
            this.Controls.Add(this.Sign_Up_button);
            this.Controls.Add(this.Lof_in_button);
            this.Controls.Add(this.Pass_login_label);
            this.Controls.Add(this.ID_label_login);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button Student_button;
        private System.Windows.Forms.TextBox LG_ID_textBox;
        private System.Windows.Forms.TextBox Lg_Password_textBox2;
        private System.Windows.Forms.Button Login_Exit_button;
        private System.Windows.Forms.Button LogIN_Clear_button;
    }
}