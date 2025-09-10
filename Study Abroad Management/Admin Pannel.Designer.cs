namespace Study_Abroad_Management
{
    partial class Admin_Pannel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Pannel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_buttoncombo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.admn_mng = new System.Windows.Forms.Button();
            this.ur_mng = new System.Windows.Forms.Button();
            this.usr_mng = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.admin_buttoncombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1393, 194);
            this.panel1.TabIndex = 0;
            // 
            // admin_buttoncombo
            // 
            this.admin_buttoncombo.Controls.Add(this.usr_mng);
            this.admin_buttoncombo.Controls.Add(this.ur_mng);
            this.admin_buttoncombo.Controls.Add(this.admn_mng);
            this.admin_buttoncombo.Location = new System.Drawing.Point(68, 203);
            this.admin_buttoncombo.Name = "admin_buttoncombo";
            this.admin_buttoncombo.Size = new System.Drawing.Size(417, 669);
            this.admin_buttoncombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDY ABROAD MANAGEMENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Panel";
            // 
            // admn_mng
            // 
            this.admn_mng.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admn_mng.Location = new System.Drawing.Point(4, 28);
            this.admn_mng.Name = "admn_mng";
            this.admn_mng.Size = new System.Drawing.Size(410, 70);
            this.admn_mng.TabIndex = 0;
            this.admn_mng.Text = "Admin Management";
            this.admn_mng.UseVisualStyleBackColor = true;
            this.admn_mng.Click += new System.EventHandler(this.admn_mng_Click);
            // 
            // ur_mng
            // 
            this.ur_mng.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ur_mng.Location = new System.Drawing.Point(7, 137);
            this.ur_mng.Name = "ur_mng";
            this.ur_mng.Size = new System.Drawing.Size(410, 70);
            this.ur_mng.TabIndex = 1;
            this.ur_mng.Text = "UR Management";
            this.ur_mng.UseVisualStyleBackColor = true;
            this.ur_mng.Click += new System.EventHandler(this.ur_mng_Click);
            // 
            // usr_mng
            // 
            this.usr_mng.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_mng.Location = new System.Drawing.Point(7, 239);
            this.usr_mng.Name = "usr_mng";
            this.usr_mng.Size = new System.Drawing.Size(410, 70);
            this.usr_mng.TabIndex = 2;
            this.usr_mng.Text = "User Management";
            this.usr_mng.UseVisualStyleBackColor = true;
            this.usr_mng.Click += new System.EventHandler(this.usr_mng_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(636, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_Pannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1429, 914);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admin_buttoncombo);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Pannel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Pannel";
            this.Load += new System.EventHandler(this.Admin_Pannel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.admin_buttoncombo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel admin_buttoncombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button usr_mng;
        private System.Windows.Forms.Button ur_mng;
        private System.Windows.Forms.Button admn_mng;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}