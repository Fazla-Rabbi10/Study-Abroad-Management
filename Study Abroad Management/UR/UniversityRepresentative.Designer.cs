namespace Study_Abroad_Management.UR
{
    partial class UniversityRepresentative
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.applicationbtn = new System.Windows.Forms.Button();
            this.coursedetailsbtn = new System.Windows.Forms.Button();
            this.addnewcoursebtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblUserName);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(986, 75);
            this.pnlTop.TabIndex = 4;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(121, 17);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(309, 29);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome,";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(455, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABROAD HIGHER STUDY SOLUTION";
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.pnlSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSideBar.Controls.Add(this.logoutbtn);
            this.pnlSideBar.Controls.Add(this.applicationbtn);
            this.pnlSideBar.Controls.Add(this.coursedetailsbtn);
            this.pnlSideBar.Controls.Add(this.addnewcoursebtn);
            this.pnlSideBar.Controls.Add(this.homebtn);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 75);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(253, 568);
            this.pnlSideBar.TabIndex = 5;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.logoutbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.White;
            this.logoutbtn.Image = global::Study_Abroad_Management.Properties.Resources.Logout_Rounded;
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.Location = new System.Drawing.Point(-1, 308);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(253, 48);
            this.logoutbtn.TabIndex = 4;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // applicationbtn
            // 
            this.applicationbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.applicationbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationbtn.ForeColor = System.Drawing.Color.White;
            this.applicationbtn.Image = global::Study_Abroad_Management.Properties.Resources.CV;
            this.applicationbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.applicationbtn.Location = new System.Drawing.Point(-1, 239);
            this.applicationbtn.Name = "applicationbtn";
            this.applicationbtn.Size = new System.Drawing.Size(253, 48);
            this.applicationbtn.TabIndex = 3;
            this.applicationbtn.Text = "Application ";
            this.applicationbtn.UseVisualStyleBackColor = false;
            this.applicationbtn.Click += new System.EventHandler(this.applicationbtn_Click);
            // 
            // coursedetailsbtn
            // 
            this.coursedetailsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.coursedetailsbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursedetailsbtn.ForeColor = System.Drawing.Color.White;
            this.coursedetailsbtn.Image = global::Study_Abroad_Management.Properties.Resources.Show_Property;
            this.coursedetailsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coursedetailsbtn.Location = new System.Drawing.Point(-1, 173);
            this.coursedetailsbtn.Name = "coursedetailsbtn";
            this.coursedetailsbtn.Size = new System.Drawing.Size(253, 48);
            this.coursedetailsbtn.TabIndex = 2;
            this.coursedetailsbtn.Text = "Course Details";
            this.coursedetailsbtn.UseVisualStyleBackColor = false;
            this.coursedetailsbtn.Click += new System.EventHandler(this.coursedetailsbtn_Click);
            // 
            // addnewcoursebtn
            // 
            this.addnewcoursebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.addnewcoursebtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewcoursebtn.ForeColor = System.Drawing.Color.White;
            this.addnewcoursebtn.Image = global::Study_Abroad_Management.Properties.Resources.Add_properties;
            this.addnewcoursebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addnewcoursebtn.Location = new System.Drawing.Point(-1, 101);
            this.addnewcoursebtn.Name = "addnewcoursebtn";
            this.addnewcoursebtn.Size = new System.Drawing.Size(253, 48);
            this.addnewcoursebtn.TabIndex = 1;
            this.addnewcoursebtn.Text = "Add New Course";
            this.addnewcoursebtn.UseVisualStyleBackColor = false;
            this.addnewcoursebtn.Click += new System.EventHandler(this.addnewcoursebtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.homebtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.Image = global::Study_Abroad_Management.Properties.Resources.Home;
            this.homebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtn.Location = new System.Drawing.Point(-1, 33);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(253, 48);
            this.homebtn.TabIndex = 0;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Study_Abroad_Management.Properties.Resources.graduation_cap_with_globe_digital_art_style_education_day;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(253, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 568);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UniversityRepresentative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlTop);
            this.Name = "UniversityRepresentative";
            this.Text = "UniversityRepresentative";
            this.Load += new System.EventHandler(this.UniversityRepresentative_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button addnewcoursebtn;
        private System.Windows.Forms.Button coursedetailsbtn;
        private System.Windows.Forms.Button applicationbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Panel panel1;
    }
}