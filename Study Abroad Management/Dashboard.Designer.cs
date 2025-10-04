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
            this.ur_pnl.Controls.Add(this.AdminIDlabel);
            this.ur_pnl.Controls.Add(this.Adminlabel);
            this.ur_pnl.Controls.Add(this.exit);
            this.ur_pnl.Controls.Add(this.back);
            this.ur_pnl.Controls.Add(this.ur_dshbrd);
            this.ur_pnl.Controls.Add(this.label1);
            this.ur_pnl.Location = new System.Drawing.Point(7, 8);
            this.ur_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.ur_pnl.Name = "ur_pnl";
            this.ur_pnl.Size = new System.Drawing.Size(937, 75);
            this.ur_pnl.TabIndex = 1;
            // 
            // AdminIDlabel
            // 
            this.AdminIDlabel.AutoSize = true;
            this.AdminIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIDlabel.Location = new System.Drawing.Point(645, 10);
            this.AdminIDlabel.Name = "AdminIDlabel";
            this.AdminIDlabel.Size = new System.Drawing.Size(70, 25);
            this.AdminIDlabel.TabIndex = 52;
            this.AdminIDlabel.Text = "label2";
            // 
            // Adminlabel
            // 
            this.Adminlabel.AutoSize = true;
            this.Adminlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminlabel.Location = new System.Drawing.Point(150, 10);
            this.Adminlabel.Name = "Adminlabel";
            this.Adminlabel.Size = new System.Drawing.Size(70, 25);
            this.Adminlabel.TabIndex = 51;
            this.Adminlabel.Text = "label1";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(859, 10);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(68, 31);
            this.exit.TabIndex = 21;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(11, 7);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(68, 33);
            this.back.TabIndex = 3;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ur_dshbrd
            // 
            this.ur_dshbrd.AutoSize = true;
            this.ur_dshbrd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ur_dshbrd.Location = new System.Drawing.Point(389, 42);
            this.ur_dshbrd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ur_dshbrd.Name = "ur_dshbrd";
            this.ur_dshbrd.Size = new System.Drawing.Size(137, 25);
            this.ur_dshbrd.TabIndex = 1;
            this.ur_dshbrd.Text = "UR Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showButton);
            this.panel2.Controls.Add(this.delet);
            this.panel2.Location = new System.Drawing.Point(7, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 42);
            this.panel2.TabIndex = 22;
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(727, 3);
            this.showButton.Margin = new System.Windows.Forms.Padding(2);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(84, 36);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // delet
            // 
            this.delet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delet.Location = new System.Drawing.Point(826, 4);
            this.delet.Margin = new System.Windows.Forms.Padding(2);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(84, 36);
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
            this.dgvUrDs.Location = new System.Drawing.Point(8, 184);
            this.dgvUrDs.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUrDs.Name = "dgvUrDs";
            this.dgvUrDs.RowHeadersWidth = 82;
            this.dgvUrDs.RowTemplate.Height = 33;
            this.dgvUrDs.Size = new System.Drawing.Size(936, 385);
            this.dgvUrDs.TabIndex = 23;
            // 
            // byCntry
            // 
            this.byCntry.AutoSize = true;
            this.byCntry.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byCntry.Location = new System.Drawing.Point(385, 143);
            this.byCntry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.byCntry.Name = "byCntry";
            this.byCntry.Size = new System.Drawing.Size(101, 23);
            this.byCntry.TabIndex = 38;
            this.byCntry.Text = "(by country)";
            // 
            // search_by_nm
            // 
            this.search_by_nm.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_by_nm.Location = new System.Drawing.Point(81, 141);
            this.search_by_nm.Margin = new System.Windows.Forms.Padding(2);
            this.search_by_nm.Multiline = true;
            this.search_by_nm.Name = "search_by_nm";
            this.search_by_nm.Size = new System.Drawing.Size(302, 30);
            this.search_by_nm.TabIndex = 37;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(11, 143);
            this.search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(70, 23);
            this.search.TabIndex = 36;
            this.search.Text = "Search :";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 585);
            this.Controls.Add(this.byCntry);
            this.Controls.Add(this.search_by_nm);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dgvUrDs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ur_pnl);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label byCntry;
        private System.Windows.Forms.TextBox search_by_nm;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Label AdminIDlabel;
        private System.Windows.Forms.Label Adminlabel;
    }
}