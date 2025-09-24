namespace Study_Abroad_Management.UR
{
    partial class CourseDetailsControl
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.dgvCourseDetails = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.coursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseduration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ielts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutionfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxscolarship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationdeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studymode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFoundIndicator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(19, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "Enter course code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = ">> Course details";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCourseCode.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseCode.Location = new System.Drawing.Point(198, 86);
            this.txtCourseCode.Multiline = true;
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(233, 35);
            this.txtCourseCode.TabIndex = 21;
            this.txtCourseCode.TextChanged += new System.EventHandler(this.txtCourseCode_TextChanged);
            // 
            // dgvCourseDetails
            // 
            this.dgvCourseDetails.AllowUserToAddRows = false;
            this.dgvCourseDetails.AllowUserToDeleteRows = false;
            this.dgvCourseDetails.AllowUserToResizeRows = false;
            this.dgvCourseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coursename,
            this.coursecode,
            this.universityname,
            this.country,
            this.courseduration,
            this.degreetype,
            this.ielts,
            this.gre,
            this.sat,
            this.tutionfee,
            this.maxscolarship,
            this.intake,
            this.applicationdeadline,
            this.studymode,
            this.urid});
            this.dgvCourseDetails.Location = new System.Drawing.Point(23, 178);
            this.dgvCourseDetails.Name = "dgvCourseDetails";
            this.dgvCourseDetails.ReadOnly = true;
            this.dgvCourseDetails.RowHeadersVisible = false;
            this.dgvCourseDetails.RowHeadersWidth = 51;
            this.dgvCourseDetails.RowTemplate.Height = 24;
            this.dgvCourseDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseDetails.Size = new System.Drawing.Size(1718, 471);
            this.dgvCourseDetails.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(786, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 43);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(621, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 43);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(455, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 43);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // coursename
            // 
            this.coursename.DataPropertyName = "CourseName";
            this.coursename.HeaderText = "CourseName";
            this.coursename.MinimumWidth = 6;
            this.coursename.Name = "coursename";
            this.coursename.ReadOnly = true;
            this.coursename.Width = 80;
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
            // country
            // 
            this.country.DataPropertyName = "Country";
            this.country.HeaderText = "Country";
            this.country.MinimumWidth = 6;
            this.country.Name = "country";
            this.country.ReadOnly = true;
            this.country.Width = 125;
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
            // maxscolarship
            // 
            this.maxscolarship.DataPropertyName = "MaxScholarship";
            this.maxscolarship.HeaderText = "MaxScholarship";
            this.maxscolarship.MinimumWidth = 6;
            this.maxscolarship.Name = "maxscolarship";
            this.maxscolarship.ReadOnly = true;
            this.maxscolarship.Width = 125;
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
            // urid
            // 
            this.urid.DataPropertyName = "URID";
            this.urid.HeaderText = "URID";
            this.urid.MinimumWidth = 6;
            this.urid.Name = "urid";
            this.urid.ReadOnly = true;
            this.urid.Width = 125;
            // 
            // lblFoundIndicator
            // 
            this.lblFoundIndicator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFoundIndicator.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundIndicator.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFoundIndicator.Location = new System.Drawing.Point(544, 407);
            this.lblFoundIndicator.Name = "lblFoundIndicator";
            this.lblFoundIndicator.Size = new System.Drawing.Size(201, 33);
            this.lblFoundIndicator.TabIndex = 26;
            this.lblFoundIndicator.Text = "No Course Found";
            this.lblFoundIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.lblFoundIndicator);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvCourseDetails);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "CourseDetailsControl";
            this.Size = new System.Drawing.Size(1767, 682);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvCourseDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursename;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityname;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseduration;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn ielts;
        private System.Windows.Forms.DataGridViewTextBoxColumn gre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutionfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxscolarship;
        private System.Windows.Forms.DataGridViewTextBoxColumn intake;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationdeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn studymode;
        private System.Windows.Forms.DataGridViewTextBoxColumn urid;
        private System.Windows.Forms.Label lblFoundIndicator;
    }
}
