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
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_buttoncombo = new System.Windows.Forms.Panel();
            this.ur_dshbrd = new System.Windows.Forms.Button();
            this.usr_mng = new System.Windows.Forms.Button();
            this.ur_mng = new System.Windows.Forms.Button();
            this.admn_mng = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Adminlabel = new System.Windows.Forms.Label();
            this.AdminIDlabel = new System.Windows.Forms.Label();
            this.AccessButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.admin_buttoncombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.AdminIDlabel);
            this.panel1.Controls.Add(this.Adminlabel);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 124);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(850, 12);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(68, 31);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Panel";
            // 
            // admin_buttoncombo
            // 
            this.admin_buttoncombo.Controls.Add(this.AccessButton);
            this.admin_buttoncombo.Controls.Add(this.ur_dshbrd);
            this.admin_buttoncombo.Controls.Add(this.usr_mng);
            this.admin_buttoncombo.Controls.Add(this.ur_mng);
            this.admin_buttoncombo.Controls.Add(this.admn_mng);
            this.admin_buttoncombo.Location = new System.Drawing.Point(45, 130);
            this.admin_buttoncombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin_buttoncombo.Name = "admin_buttoncombo";
            this.admin_buttoncombo.Size = new System.Drawing.Size(278, 428);
            this.admin_buttoncombo.TabIndex = 1;
            // 
            // ur_dshbrd
            // 
            this.ur_dshbrd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ur_dshbrd.Location = new System.Drawing.Point(5, 218);
            this.ur_dshbrd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ur_dshbrd.Name = "ur_dshbrd";
            this.ur_dshbrd.Size = new System.Drawing.Size(273, 45);
            this.ur_dshbrd.TabIndex = 3;
            this.ur_dshbrd.Text = "UR Dashboard";
            this.ur_dshbrd.UseVisualStyleBackColor = true;
            this.ur_dshbrd.Click += new System.EventHandler(this.ur_dshbrd_Click);
            // 
            // usr_mng
            // 
            this.usr_mng.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_mng.Location = new System.Drawing.Point(5, 153);
            this.usr_mng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usr_mng.Name = "usr_mng";
            this.usr_mng.Size = new System.Drawing.Size(273, 45);
            this.usr_mng.TabIndex = 2;
            this.usr_mng.Text = "User Management";
            this.usr_mng.UseVisualStyleBackColor = true;
            this.usr_mng.Click += new System.EventHandler(this.usr_mng_Click);
            // 
            // ur_mng
            // 
            this.ur_mng.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ur_mng.Location = new System.Drawing.Point(5, 88);
            this.ur_mng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ur_mng.Name = "ur_mng";
            this.ur_mng.Size = new System.Drawing.Size(273, 45);
            this.ur_mng.TabIndex = 1;
            this.ur_mng.Text = "UR Management";
            this.ur_mng.UseVisualStyleBackColor = true;
            this.ur_mng.Click += new System.EventHandler(this.ur_mng_Click);
            // 
            // admn_mng
            // 
            this.admn_mng.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admn_mng.Location = new System.Drawing.Point(3, 18);
            this.admn_mng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admn_mng.Name = "admn_mng";
            this.admn_mng.Size = new System.Drawing.Size(273, 45);
            this.admn_mng.TabIndex = 0;
            this.admn_mng.Text = "Admin Management";
            this.admn_mng.UseVisualStyleBackColor = true;
            this.admn_mng.Click += new System.EventHandler(this.admn_mng_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(424, 158);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Adminlabel
            // 
            this.Adminlabel.AutoSize = true;
            this.Adminlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminlabel.Location = new System.Drawing.Point(15, 7);
            this.Adminlabel.Name = "Adminlabel";
            this.Adminlabel.Size = new System.Drawing.Size(70, 25);
            this.Adminlabel.TabIndex = 49;
            this.Adminlabel.Text = "label1";
            // 
            // AdminIDlabel
            // 
            this.AdminIDlabel.AutoSize = true;
            this.AdminIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIDlabel.Location = new System.Drawing.Point(15, 44);
            this.AdminIDlabel.Name = "AdminIDlabel";
            this.AdminIDlabel.Size = new System.Drawing.Size(70, 25);
            this.AdminIDlabel.TabIndex = 50;
            this.AdminIDlabel.Text = "label2";
            // 
            // AccessButton
            // 
            this.AccessButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessButton.Location = new System.Drawing.Point(3, 292);
            this.AccessButton.Margin = new System.Windows.Forms.Padding(2);
            this.AccessButton.Name = "AccessButton";
            this.AccessButton.Size = new System.Drawing.Size(273, 45);
            this.AccessButton.TabIndex = 4;
            this.AccessButton.Text = "Manage Access";
            this.AccessButton.UseVisualStyleBackColor = true;
            this.AccessButton.Click += new System.EventHandler(this.AccessButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(247, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(498, 50);
            this.Title.TabIndex = 51;
            this.Title.Text = "Abroad Higher Study Soltuin";
            // 
            // Admin_Pannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admin_buttoncombo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Panel admin_buttoncombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button usr_mng;
        private System.Windows.Forms.Button ur_mng;
        private System.Windows.Forms.Button admn_mng;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button ur_dshbrd;
        private System.Windows.Forms.Label Adminlabel;
        private System.Windows.Forms.Label AdminIDlabel;
        private System.Windows.Forms.Button AccessButton;
        private System.Windows.Forms.Label Title;
    }
}