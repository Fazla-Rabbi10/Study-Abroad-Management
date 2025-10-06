namespace Study_Abroad_Management
{
    partial class Student_Application_Status
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
            this.apply_status_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.aspp_StudentIDlabel = new System.Windows.Forms.Label();
            this.app_Student_namelabel = new System.Windows.Forms.Label();
            this.Closebutton2 = new System.Windows.Forms.Button();
            this.refreshbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apply_status_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // apply_status_dataGridView
            // 
            this.apply_status_dataGridView.AllowUserToAddRows = false;
            this.apply_status_dataGridView.AllowUserToDeleteRows = false;
            this.apply_status_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apply_status_dataGridView.Location = new System.Drawing.Point(0, 106);
            this.apply_status_dataGridView.Name = "apply_status_dataGridView";
            this.apply_status_dataGridView.ReadOnly = true;
            this.apply_status_dataGridView.RowHeadersWidth = 51;
            this.apply_status_dataGridView.RowTemplate.Height = 24;
            this.apply_status_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apply_status_dataGridView.Size = new System.Drawing.Size(1152, 579);
            this.apply_status_dataGridView.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 46);
            this.label1.TabIndex = 60;
            this.label1.Text = "Abroad Higher Study Solution";
            // 
            // aspp_StudentIDlabel
            // 
            this.aspp_StudentIDlabel.AutoSize = true;
            this.aspp_StudentIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspp_StudentIDlabel.Location = new System.Drawing.Point(954, 3);
            this.aspp_StudentIDlabel.Name = "aspp_StudentIDlabel";
            this.aspp_StudentIDlabel.Size = new System.Drawing.Size(70, 25);
            this.aspp_StudentIDlabel.TabIndex = 59;
            this.aspp_StudentIDlabel.Text = "label2";
            // 
            // app_Student_namelabel
            // 
            this.app_Student_namelabel.AutoSize = true;
            this.app_Student_namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_Student_namelabel.Location = new System.Drawing.Point(123, 3);
            this.app_Student_namelabel.Name = "app_Student_namelabel";
            this.app_Student_namelabel.Size = new System.Drawing.Size(70, 25);
            this.app_Student_namelabel.TabIndex = 58;
            this.app_Student_namelabel.Text = "label1";
            // 
            // Closebutton2
            // 
            this.Closebutton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Closebutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Closebutton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Closebutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebutton2.Location = new System.Drawing.Point(0, 3);
            this.Closebutton2.Name = "Closebutton2";
            this.Closebutton2.Size = new System.Drawing.Size(79, 27);
            this.Closebutton2.TabIndex = 68;
            this.Closebutton2.Text = "Close";
            this.Closebutton2.UseVisualStyleBackColor = false;
            this.Closebutton2.Click += new System.EventHandler(this.Closebutton2_Click);
            // 
            // refreshbutton1
            // 
            this.refreshbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbutton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshbutton1.Location = new System.Drawing.Point(979, 57);
            this.refreshbutton1.Name = "refreshbutton1";
            this.refreshbutton1.Size = new System.Drawing.Size(108, 29);
            this.refreshbutton1.TabIndex = 69;
            this.refreshbutton1.Text = "Refresh";
            this.refreshbutton1.UseVisualStyleBackColor = false;
            this.refreshbutton1.Click += new System.EventHandler(this.refreshbutton1_Click);
            // 
            // Student_Application_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 726);
            this.Controls.Add(this.refreshbutton1);
            this.Controls.Add(this.Closebutton2);
            this.Controls.Add(this.apply_status_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aspp_StudentIDlabel);
            this.Controls.Add(this.app_Student_namelabel);
            this.MaximizeBox = false;
            this.Name = "Student_Application_Status";
            this.Text = "Student_Application_Status";
            this.Load += new System.EventHandler(this.Student_Application_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apply_status_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView apply_status_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aspp_StudentIDlabel;
        private System.Windows.Forms.Label app_Student_namelabel;
        private System.Windows.Forms.Button Closebutton2;
        private System.Windows.Forms.Button refreshbutton1;
    }
}