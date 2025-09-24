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
            this.entercoursecodetxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.button1 = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // entercoursecodetxt
            // 
            this.entercoursecodetxt.Location = new System.Drawing.Point(198, 86);
            this.entercoursecodetxt.Multiline = true;
            this.entercoursecodetxt.Name = "entercoursecodetxt";
            this.entercoursecodetxt.Size = new System.Drawing.Size(233, 35);
            this.entercoursecodetxt.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1718, 421);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // coursename
            // 
            this.coursename.HeaderText = "CourseName";
            this.coursename.MinimumWidth = 6;
            this.coursename.Name = "coursename";
            this.coursename.Width = 80;
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
            // country
            // 
            this.country.HeaderText = "Country";
            this.country.MinimumWidth = 6;
            this.country.Name = "country";
            this.country.Width = 125;
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
            // maxscolarship
            // 
            this.maxscolarship.HeaderText = "MaxScholarship";
            this.maxscolarship.MinimumWidth = 6;
            this.maxscolarship.Name = "maxscolarship";
            this.maxscolarship.Width = 125;
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
            // urid
            // 
            this.urid.HeaderText = "URID";
            this.urid.MinimumWidth = 6;
            this.urid.Name = "urid";
            this.urid.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.BackgroundImage = global::Study_Abroad_Management.Properties.Resources.Delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(786, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 43);
            this.button1.TabIndex = 25;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.updatebtn.BackgroundImage = global::Study_Abroad_Management.Properties.Resources.Edit;
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updatebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatebtn.Location = new System.Drawing.Point(621, 80);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(137, 43);
            this.updatebtn.TabIndex = 23;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.searchbtn.BackgroundImage = global::Study_Abroad_Management.Properties.Resources.Search;
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(455, 80);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(137, 43);
            this.searchbtn.TabIndex = 22;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // CourseDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.entercoursecodetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "CourseDetailsControl";
            this.Size = new System.Drawing.Size(1767, 682);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entercoursecodetxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button button1;
    }
}
