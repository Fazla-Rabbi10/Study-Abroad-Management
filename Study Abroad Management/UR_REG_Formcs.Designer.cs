namespace Study_Abroad_Management
{
    partial class UR_REG_Formcs
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
            this.UR_gender_comboBox = new System.Windows.Forms.ComboBox();
            this.UR_submit_button = new System.Windows.Forms.Button();
            this.UR_pass_textBox = new System.Windows.Forms.TextBox();
            this.UR_EIIN_textBox = new System.Windows.Forms.TextBox();
            this.UR_university_textBox = new System.Windows.Forms.TextBox();
            this.UR_email_textBox = new System.Windows.Forms.TextBox();
            this.UR_pass_label = new System.Windows.Forms.Label();
            this.EIIN_label = new System.Windows.Forms.Label();
            this.UR_gender_label = new System.Windows.Forms.Label();
            this.UR_Uni_name_label = new System.Windows.Forms.Label();
            this.UR_email_label = new System.Windows.Forms.Label();
            this.UR_name_textBox = new System.Windows.Forms.TextBox();
            this.Ur_count__reg_label = new System.Windows.Forms.Label();
            this.UR_reg_name_label = new System.Windows.Forms.Label();
            this.UR_reg_label = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.exitbuttonURreg = new System.Windows.Forms.Button();
            this.BackbuttonURreg = new System.Windows.Forms.Button();
            this.ClearButtonURReg = new System.Windows.Forms.Button();
            this.UR_count_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UR_gender_comboBox
            // 
            this.UR_gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UR_gender_comboBox.FormattingEnabled = true;
            this.UR_gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.UR_gender_comboBox.Location = new System.Drawing.Point(378, 457);
            this.UR_gender_comboBox.Name = "UR_gender_comboBox";
            this.UR_gender_comboBox.Size = new System.Drawing.Size(121, 24);
            this.UR_gender_comboBox.TabIndex = 7;
            // 
            // UR_submit_button
            // 
            this.UR_submit_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UR_submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UR_submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UR_submit_button.ForeColor = System.Drawing.SystemColors.Control;
            this.UR_submit_button.Location = new System.Drawing.Point(378, 569);
            this.UR_submit_button.Name = "UR_submit_button";
            this.UR_submit_button.Size = new System.Drawing.Size(211, 47);
            this.UR_submit_button.TabIndex = 41;
            this.UR_submit_button.Text = "Submit";
            this.UR_submit_button.UseVisualStyleBackColor = false;
            this.UR_submit_button.Click += new System.EventHandler(this.UR_submit_button_Click);
            // 
            // UR_pass_textBox
            // 
            this.UR_pass_textBox.Location = new System.Drawing.Point(378, 376);
            this.UR_pass_textBox.Name = "UR_pass_textBox";
            this.UR_pass_textBox.Size = new System.Drawing.Size(100, 22);
            this.UR_pass_textBox.TabIndex = 5;
            this.UR_pass_textBox.TextChanged += new System.EventHandler(this.UR_pass_textBox_TextChanged);
            this.UR_pass_textBox.Leave += new System.EventHandler(this.UR_pass_textBox_Leave);
            // 
            // UR_EIIN_textBox
            // 
            this.UR_EIIN_textBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.UR_EIIN_textBox.Location = new System.Drawing.Point(733, 376);
            this.UR_EIIN_textBox.Name = "UR_EIIN_textBox";
            this.UR_EIIN_textBox.Size = new System.Drawing.Size(100, 22);
            this.UR_EIIN_textBox.TabIndex = 6;
            this.UR_EIIN_textBox.Text = "6 Digits";
            this.UR_EIIN_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UR_EIIN_textBox.TextChanged += new System.EventHandler(this.UR_EIIN_textBox_TextChanged);
            this.UR_EIIN_textBox.Leave += new System.EventHandler(this.UR_EIIN_textBox_Leave);
            // 
            // UR_university_textBox
            // 
            this.UR_university_textBox.Location = new System.Drawing.Point(733, 297);
            this.UR_university_textBox.Name = "UR_university_textBox";
            this.UR_university_textBox.Size = new System.Drawing.Size(121, 22);
            this.UR_university_textBox.TabIndex = 4;
            this.UR_university_textBox.TextChanged += new System.EventHandler(this.UR_university_textBox_TextChanged);
            this.UR_university_textBox.Leave += new System.EventHandler(this.UR_university_textBox_Leave);
            // 
            // UR_email_textBox
            // 
            this.UR_email_textBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.UR_email_textBox.Location = new System.Drawing.Point(733, 230);
            this.UR_email_textBox.Name = "UR_email_textBox";
            this.UR_email_textBox.Size = new System.Drawing.Size(121, 22);
            this.UR_email_textBox.TabIndex = 1;
            this.UR_email_textBox.Text = "abc@gmail.com";
            this.UR_email_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UR_email_textBox.TextChanged += new System.EventHandler(this.UR_email_textBox_TextChanged);
            this.UR_email_textBox.Leave += new System.EventHandler(this.UR_email_textBox_Leave);
            // 
            // UR_pass_label
            // 
            this.UR_pass_label.AutoSize = true;
            this.UR_pass_label.Location = new System.Drawing.Point(281, 382);
            this.UR_pass_label.Name = "UR_pass_label";
            this.UR_pass_label.Size = new System.Drawing.Size(73, 16);
            this.UR_pass_label.TabIndex = 36;
            this.UR_pass_label.Text = "Password :";
            // 
            // EIIN_label
            // 
            this.EIIN_label.AutoSize = true;
            this.EIIN_label.Location = new System.Drawing.Point(652, 382);
            this.EIIN_label.Name = "EIIN_label";
            this.EIIN_label.Size = new System.Drawing.Size(38, 16);
            this.EIIN_label.TabIndex = 35;
            this.EIIN_label.Text = "EIIN :";
            // 
            // UR_gender_label
            // 
            this.UR_gender_label.AutoSize = true;
            this.UR_gender_label.Location = new System.Drawing.Point(287, 460);
            this.UR_gender_label.Name = "UR_gender_label";
            this.UR_gender_label.Size = new System.Drawing.Size(58, 16);
            this.UR_gender_label.TabIndex = 34;
            this.UR_gender_label.Text = "Gender :";
            // 
            // UR_Uni_name_label
            // 
            this.UR_Uni_name_label.AutoSize = true;
            this.UR_Uni_name_label.Location = new System.Drawing.Point(585, 297);
            this.UR_Uni_name_label.Name = "UR_Uni_name_label";
            this.UR_Uni_name_label.Size = new System.Drawing.Size(112, 16);
            this.UR_Uni_name_label.TabIndex = 33;
            this.UR_Uni_name_label.Text = "University Name :";
            // 
            // UR_email_label
            // 
            this.UR_email_label.AutoSize = true;
            this.UR_email_label.Location = new System.Drawing.Point(644, 233);
            this.UR_email_label.Name = "UR_email_label";
            this.UR_email_label.Size = new System.Drawing.Size(47, 16);
            this.UR_email_label.TabIndex = 32;
            this.UR_email_label.Text = "Email :";
            // 
            // UR_name_textBox
            // 
            this.UR_name_textBox.Location = new System.Drawing.Point(378, 230);
            this.UR_name_textBox.Name = "UR_name_textBox";
            this.UR_name_textBox.Size = new System.Drawing.Size(100, 22);
            this.UR_name_textBox.TabIndex = 0;
            this.UR_name_textBox.TextChanged += new System.EventHandler(this.UR_name_textBox_TextChanged);
            this.UR_name_textBox.Leave += new System.EventHandler(this.UR_name_textBox_Leave);
            // 
            // Ur_count__reg_label
            // 
            this.Ur_count__reg_label.AutoSize = true;
            this.Ur_count__reg_label.Location = new System.Drawing.Point(229, 308);
            this.Ur_count__reg_label.Name = "Ur_count__reg_label";
            this.Ur_count__reg_label.Size = new System.Drawing.Size(125, 16);
            this.Ur_count__reg_label.TabIndex = 28;
            this.Ur_count__reg_label.Text = "Nationality/Country :";
            // 
            // UR_reg_name_label
            // 
            this.UR_reg_name_label.AutoSize = true;
            this.UR_reg_name_label.Location = new System.Drawing.Point(295, 230);
            this.UR_reg_name_label.Name = "UR_reg_name_label";
            this.UR_reg_name_label.Size = new System.Drawing.Size(50, 16);
            this.UR_reg_name_label.TabIndex = 27;
            this.UR_reg_name_label.Text = "Name :";
            // 
            // UR_reg_label
            // 
            this.UR_reg_label.AutoSize = true;
            this.UR_reg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UR_reg_label.Location = new System.Drawing.Point(355, 83);
            this.UR_reg_label.Name = "UR_reg_label";
            this.UR_reg_label.Size = new System.Drawing.Size(458, 29);
            this.UR_reg_label.TabIndex = 26;
            this.UR_reg_label.Text = "University Representative Registration";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(285, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(614, 61);
            this.Title.TabIndex = 45;
            this.Title.Text = "Abroad Higher Study Soltuin";
            // 
            // exitbuttonURreg
            // 
            this.exitbuttonURreg.BackColor = System.Drawing.Color.Crimson;
            this.exitbuttonURreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitbuttonURreg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbuttonURreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbuttonURreg.ForeColor = System.Drawing.SystemColors.Control;
            this.exitbuttonURreg.Location = new System.Drawing.Point(1037, 26);
            this.exitbuttonURreg.Name = "exitbuttonURreg";
            this.exitbuttonURreg.Size = new System.Drawing.Size(85, 38);
            this.exitbuttonURreg.TabIndex = 46;
            this.exitbuttonURreg.Text = "Exit";
            this.exitbuttonURreg.UseVisualStyleBackColor = false;
            this.exitbuttonURreg.Click += new System.EventHandler(this.exitbuttonURreg_Click);
            // 
            // BackbuttonURreg
            // 
            this.BackbuttonURreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackbuttonURreg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackbuttonURreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackbuttonURreg.Location = new System.Drawing.Point(37, 26);
            this.BackbuttonURreg.Name = "BackbuttonURreg";
            this.BackbuttonURreg.Size = new System.Drawing.Size(80, 34);
            this.BackbuttonURreg.TabIndex = 47;
            this.BackbuttonURreg.Text = "Back";
            this.BackbuttonURreg.UseVisualStyleBackColor = true;
            this.BackbuttonURreg.Click += new System.EventHandler(this.BackbuttonURreg_Click);
            // 
            // ClearButtonURReg
            // 
            this.ClearButtonURReg.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClearButtonURReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearButtonURReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButtonURReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButtonURReg.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearButtonURReg.Location = new System.Drawing.Point(655, 569);
            this.ClearButtonURReg.Name = "ClearButtonURReg";
            this.ClearButtonURReg.Size = new System.Drawing.Size(199, 47);
            this.ClearButtonURReg.TabIndex = 48;
            this.ClearButtonURReg.Text = "Clear";
            this.ClearButtonURReg.UseVisualStyleBackColor = false;
            this.ClearButtonURReg.Click += new System.EventHandler(this.ClearButtonURReg_Click);
            // 
            // UR_count_comboBox
            // 
            this.UR_count_comboBox.FormattingEnabled = true;
            this.UR_count_comboBox.Items.AddRange(new object[] {
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
            this.UR_count_comboBox.Location = new System.Drawing.Point(378, 300);
            this.UR_count_comboBox.Name = "UR_count_comboBox";
            this.UR_count_comboBox.Size = new System.Drawing.Size(121, 24);
            this.UR_count_comboBox.TabIndex = 2;
            this.UR_count_comboBox.TextChanged += new System.EventHandler(this.UR_count_comboBox_TextChanged);
            this.UR_count_comboBox.Leave += new System.EventHandler(this.UR_count_comboBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // UR_REG_Formcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 726);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UR_count_comboBox);
            this.Controls.Add(this.ClearButtonURReg);
            this.Controls.Add(this.BackbuttonURreg);
            this.Controls.Add(this.exitbuttonURreg);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.UR_gender_comboBox);
            this.Controls.Add(this.UR_submit_button);
            this.Controls.Add(this.UR_pass_textBox);
            this.Controls.Add(this.UR_EIIN_textBox);
            this.Controls.Add(this.UR_university_textBox);
            this.Controls.Add(this.UR_email_textBox);
            this.Controls.Add(this.UR_pass_label);
            this.Controls.Add(this.EIIN_label);
            this.Controls.Add(this.UR_gender_label);
            this.Controls.Add(this.UR_Uni_name_label);
            this.Controls.Add(this.UR_email_label);
            this.Controls.Add(this.UR_name_textBox);
            this.Controls.Add(this.Ur_count__reg_label);
            this.Controls.Add(this.UR_reg_name_label);
            this.Controls.Add(this.UR_reg_label);
            this.MaximizeBox = false;
            this.Name = "UR_REG_Formcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UR_REG_Formcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UR_gender_comboBox;
        private System.Windows.Forms.Button UR_submit_button;
        private System.Windows.Forms.TextBox UR_pass_textBox;
        private System.Windows.Forms.TextBox UR_EIIN_textBox;
        private System.Windows.Forms.TextBox UR_university_textBox;
        private System.Windows.Forms.TextBox UR_email_textBox;
        private System.Windows.Forms.Label UR_pass_label;
        private System.Windows.Forms.Label EIIN_label;
        private System.Windows.Forms.Label UR_gender_label;
        private System.Windows.Forms.Label UR_Uni_name_label;
        private System.Windows.Forms.Label UR_email_label;
        private System.Windows.Forms.TextBox UR_name_textBox;
        private System.Windows.Forms.Label Ur_count__reg_label;
        private System.Windows.Forms.Label UR_reg_name_label;
        private System.Windows.Forms.Label UR_reg_label;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button exitbuttonURreg;
        private System.Windows.Forms.Button BackbuttonURreg;
        private System.Windows.Forms.Button ClearButtonURReg;
        private System.Windows.Forms.ComboBox UR_count_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}