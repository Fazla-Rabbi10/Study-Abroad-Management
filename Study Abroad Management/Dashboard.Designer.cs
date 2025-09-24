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
            this.ur_pnl = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.ur_dshbrd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showButton = new System.Windows.Forms.Button();
            this.delet = new System.Windows.Forms.Button();
            this.dgvUrDs = new System.Windows.Forms.DataGridView();
            this.byCntry = new System.Windows.Forms.Label();
            this.search_by_nm = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.ur_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrDs)).BeginInit();
            this.SuspendLayout();
            // 
            // ur_pnl
            // 
            this.ur_pnl.Controls.Add(this.exit);
            this.ur_pnl.Controls.Add(this.back);
            this.ur_pnl.Controls.Add(this.ur_dshbrd);
            this.ur_pnl.Controls.Add(this.label1);
            this.ur_pnl.Location = new System.Drawing.Point(10, 12);
            this.ur_pnl.Name = "ur_pnl";
            this.ur_pnl.Size = new System.Drawing.Size(1406, 117);
            this.ur_pnl.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1288, 15);
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
            this.panel2.Location = new System.Drawing.Point(10, 135);
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
            // 
            // byCntry
            // 
            this.byCntry.AutoSize = true;
            this.byCntry.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byCntry.Location = new System.Drawing.Point(578, 223);
            this.byCntry.Name = "byCntry";
            this.byCntry.Size = new System.Drawing.Size(158, 37);
            this.byCntry.TabIndex = 38;
            this.byCntry.Text = "(by country)";
            // 
            // search_by_nm
            // 
            this.search_by_nm.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_by_nm.Location = new System.Drawing.Point(121, 220);
            this.search_by_nm.Multiline = true;
            this.search_by_nm.Name = "search_by_nm";
            this.search_by_nm.Size = new System.Drawing.Size(451, 45);
            this.search_by_nm.TabIndex = 37;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(17, 223);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(108, 37);
            this.search.TabIndex = 36;
            this.search.Text = "Search :";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 914);
            this.Controls.Add(this.byCntry);
            this.Controls.Add(this.search_by_nm);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dgvUrDs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ur_pnl);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
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
        private System.Windows.Forms.Label byCntry;
        private System.Windows.Forms.TextBox search_by_nm;
        private System.Windows.Forms.Label search;
    }
}