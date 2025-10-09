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
            this.dgvApplicationStatus = new System.Windows.Forms.DataGridView();
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplicationStatus
            // 
            this.dgvApplicationStatus.AllowUserToAddRows = false;
            this.dgvApplicationStatus.AllowUserToDeleteRows = false;
            this.dgvApplicationStatus.AllowUserToResizeRows = false;
            this.dgvApplicationStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvApplicationStatus.Location = new System.Drawing.Point(18, 115);
            this.dgvApplicationStatus.Name = "dgvApplicationStatus";
            this.dgvApplicationStatus.ReadOnly = true;
            this.dgvApplicationStatus.RowHeadersVisible = false;
            this.dgvApplicationStatus.RowHeadersWidth = 51;
            this.dgvApplicationStatus.RowTemplate.Height = 24;
            this.dgvApplicationStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicationStatus.Size = new System.Drawing.Size(1706, 547);
            this.dgvApplicationStatus.TabIndex = 3;
            // 
            // appliocationstatus
            // 
            this.appliocationstatus.DataPropertyName = "ApplicationStatus";
            this.appliocationstatus.HeaderText = "ApplicationStatus";
            this.appliocationstatus.MinimumWidth = 6;
            this.appliocationstatus.Name = "appliocationstatus";
            this.appliocationstatus.ReadOnly = true;
            this.appliocationstatus.Width = 125;
            // 
            // coursename
            // 
            this.coursename.DataPropertyName = "CourseName";
            this.coursename.HeaderText = "CourseName";
            this.coursename.MinimumWidth = 6;
            this.coursename.Name = "coursename";
            this.coursename.ReadOnly = true;
            this.coursename.Width = 125;
            // 
            // coursecode
            // 
            this.coursecode.DataPropertyName = "CourseCode";
            this.coursecode.HeaderText = "CourseCode";
            this.coursecode.MinimumWidth = 6;
            this.coursecode.Name = "coursecode";
            this.coursecode.ReadOnly = true;
            this.coursecode.Width = 125;
            // 
            // universityname
            // 
            this.universityname.DataPropertyName = "UniversityName";
            this.universityname.HeaderText = "UniversityName";
            this.universityname.MinimumWidth = 6;
            this.universityname.Name = "universityname";
            this.universityname.ReadOnly = true;
            this.universityname.Width = 125;
            // 
            // countru
            // 
            this.countru.DataPropertyName = "Country";
            this.countru.HeaderText = "Country";
            this.countru.MinimumWidth = 6;
            this.countru.Name = "countru";
            this.countru.ReadOnly = true;
            this.countru.Width = 125;
            // 
            // courseduration
            // 
            this.courseduration.DataPropertyName = "CourseDuration";
            this.courseduration.HeaderText = "CourseDuration";
            this.courseduration.MinimumWidth = 6;
            this.courseduration.Name = "courseduration";
            this.courseduration.ReadOnly = true;
            this.courseduration.Width = 125;
            // 
            // degreetype
            // 
            this.degreetype.DataPropertyName = "DegreeType";
            this.degreetype.HeaderText = "DegreeType";
            this.degreetype.MinimumWidth = 6;
            this.degreetype.Name = "degreetype";
            this.degreetype.ReadOnly = true;
            this.degreetype.Width = 125;
            // 
            // ielts
            // 
            this.ielts.DataPropertyName = "IELTS";
            this.ielts.HeaderText = "IELTS";
            this.ielts.MinimumWidth = 6;
            this.ielts.Name = "ielts";
            this.ielts.ReadOnly = true;
            this.ielts.Width = 125;
            // 
            // gre
            // 
            this.gre.DataPropertyName = "GRE";
            this.gre.HeaderText = "GRE";
            this.gre.MinimumWidth = 6;
            this.gre.Name = "gre";
            this.gre.ReadOnly = true;
            this.gre.Width = 125;
            // 
            // sat
            // 
            this.sat.DataPropertyName = "SAT";
            this.sat.HeaderText = "SAT";
            this.sat.MinimumWidth = 6;
            this.sat.Name = "sat";
            this.sat.ReadOnly = true;
            this.sat.Width = 125;
            // 
            // tutionfee
            // 
            this.tutionfee.DataPropertyName = "TutionFee";
            this.tutionfee.HeaderText = "TutionFee";
            this.tutionfee.MinimumWidth = 6;
            this.tutionfee.Name = "tutionfee";
            this.tutionfee.ReadOnly = true;
            this.tutionfee.Width = 125;
            // 
            // maxscholarship
            // 
            this.maxscholarship.DataPropertyName = "MaxScholarship";
            this.maxscholarship.HeaderText = "MaxScholarship";
            this.maxscholarship.MinimumWidth = 6;
            this.maxscholarship.Name = "maxscholarship";
            this.maxscholarship.ReadOnly = true;
            this.maxscholarship.Width = 125;
            // 
            // intake
            // 
            this.intake.DataPropertyName = "Intake";
            this.intake.HeaderText = "Intake";
            this.intake.MinimumWidth = 6;
            this.intake.Name = "intake";
            this.intake.ReadOnly = true;
            this.intake.Width = 125;
            // 
            // applicationdeadline
            // 
            this.applicationdeadline.DataPropertyName = "ApplicationDeadline";
            this.applicationdeadline.HeaderText = "ApplicationDeadline";
            this.applicationdeadline.MinimumWidth = 6;
            this.applicationdeadline.Name = "applicationdeadline";
            this.applicationdeadline.ReadOnly = true;
            this.applicationdeadline.Width = 125;
            // 
            // studymode
            // 
            this.studymode.DataPropertyName = "StudyMode";
            this.studymode.HeaderText = "StudyMode";
            this.studymode.MinimumWidth = 6;
            this.studymode.Name = "studymode";
            this.studymode.ReadOnly = true;
            this.studymode.Width = 125;
            // 
            // studentid
            // 
            this.studentid.DataPropertyName = "StudentID";
            this.studentid.HeaderText = "StudentID";
            this.studentid.MinimumWidth = 6;
            this.studentid.Name = "studentid";
            this.studentid.ReadOnly = true;
            this.studentid.Width = 125;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(1583, 51);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 43);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReject.Location = new System.Drawing.Point(179, 51);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(137, 43);
            this.btnReject.TabIndex = 24;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Green;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(25, 51);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(137, 43);
            this.btnAccept.TabIndex = 23;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // ApplicationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dgvApplicationStatus);
            this.Name = "ApplicationControl";
            this.Size = new System.Drawing.Size(1749, 691);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvApplicationStatus;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnRefresh;
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
