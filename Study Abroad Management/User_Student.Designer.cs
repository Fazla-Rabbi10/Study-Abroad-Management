namespace Study_Abroad_Management
{
    partial class User_Student
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
            this.Studentlabel = new System.Windows.Forms.Label();
            this.StudentIDlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserSTD_label = new System.Windows.Forms.Label();
            this.user_Studnet_search_textBox = new System.Windows.Forms.TextBox();
            this.Student_Show_button = new System.Windows.Forms.Button();
            this.student_apply_button = new System.Windows.Forms.Button();
            this.applyINFO_button = new System.Windows.Forms.Button();
            this.for_apply_dataGridView = new System.Windows.Forms.DataGridView();
            this.search_bylabel = new System.Windows.Forms.Label();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.Exit_button2 = new System.Windows.Forms.Button();
            this.Clear_button1 = new System.Windows.Forms.Button();
            this.Course_Detail_button1 = new System.Windows.Forms.Button();
            this.refreshbuttonstudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.for_apply_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Studentlabel
            // 
            this.Studentlabel.AutoSize = true;
            this.Studentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentlabel.Location = new System.Drawing.Point(123, 3);
            this.Studentlabel.Name = "Studentlabel";
            this.Studentlabel.Size = new System.Drawing.Size(70, 25);
            this.Studentlabel.TabIndex = 48;
            this.Studentlabel.Text = "label1";
            // 
            // StudentIDlabel
            // 
            this.StudentIDlabel.AutoSize = true;
            this.StudentIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDlabel.Location = new System.Drawing.Point(952, 3);
            this.StudentIDlabel.Name = "StudentIDlabel";
            this.StudentIDlabel.Size = new System.Drawing.Size(70, 25);
            this.StudentIDlabel.TabIndex = 49;
            this.StudentIDlabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 46);
            this.label1.TabIndex = 50;
            this.label1.Text = "Abroad Higher Study Solution";
            // 
            // UserSTD_label
            // 
            this.UserSTD_label.AutoSize = true;
            this.UserSTD_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSTD_label.Location = new System.Drawing.Point(856, 61);
            this.UserSTD_label.Name = "UserSTD_label";
            this.UserSTD_label.Size = new System.Drawing.Size(94, 25);
            this.UserSTD_label.TabIndex = 51;
            this.UserSTD_label.Text = "Search :";
            // 
            // user_Studnet_search_textBox
            // 
            this.user_Studnet_search_textBox.Location = new System.Drawing.Point(957, 60);
            this.user_Studnet_search_textBox.Multiline = true;
            this.user_Studnet_search_textBox.Name = "user_Studnet_search_textBox";
            this.user_Studnet_search_textBox.Size = new System.Drawing.Size(146, 30);
            this.user_Studnet_search_textBox.TabIndex = 0;
            this.user_Studnet_search_textBox.TextChanged += new System.EventHandler(this.user_Studnet_search_textBox_TextChanged);
            // 
            // Student_Show_button
            // 
            this.Student_Show_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Student_Show_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Student_Show_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Student_Show_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Show_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Student_Show_button.Location = new System.Drawing.Point(36, 177);
            this.Student_Show_button.Name = "Student_Show_button";
            this.Student_Show_button.Size = new System.Drawing.Size(229, 66);
            this.Student_Show_button.TabIndex = 53;
            this.Student_Show_button.Text = "Show Courses";
            this.Student_Show_button.UseVisualStyleBackColor = false;
            this.Student_Show_button.Click += new System.EventHandler(this.Student_Show_button_Click);
            // 
            // student_apply_button
            // 
            this.student_apply_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.student_apply_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.student_apply_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.student_apply_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_apply_button.ForeColor = System.Drawing.SystemColors.Control;
            this.student_apply_button.Location = new System.Drawing.Point(36, 386);
            this.student_apply_button.Name = "student_apply_button";
            this.student_apply_button.Size = new System.Drawing.Size(229, 66);
            this.student_apply_button.TabIndex = 54;
            this.student_apply_button.Text = "Apply";
            this.student_apply_button.UseVisualStyleBackColor = false;
            this.student_apply_button.Click += new System.EventHandler(this.student_apply_button_Click);
            // 
            // applyINFO_button
            // 
            this.applyINFO_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.applyINFO_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.applyINFO_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applyINFO_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyINFO_button.ForeColor = System.Drawing.SystemColors.Control;
            this.applyINFO_button.Location = new System.Drawing.Point(36, 495);
            this.applyINFO_button.Name = "applyINFO_button";
            this.applyINFO_button.Size = new System.Drawing.Size(229, 66);
            this.applyINFO_button.TabIndex = 55;
            this.applyINFO_button.Text = "Application Info";
            this.applyINFO_button.UseVisualStyleBackColor = false;
            this.applyINFO_button.Click += new System.EventHandler(this.applyINFO_button_Click);
            // 
            // for_apply_dataGridView
            // 
            this.for_apply_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.for_apply_dataGridView.Location = new System.Drawing.Point(320, 123);
            this.for_apply_dataGridView.Name = "for_apply_dataGridView";
            this.for_apply_dataGridView.RowHeadersWidth = 51;
            this.for_apply_dataGridView.RowTemplate.Height = 24;
            this.for_apply_dataGridView.Size = new System.Drawing.Size(804, 579);
            this.for_apply_dataGridView.TabIndex = 56;
            this.for_apply_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.for_apply_dataGridView_CellClick);
            // 
            // search_bylabel
            // 
            this.search_bylabel.AutoSize = true;
            this.search_bylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bylabel.Location = new System.Drawing.Point(954, 93);
            this.search_bylabel.Name = "search_bylabel";
            this.search_bylabel.Size = new System.Drawing.Size(134, 16);
            this.search_bylabel.TabIndex = 57;
            this.search_bylabel.Text = "Search By Country";
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LogOutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogOutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.LogOutbutton.Location = new System.Drawing.Point(36, 602);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(229, 66);
            this.LogOutbutton.TabIndex = 58;
            this.LogOutbutton.Text = "Log Out";
            this.LogOutbutton.UseVisualStyleBackColor = false;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // Exit_button2
            // 
            this.Exit_button2.BackColor = System.Drawing.Color.Crimson;
            this.Exit_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit_button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button2.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit_button2.Location = new System.Drawing.Point(0, 0);
            this.Exit_button2.Name = "Exit_button2";
            this.Exit_button2.Size = new System.Drawing.Size(81, 36);
            this.Exit_button2.TabIndex = 59;
            this.Exit_button2.Text = "Exit";
            this.Exit_button2.UseVisualStyleBackColor = false;
            this.Exit_button2.Click += new System.EventHandler(this.Exit_button2_Click);
            // 
            // Clear_button1
            // 
            this.Clear_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clear_button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button1.Location = new System.Drawing.Point(861, 89);
            this.Clear_button1.Name = "Clear_button1";
            this.Clear_button1.Size = new System.Drawing.Size(74, 28);
            this.Clear_button1.TabIndex = 60;
            this.Clear_button1.Text = "Clear";
            this.Clear_button1.UseVisualStyleBackColor = true;
            this.Clear_button1.Click += new System.EventHandler(this.Clear_button1_Click);
            // 
            // Course_Detail_button1
            // 
            this.Course_Detail_button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Course_Detail_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Course_Detail_button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Course_Detail_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Detail_button1.ForeColor = System.Drawing.SystemColors.Control;
            this.Course_Detail_button1.Location = new System.Drawing.Point(36, 279);
            this.Course_Detail_button1.Name = "Course_Detail_button1";
            this.Course_Detail_button1.Size = new System.Drawing.Size(229, 66);
            this.Course_Detail_button1.TabIndex = 61;
            this.Course_Detail_button1.Text = "Course Details";
            this.Course_Detail_button1.UseVisualStyleBackColor = false;
            this.Course_Detail_button1.Click += new System.EventHandler(this.Course_Detail_button1_Click);
            // 
            // refreshbuttonstudent
            // 
            this.refreshbuttonstudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshbuttonstudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshbuttonstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbuttonstudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshbuttonstudent.Location = new System.Drawing.Point(320, 86);
            this.refreshbuttonstudent.Name = "refreshbuttonstudent";
            this.refreshbuttonstudent.Size = new System.Drawing.Size(108, 29);
            this.refreshbuttonstudent.TabIndex = 70;
            this.refreshbuttonstudent.Text = "Refresh";
            this.refreshbuttonstudent.UseVisualStyleBackColor = false;
            this.refreshbuttonstudent.Click += new System.EventHandler(this.refreshbuttonstudent_Click);
            // 
            // User_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 726);
            this.Controls.Add(this.refreshbuttonstudent);
            this.Controls.Add(this.Course_Detail_button1);
            this.Controls.Add(this.Clear_button1);
            this.Controls.Add(this.Exit_button2);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.search_bylabel);
            this.Controls.Add(this.for_apply_dataGridView);
            this.Controls.Add(this.applyINFO_button);
            this.Controls.Add(this.student_apply_button);
            this.Controls.Add(this.Student_Show_button);
            this.Controls.Add(this.user_Studnet_search_textBox);
            this.Controls.Add(this.UserSTD_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentIDlabel);
            this.Controls.Add(this.Studentlabel);
            this.MaximizeBox = false;
            this.Name = "User_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Student";
            this.Load += new System.EventHandler(this.User_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.for_apply_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Studentlabel;
        private System.Windows.Forms.Label StudentIDlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserSTD_label;
        private System.Windows.Forms.TextBox user_Studnet_search_textBox;
        private System.Windows.Forms.Button Student_Show_button;
        private System.Windows.Forms.Button student_apply_button;
        private System.Windows.Forms.Button applyINFO_button;
        private System.Windows.Forms.DataGridView for_apply_dataGridView;
        private System.Windows.Forms.Label search_bylabel;
        private System.Windows.Forms.Button LogOutbutton;
        private System.Windows.Forms.Button Exit_button2;
        private System.Windows.Forms.Button Clear_button1;
        private System.Windows.Forms.Button Course_Detail_button1;
        private System.Windows.Forms.Button refreshbuttonstudent;
    }
}