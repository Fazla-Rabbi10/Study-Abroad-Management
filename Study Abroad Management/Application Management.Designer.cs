namespace Study_Abroad_Management
{
    partial class Application_Management
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.reject = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 135);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.accept);
            this.panel2.Controls.Add(this.reject);
            this.panel2.Location = new System.Drawing.Point(13, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1404, 85);
            this.panel2.TabIndex = 1;
            // 
            // reject
            // 
            this.reject.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reject.Location = new System.Drawing.Point(1244, 19);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(132, 51);
            this.reject.TabIndex = 0;
            this.reject.Text = "Reject";
            this.reject.UseVisualStyleBackColor = true;
            // 
            // accept
            // 
            this.accept.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.Location = new System.Drawing.Point(1075, 19);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(132, 51);
            this.accept.TabIndex = 1;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 48);
            this.back.TabIndex = 1;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Application Management";
            // 
            // Application_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1429, 914);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Application_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application_Management";
            this.Load += new System.EventHandler(this.Application_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button reject;
        private System.Windows.Forms.Label label2;
    }
}