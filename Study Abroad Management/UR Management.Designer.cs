namespace Study_Abroad_Management
{
    partial class UR_Management
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nty = new System.Windows.Forms.Label();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.nty_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.unm = new System.Windows.Forms.Label();
            this.unm_txtbx = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.eiin = new System.Windows.Forms.Label();
            this.dgvURmng = new System.Windows.Forms.DataGridView();
            this.eiin_txtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvURmng)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 148);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "University Re-presentative Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Panel";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 48);
            this.back.TabIndex = 1;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1102, 156);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 51);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1263, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 51);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(946, 156);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(132, 51);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(35, 247);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(91, 37);
            this.ID.TabIndex = 8;
            this.ID.Text = "ID      :";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // nty
            // 
            this.nty.AutoSize = true;
            this.nty.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nty.Location = new System.Drawing.Point(886, 253);
            this.nty.Name = "nty";
            this.nty.Size = new System.Drawing.Size(161, 37);
            this.nty.TabIndex = 12;
            this.nty.Text = "Nationality :";
            this.nty.Click += new System.EventHandler(this.label4_Click);
            // 
            // id_txtbox
            // 
            this.id_txtbox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txtbox.Location = new System.Drawing.Point(132, 245);
            this.id_txtbox.Multiline = true;
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(156, 45);
            this.id_txtbox.TabIndex = 13;
            this.id_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email_txtbox
            // 
            this.email_txtbox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txtbox.Location = new System.Drawing.Point(132, 299);
            this.email_txtbox.Multiline = true;
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(387, 45);
            this.email_txtbox.TabIndex = 14;
            this.email_txtbox.TextChanged += new System.EventHandler(this.email_txtbox_TextChanged);
            // 
            // nty_txtbox
            // 
            this.nty_txtbox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nty_txtbox.Location = new System.Drawing.Point(1053, 250);
            this.nty_txtbox.Multiline = true;
            this.nty_txtbox.Name = "nty_txtbox";
            this.nty_txtbox.Size = new System.Drawing.Size(342, 46);
            this.nty_txtbox.TabIndex = 15;
            this.nty_txtbox.TextChanged += new System.EventHandler(this.status_txtbox_TextChanged);
            // 
            // name_txtbox
            // 
            this.name_txtbox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtbox.Location = new System.Drawing.Point(415, 245);
            this.name_txtbox.Multiline = true;
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(455, 45);
            this.name_txtbox.TabIndex = 16;
            this.name_txtbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // unm
            // 
            this.unm.AutoSize = true;
            this.unm.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unm.Location = new System.Drawing.Point(525, 302);
            this.unm.Name = "unm";
            this.unm.Size = new System.Drawing.Size(225, 37);
            this.unm.TabIndex = 17;
            this.unm.Text = "University Name :";
            this.unm.Click += new System.EventHandler(this.contact_Click);
            // 
            // unm_txtbx
            // 
            this.unm_txtbx.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unm_txtbx.Location = new System.Drawing.Point(756, 299);
            this.unm_txtbx.Multiline = true;
            this.unm_txtbx.Name = "unm_txtbx";
            this.unm_txtbx.Size = new System.Drawing.Size(436, 42);
            this.unm_txtbx.TabIndex = 18;
            this.unm_txtbx.TextChanged += new System.EventHandler(this.contact_txtbx_TextChanged);
            // 
            // eiin
            // 
            this.eiin.AutoSize = true;
            this.eiin.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eiin.Location = new System.Drawing.Point(1198, 302);
            this.eiin.Name = "eiin";
            this.eiin.Size = new System.Drawing.Size(78, 37);
            this.eiin.TabIndex = 19;
            this.eiin.Text = "EIIN :";
            this.eiin.Click += new System.EventHandler(this.eiin_Click);
            // 
            // dgvURmng
            // 
            this.dgvURmng.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvURmng.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvURmng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvURmng.Location = new System.Drawing.Point(24, 360);
            this.dgvURmng.Name = "dgvURmng";
            this.dgvURmng.RowHeadersWidth = 82;
            this.dgvURmng.RowTemplate.Height = 33;
            this.dgvURmng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvURmng.Size = new System.Drawing.Size(1371, 550);
            this.dgvURmng.TabIndex = 7;
            this.dgvURmng.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvURmng_CellContentClick);
            // 
            // eiin_txtbox
            // 
            this.eiin_txtbox.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eiin_txtbox.Location = new System.Drawing.Point(1282, 296);
            this.eiin_txtbox.Multiline = true;
            this.eiin_txtbox.Name = "eiin_txtbox";
            this.eiin_txtbox.Size = new System.Drawing.Size(117, 45);
            this.eiin_txtbox.TabIndex = 20;
            this.eiin_txtbox.TextChanged += new System.EventHandler(this.eiin_txtbox_TextChanged);
            // 
            // UR_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1429, 942);
            this.Controls.Add(this.eiin_txtbox);
            this.Controls.Add(this.eiin);
            this.Controls.Add(this.unm_txtbx);
            this.Controls.Add(this.unm);
            this.Controls.Add(this.dgvURmng);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.nty_txtbox);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.nty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Name = "UR_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UR_Management";
            this.Load += new System.EventHandler(this.UR_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvURmng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nty;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.TextBox nty_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label unm;
        private System.Windows.Forms.TextBox unm_txtbx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label eiin;
        private System.Windows.Forms.DataGridView dgvURmng;
        private System.Windows.Forms.TextBox eiin_txtbox;
    }
}