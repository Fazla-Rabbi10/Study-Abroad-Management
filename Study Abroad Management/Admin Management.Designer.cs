namespace Study_Abroad_Management
{
    partial class Admin_Management
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
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showButton = new System.Windows.Forms.Button();
            this.AddAdminbutton = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delet = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.nm_txtbx = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.email_txtbx = new System.Windows.Forms.TextBox();
            this.id_txtbx = new System.Windows.Forms.TextBox();
            this.addrs_txtbx = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.dgvAdmTbl = new System.Windows.Forms.DataGridView();
            this.contact = new System.Windows.Forms.Label();
            this.contact_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cntry = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 102);
            this.panel1.TabIndex = 0;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(16, 11);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 52);
            this.back.TabIndex = 3;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showButton);
            this.panel2.Controls.Add(this.AddAdminbutton);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.delet);
            this.panel2.Location = new System.Drawing.Point(28, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1404, 66);
            this.panel2.TabIndex = 1;
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(940, 5);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(126, 56);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click_1);
            // 
            // AddAdminbutton
            // 
            this.AddAdminbutton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdminbutton.Location = new System.Drawing.Point(787, 5);
            this.AddAdminbutton.Name = "AddAdminbutton";
            this.AddAdminbutton.Size = new System.Drawing.Size(126, 56);
            this.AddAdminbutton.TabIndex = 3;
            this.AddAdminbutton.Text = "Add";
            this.AddAdminbutton.UseVisualStyleBackColor = true;
            this.AddAdminbutton.Click += new System.EventHandler(this.AddAdminbutton_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(1092, 6);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(126, 56);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delet
            // 
            this.delet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delet.Location = new System.Drawing.Point(1239, 6);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(126, 56);
            this.delet.TabIndex = 2;
            this.delet.Text = "Delete";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Click += new System.EventHandler(this.delet_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(308, 214);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(101, 37);
            this.name.TabIndex = 2;
            this.name.Text = "Name :";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // nm_txtbx
            // 
            this.nm_txtbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_txtbx.Location = new System.Drawing.Point(405, 215);
            this.nm_txtbx.Multiline = true;
            this.nm_txtbx.Name = "nm_txtbx";
            this.nm_txtbx.Size = new System.Drawing.Size(467, 36);
            this.nm_txtbx.TabIndex = 3;
            this.nm_txtbx.TextChanged += new System.EventHandler(this.nm_txtbx_TextChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(41, 273);
            this.email.Name = "email";
            this.email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email.Size = new System.Drawing.Size(106, 37);
            this.email.TabIndex = 5;
            this.email.Text = "E-mail :";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // email_txtbx
            // 
            this.email_txtbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txtbx.Location = new System.Drawing.Point(136, 274);
            this.email_txtbx.Multiline = true;
            this.email_txtbx.Name = "email_txtbx";
            this.email_txtbx.Size = new System.Drawing.Size(442, 37);
            this.email_txtbx.TabIndex = 6;
            this.email_txtbx.TextChanged += new System.EventHandler(this.email_txtbx_TextChanged);
            // 
            // id_txtbx
            // 
            this.id_txtbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txtbx.Location = new System.Drawing.Point(136, 214);
            this.id_txtbx.Multiline = true;
            this.id_txtbx.Name = "id_txtbx";
            this.id_txtbx.Size = new System.Drawing.Size(136, 36);
            this.id_txtbx.TabIndex = 7;
            this.id_txtbx.TextChanged += new System.EventHandler(this.id_txtbx_TextChanged);
            // 
            // addrs_txtbx
            // 
            this.addrs_txtbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrs_txtbx.Location = new System.Drawing.Point(1034, 216);
            this.addrs_txtbx.Multiline = true;
            this.addrs_txtbx.Name = "addrs_txtbx";
            this.addrs_txtbx.Size = new System.Drawing.Size(368, 36);
            this.addrs_txtbx.TabIndex = 8;
            this.addrs_txtbx.TextChanged += new System.EventHandler(this.stts_txtbx_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(41, 213);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(98, 37);
            this.id.TabIndex = 9;
            this.id.Text = "ID      : ";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(911, 215);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(131, 37);
            this.Address.TabIndex = 10;
            this.Address.Text = "Address : ";
            this.Address.Click += new System.EventHandler(this.sttus_Click);
            // 
            // dgvAdmTbl
            // 
            this.dgvAdmTbl.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAdmTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmTbl.Location = new System.Drawing.Point(28, 356);
            this.dgvAdmTbl.Name = "dgvAdmTbl";
            this.dgvAdmTbl.RowHeadersWidth = 82;
            this.dgvAdmTbl.RowTemplate.Height = 33;
            this.dgvAdmTbl.Size = new System.Drawing.Size(1374, 529);
            this.dgvAdmTbl.TabIndex = 11;
            this.dgvAdmTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmTbl_CellContentClick);
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(983, 273);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(129, 37);
            this.contact.TabIndex = 19;
            this.contact.Text = "Contact  :";
            // 
            // contact_txtbx
            // 
            this.contact_txtbx.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_txtbx.Location = new System.Drawing.Point(1102, 275);
            this.contact_txtbx.Multiline = true;
            this.contact_txtbx.Name = "contact_txtbx";
            this.contact_txtbx.Size = new System.Drawing.Size(300, 40);
            this.contact_txtbx.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(598, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Country :";
            // 
            // cntry
            // 
            this.cntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntry.Location = new System.Drawing.Point(711, 275);
            this.cntry.Multiline = true;
            this.cntry.Name = "cntry";
            this.cntry.Size = new System.Drawing.Size(251, 36);
            this.cntry.TabIndex = 14;
            // 
            // Admin_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1430, 914);
            this.Controls.Add(this.contact_txtbx);
            this.Controls.Add(this.cntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.dgvAdmTbl);
            this.Controls.Add(this.id);
            this.Controls.Add(this.id_txtbx);
            this.Controls.Add(this.email_txtbx);
            this.Controls.Add(this.email);
            this.Controls.Add(this.addrs_txtbx);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.nm_txtbx);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Management";
            this.Load += new System.EventHandler(this.Admin_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.Button AddAdminbutton;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nm_txtbx;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox email_txtbx;
        private System.Windows.Forms.TextBox id_txtbx;
        private System.Windows.Forms.TextBox addrs_txtbx;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.DataGridView dgvAdmTbl;
        private System.Windows.Forms.TextBox contact_txtbx;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cntry;
    }
}