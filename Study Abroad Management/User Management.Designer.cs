namespace Study_Abroad_Management
{
    partial class User_Management
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminIDlabel = new System.Windows.Forms.Label();
            this.Adminlabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delet_txtbox = new System.Windows.Forms.Button();
            this.updt = new System.Windows.Forms.Button();
            this.age_txtbx = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.nty_txtbox = new System.Windows.Forms.TextBox();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.nty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.show = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Label();
            this.search_by_nm = new System.Windows.Forms.TextBox();
            this.search_option = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.check_apply_button = new System.Windows.Forms.Button();
            this.Apply_remove_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AdminIDlabel);
            this.panel1.Controls.Add(this.Adminlabel);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 112);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AdminIDlabel
            // 
            this.AdminIDlabel.AutoSize = true;
            this.AdminIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIDlabel.Location = new System.Drawing.Point(980, 6);
            this.AdminIDlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminIDlabel.Name = "AdminIDlabel";
            this.AdminIDlabel.Size = new System.Drawing.Size(108, 37);
            this.AdminIDlabel.TabIndex = 52;
            this.AdminIDlabel.Text = "label2";
            // 
            // Adminlabel
            // 
            this.Adminlabel.AutoSize = true;
            this.Adminlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminlabel.Location = new System.Drawing.Point(218, 0);
            this.Adminlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Adminlabel.Name = "Adminlabel";
            this.Adminlabel.Size = new System.Drawing.Size(106, 37);
            this.Adminlabel.TabIndex = 51;
            this.Adminlabel.Text = "label1";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1282, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(102, 48);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(-2, 6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 48);
            this.back.TabIndex = 2;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Management ( Student )";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin panel";
            // 
            // delet_txtbox
            // 
            this.delet_txtbox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delet_txtbox.Location = new System.Drawing.Point(1264, 128);
            this.delet_txtbox.Name = "delet_txtbox";
            this.delet_txtbox.Size = new System.Drawing.Size(132, 52);
            this.delet_txtbox.TabIndex = 3;
            this.delet_txtbox.Text = "Delete";
            this.delet_txtbox.UseVisualStyleBackColor = true;
            this.delet_txtbox.Click += new System.EventHandler(this.delet_txtbox_Click);
            // 
            // updt
            // 
            this.updt.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updt.Location = new System.Drawing.Point(1106, 128);
            this.updt.Name = "updt";
            this.updt.Size = new System.Drawing.Size(132, 52);
            this.updt.TabIndex = 4;
            this.updt.Text = "Update";
            this.updt.UseVisualStyleBackColor = true;
            this.updt.Click += new System.EventHandler(this.updt_Click);
            // 
            // age_txtbx
            // 
            this.age_txtbx.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_txtbx.Location = new System.Drawing.Point(1202, 258);
            this.age_txtbx.Multiline = true;
            this.age_txtbx.Name = "age_txtbx";
            this.age_txtbx.Size = new System.Drawing.Size(176, 45);
            this.age_txtbx.TabIndex = 28;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(1119, 255);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(77, 37);
            this.age.TabIndex = 27;
            this.age.Text = "Age :";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtbox.Location = new System.Drawing.Point(424, 200);
            this.name_txtbox.Multiline = true;
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(480, 45);
            this.name_txtbox.TabIndex = 26;
            // 
            // nty_txtbox
            // 
            this.nty_txtbox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nty_txtbox.Location = new System.Drawing.Point(1107, 197);
            this.nty_txtbox.Multiline = true;
            this.nty_txtbox.Name = "nty_txtbox";
            this.nty_txtbox.Size = new System.Drawing.Size(274, 45);
            this.nty_txtbox.TabIndex = 25;
            // 
            // email_txtbox
            // 
            this.email_txtbox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txtbox.Location = new System.Drawing.Point(146, 255);
            this.email_txtbox.Multiline = true;
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(480, 45);
            this.email_txtbox.TabIndex = 24;
            // 
            // id_txtbox
            // 
            this.id_txtbox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txtbox.Location = new System.Drawing.Point(146, 197);
            this.id_txtbox.Multiline = true;
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.ReadOnly = true;
            this.id_txtbox.Size = new System.Drawing.Size(170, 45);
            this.id_txtbox.TabIndex = 23;
            this.id_txtbox.TextChanged += new System.EventHandler(this.id_txtbox_TextChanged);
            // 
            // nty
            // 
            this.nty.AutoSize = true;
            this.nty.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nty.Location = new System.Drawing.Point(945, 208);
            this.nty.Name = "nty";
            this.nty.Size = new System.Drawing.Size(161, 37);
            this.nty.TabIndex = 22;
            this.nty.Text = "Nationality :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "Name :";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(52, 197);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(91, 37);
            this.ID.TabIndex = 19;
            this.ID.Text = "ID      :";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(807, 258);
            this.gender.Multiline = true;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Size = new System.Drawing.Size(272, 45);
            this.gender.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(684, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 37);
            this.label3.TabIndex = 30;
            this.label3.Text = "Gender :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1362, 538);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(952, 128);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(132, 52);
            this.show.TabIndex = 32;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(52, 134);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(108, 37);
            this.search.TabIndex = 33;
            this.search.Text = "Search :";
            // 
            // search_by_nm
            // 
            this.search_by_nm.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_by_nm.Location = new System.Drawing.Point(154, 131);
            this.search_by_nm.Multiline = true;
            this.search_by_nm.Name = "search_by_nm";
            this.search_by_nm.Size = new System.Drawing.Size(162, 45);
            this.search_by_nm.TabIndex = 34;
            this.search_by_nm.TextChanged += new System.EventHandler(this.search_by_nm_TextChanged);
            // 
            // search_option
            // 
            this.search_option.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_option.FormattingEnabled = true;
            this.search_option.Items.AddRange(new object[] {
            "Name",
            "ID"});
            this.search_option.Location = new System.Drawing.Point(398, 136);
            this.search_option.Name = "search_option";
            this.search_option.Size = new System.Drawing.Size(128, 40);
            this.search_option.TabIndex = 36;
            this.search_option.SelectedIndexChanged += new System.EventHandler(this.search_option_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 30);
            this.label4.TabIndex = 37;
            this.label4.Text = "( by )";
            // 
            // check_apply_button
            // 
            this.check_apply_button.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_apply_button.Location = new System.Drawing.Point(659, 131);
            this.check_apply_button.Name = "check_apply_button";
            this.check_apply_button.Size = new System.Drawing.Size(132, 52);
            this.check_apply_button.TabIndex = 38;
            this.check_apply_button.Text = "Check";
            this.check_apply_button.UseVisualStyleBackColor = true;
            this.check_apply_button.Click += new System.EventHandler(this.check_apply_button_Click);
            // 
            // Apply_remove_button
            // 
            this.Apply_remove_button.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply_remove_button.Location = new System.Drawing.Point(807, 128);
            this.Apply_remove_button.Name = "Apply_remove_button";
            this.Apply_remove_button.Size = new System.Drawing.Size(124, 52);
            this.Apply_remove_button.TabIndex = 39;
            this.Apply_remove_button.Text = "Remove ";
            this.Apply_remove_button.UseVisualStyleBackColor = true;
            this.Apply_remove_button.Click += new System.EventHandler(this.Apply_remove_button_Click);
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 914);
            this.Controls.Add(this.Apply_remove_button);
            this.Controls.Add(this.check_apply_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search_option);
            this.Controls.Add(this.search_by_nm);
            this.Controls.Add(this.search);
            this.Controls.Add(this.show);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age_txtbx);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.nty_txtbox);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.nty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.updt);
            this.Controls.Add(this.delet_txtbox);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Management";
            this.Load += new System.EventHandler(this.User_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button delet_txtbox;
        private System.Windows.Forms.Button updt;
        private System.Windows.Forms.TextBox age_txtbx;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox nty_txtbox;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.Label nty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox search_by_nm;
        private System.Windows.Forms.Label AdminIDlabel;
        private System.Windows.Forms.Label Adminlabel;
        private System.Windows.Forms.ComboBox search_option;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button check_apply_button;
        private System.Windows.Forms.Button Apply_remove_button;
    }
}