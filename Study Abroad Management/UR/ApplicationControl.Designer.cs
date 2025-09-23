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
            this.acceptbtn = new System.Windows.Forms.Button();
            this.rejectbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.appliocationstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseduration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appliocationstatus,
            this.coursename,
            this.coursecode,
            this.countru,
            this.courseduration,
            this.degreetype});
            this.dataGridView1.Location = new System.Drawing.Point(6, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(848, 443);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // acceptbtn
            // 
            this.acceptbtn.BackColor = System.Drawing.Color.Green;
            this.acceptbtn.BackgroundImage = global::Study_Abroad_Management.Properties.Resources.Search;
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
            // rejectbtn
            // 
            this.rejectbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rejectbtn.BackgroundImage = global::Study_Abroad_Management.Properties.Resources.Search;
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
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.Gray;
            this.refreshbtn.BackgroundImage = global::Study_Abroad_Management.Properties.Resources.Search;
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
            // ApplicationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.rejectbtn);
            this.Controls.Add(this.acceptbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ApplicationControl";
            this.Size = new System.Drawing.Size(881, 604);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn countru;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseduration;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreetype;
    }
}
