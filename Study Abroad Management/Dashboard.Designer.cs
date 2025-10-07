namespace Study_Abroad_Management
{
    partial class Dashboard
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
            System.Windows.Forms.TextBox id_txtbox;
            this.ur_pnl = new System.Windows.Forms.Panel();
            this.AdminIDlabel = new System.Windows.Forms.Label();
            this.Adminlabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.ur_dshbrd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showButton = new System.Windows.Forms.Button();
            this.delet = new System.Windows.Forms.Button();
            this.dgvUrDs = new System.Windows.Forms.DataGridView();
            this.search_by_nm = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            id_txtbox = new System.Windows.Forms.TextBox();
            this.ur_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrDs)).BeginInit();
            this.SuspendLayout();
            // 
            // ur_pnl
            // 
            this.ur_pnl.Controls.Add(this.AdminIDlabel);
            this.ur_pnl.Controls.Add(this.Adminlabel);
            this.ur_pnl.Controls.Add(this.exit);
            this.ur_pnl.Controls.Add(this.back);
            this.ur_pnl.Controls.Add(this.ur_dshbrd);
            this.ur_pnl.Controls.Add(this.label1);
            this.ur_pnl.Location = new System.Drawing.Point(10, 12);
            this.ur_pnl.Name = "ur_pnl";
            this.ur_pnl.Size = new System.Drawing.Size(1406, 117);
            this.ur_pnl.TabIndex = 1;
            // 
            // AdminIDlabel
            // 
            this.AdminIDlabel.AutoSize = true;
            this.AdminIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIDlabel.Location = new System.Drawing.Point(968, 16);
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
            this.Adminlabel.Location = new System.Drawing.Point(225, 16);
            this.Adminlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Adminlabel.Name = "Adminlabel";
            this.Adminlabel.Size = new System.Drawing.Size(106, 37);
            this.Adminlabel.TabIndex = 51;
            this.Adminlabel.Text = "label1";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1288, 16);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(102, 48);
            this.exit.TabIndex = 21;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            // ur_dshbrd
            // 
            this.ur_dshbrd.AutoSize = true;
            this.ur_dshbrd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ur_dshbrd.Location = new System.Drawing.Point(584, 66);
            this.ur_dshbrd.Name = "ur_dshbrd";
            this.ur_dshbrd.Size = new System.Drawing.Size(204, 40);
            this.ur_dshbrd.TabIndex = 1;
            this.ur_dshbrd.Text = "UR Dashboard";
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
            this.panel2.Controls.Add(this.delet);
            this.panel2.Location = new System.Drawing.Point(10, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1404, 66);
            this.panel2.TabIndex = 22;
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(1090, 5);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(126, 56);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
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
            // dgvUrDs
            // 
            this.dgvUrDs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUrDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrDs.GridColor = System.Drawing.SystemColors.Control;
            this.dgvUrDs.Location = new System.Drawing.Point(12, 288);
            this.dgvUrDs.Name = "dgvUrDs";
            this.dgvUrDs.RowHeadersWidth = 82;
            this.dgvUrDs.RowTemplate.Height = 33;
            this.dgvUrDs.Size = new System.Drawing.Size(1404, 602);
            this.dgvUrDs.TabIndex = 23;
            this.dgvUrDs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrDs_CellContentClick);
            // 
            // search_by_nm
            // 
            this.search_by_nm.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_by_nm.Location = new System.Drawing.Point(122, 220);
            this.search_by_nm.Multiline = true;
            this.search_by_nm.Name = "search_by_nm";
            this.search_by_nm.Size = new System.Drawing.Size(415, 45);
            this.search_by_nm.TabIndex = 37;
            this.search_by_nm.TextChanged += new System.EventHandler(this.search_by_nm_TextChanged);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(16, 223);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(108, 37);
            this.search.TabIndex = 36;
            this.search.Text = "Search :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "( by Course Name )";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(832, 228);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(189, 37);
            this.ID.TabIndex = 40;
            this.ID.Text = "Course Code  :";
            // 
            // id_txtbox
            // 
            id_txtbox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_txtbox.Location = new System.Drawing.Point(1014, 223);
            id_txtbox.Multiline = true;
            id_txtbox.Name = "id_txtbox";
            id_txtbox.ReadOnly = true;
            id_txtbox.Size = new System.Drawing.Size(170, 45);
            id_txtbox.TabIndex = 41;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 914);
            this.Controls.Add(id_txtbox);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_by_nm);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dgvUrDs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ur_pnl);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ur_pnl.ResumeLayout(false);
            this.ur_pnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrDs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ur_pnl;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label ur_dshbrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.DataGridView dgvUrDs;
        private System.Windows.Forms.TextBox search_by_nm;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Label AdminIDlabel;
        private System.Windows.Forms.Label Adminlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID;
    }
}