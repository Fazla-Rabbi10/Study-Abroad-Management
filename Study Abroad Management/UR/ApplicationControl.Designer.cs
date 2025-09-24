namespace Study_Abroad_Management.UR
{
    partial class ApplicationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appliocationstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseduration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ielts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutionfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxscholarship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationdeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studymode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.rejectbtn = new System.Windows.Forms.Button();
            this.acceptbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appliocationstatus,
            this.coursename,
            this.coursecode,
            this.universityname,
            this.countru,
            this.courseduration,
            this.degreetype,
            this.ielts,
            this.gre,
            this.sat,
            this.tutionfee,
            this.maxscholarship,
            this.intake,
            this.applicationdeadline,
            this.studymode,
            this.studentid});
            this.dataGridView1.Location = new System.Drawing.Point(6, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1678, 428);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // appliocationstatus
            // 
            this.appliocationstatus.HeaderText = "ApplicationStatus";
            this.appliocationstatus.MinimumWidth = 6;
            this.appliocationstatus.Name = "appliocationstatus";
            this.appliocationstatus.Width = 125;
            // 
            // coursename
            // 
            this.coursename.HeaderText = "CourseName";
            this.coursename.MinimumWidth = 6;
            this.coursename.Name = "coursename";
            this.coursename.Width = 125;
            // 
            // coursecode
            // 
            this.coursecode.HeaderText = "CourseCode";
            this.coursecode.MinimumWidth = 6;
            this.coursecode.Name = "coursecode";
            this.coursecode.Width = 125;
            // 
            // universityname
            // 
            this.universityname.HeaderText = "UniversityName";
            this.universityname.MinimumWidth = 6;
            this.universityname.Name = "universityname";
            this.universityname.Width = 125;
            // 
            // countru
            // 
            this.countru.HeaderText = "Country";
            this.countru.MinimumWidth = 6;
            this.countru.Name = "countru";
            this.countru.Width = 125;
            // 
            // courseduration
            // 
            this.courseduration.HeaderText = "CourseDuration";
            this.courseduration.MinimumWidth = 6;
            this.courseduration.Name = "courseduration";
            this.courseduration.Width = 125;
            // 
            // degreetype
            // 
            this.degreetype.HeaderText = "DegreeType";
            this.degreetype.MinimumWidth = 6;
            this.degreetype.Name = "degreetype";
            this.degreetype.Width = 125;
            // 
            // ielts
            // 
            this.ielts.HeaderText = "IELTS";
            this.ielts.MinimumWidth = 6;
            this.ielts.Name = "ielts";
            this.ielts.Width = 125;
            // 
            // gre
            // 
            this.gre.HeaderText = "GRE";
            this.gre.MinimumWidth = 6;
            this.gre.Name = "gre";
            this.gre.Width = 125;
            // 
            // sat
            // 
            this.sat.HeaderText = "SAT";
            this.sat.MinimumWidth = 6;
            this.sat.Name = "sat";
            this.sat.Width = 125;
            // 
            // tutionfee
            // 
            this.tutionfee.HeaderText = "TutionFee";
            this.tutionfee.MinimumWidth = 6;
            this.tutionfee.Name = "tutionfee";
            this.tutionfee.Width = 125;
            // 
            // maxscholarship
            // 
            this.maxscholarship.HeaderText = "MaxScholarship";
            this.maxscholarship.MinimumWidth = 6;
            this.maxscholarship.Name = "maxscholarship";
            this.maxscholarship.Width = 125;
            // 
            // intake
            // 
            this.intake.HeaderText = "Intake";
            this.intake.MinimumWidth = 6;
            this.intake.Name = "intake";
            this.intake.Width = 125;
            // 
            // applicationdeadline
            // 
            this.applicationdeadline.HeaderText = "ApplicationDeadline";
            this.applicationdeadline.MinimumWidth = 6;
            this.applicationdeadline.Name = "applicationdeadline";
            this.applicationdeadline.Width = 125;
            // 
            // studymode
            // 
            this.studymode.HeaderText = "StudyMode";
            this.studymode.MinimumWidth = 6;
            this.studymode.Name = "studymode";
            this.studymode.Width = 125;
            // 
            // studentid
            // 
            this.studentid.HeaderText = "StudentID";
            this.studentid.MinimumWidth = 6;
            this.studentid.Name = "studentid";
            this.studentid.Width = 125;
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.Gray;
            this.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshbtn.Location = new System.Drawing.Point(316, 48);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(137, 43);
            this.refreshbtn.TabIndex = 25;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            // 
            // rejectbtn
            // 
            this.rejectbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rejectbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rejectbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.rejectbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rejectbtn.Location = new System.Drawing.Point(160, 48);
            this.rejectbtn.Name = "rejectbtn";
            this.rejectbtn.Size = new System.Drawing.Size(137, 43);
            this.rejectbtn.TabIndex = 24;
            this.rejectbtn.Text = "Reject";
            this.rejectbtn.UseVisualStyleBackColor = false;
            // 
            // acceptbtn
            // 
            this.acceptbtn.BackColor = System.Drawing.Color.Green;
            this.acceptbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.acceptbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.acceptbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acceptbtn.Location = new System.Drawing.Point(6, 48);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(137, 43);
            this.acceptbtn.TabIndex = 23;
            this.acceptbtn.Text = "Accept";
            this.acceptbtn.UseVisualStyleBackColor = false;
            // 
            // ApplicationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.rejectbtn);
            this.Controls.Add(this.acceptbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ApplicationControl";
            this.Size = new System.Drawing.Size(1749, 691);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.Button rejectbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appliocationstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursename;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityname;
        private System.Windows.Forms.DataGridViewTextBoxColumn countru;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseduration;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn ielts;
        private System.Windows.Forms.DataGridViewTextBoxColumn gre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutionfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxscholarship;
        private System.Windows.Forms.DataGridViewTextBoxColumn intake;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationdeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn studymode;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentid;
    }
}
