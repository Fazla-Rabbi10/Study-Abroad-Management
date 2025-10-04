namespace Study_Abroad_Management
{
    partial class Forget_Password
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
            this.Title = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.SetPass_label = new System.Windows.Forms.Label();
            this.en_ID_textBox = new System.Windows.Forms.TextBox();
            this.new_pass_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.Clear123button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(90, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(498, 50);
            this.Title.TabIndex = 27;
            this.Title.Text = "Abroad Higher Study Soltuin";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(95, 182);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(143, 22);
            this.IDlabel.TabIndex = 28;
            this.IDlabel.Text = "Enter Your ID :";
            // 
            // SetPass_label
            // 
            this.SetPass_label.AutoSize = true;
            this.SetPass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPass_label.Location = new System.Drawing.Point(48, 247);
            this.SetPass_label.Name = "SetPass_label";
            this.SetPass_label.Size = new System.Drawing.Size(190, 22);
            this.SetPass_label.TabIndex = 29;
            this.SetPass_label.Text = "Set New Password :";
            // 
            // en_ID_textBox
            // 
            this.en_ID_textBox.Location = new System.Drawing.Point(265, 182);
            this.en_ID_textBox.Name = "en_ID_textBox";
            this.en_ID_textBox.Size = new System.Drawing.Size(145, 22);
            this.en_ID_textBox.TabIndex = 0;
            // 
            // new_pass_textBox
            // 
            this.new_pass_textBox.Location = new System.Drawing.Point(265, 249);
            this.new_pass_textBox.Name = "new_pass_textBox";
            this.new_pass_textBox.Size = new System.Drawing.Size(145, 22);
            this.new_pass_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 64);
            this.label1.TabIndex = 32;
            this.label1.Text = "Note : If you also forget your ID,  please contact with us.\r\n  \r\nEmail: abroadhig" +
    "herstudy11@gmail.com \r\nPhone : +8801234567891";
            // 
            // Confirm_button
            // 
            this.Confirm_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Confirm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_button.ForeColor = System.Drawing.Color.White;
            this.Confirm_button.Location = new System.Drawing.Point(342, 329);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(110, 29);
            this.Confirm_button.TabIndex = 33;
            this.Confirm_button.Text = "Confirm";
            this.Confirm_button.UseVisualStyleBackColor = false;
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // Clear123button
            // 
            this.Clear123button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Clear123button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear123button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear123button.ForeColor = System.Drawing.Color.White;
            this.Clear123button.Location = new System.Drawing.Point(217, 329);
            this.Clear123button.Name = "Clear123button";
            this.Clear123button.Size = new System.Drawing.Size(110, 29);
            this.Clear123button.TabIndex = 34;
            this.Clear123button.Text = "Clear";
            this.Clear123button.UseVisualStyleBackColor = false;
            this.Clear123button.Click += new System.EventHandler(this.Clear123button_Click);
            // 
            // Forget_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 525);
            this.Controls.Add(this.Clear123button);
            this.Controls.Add(this.Confirm_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_pass_textBox);
            this.Controls.Add(this.en_ID_textBox);
            this.Controls.Add(this.SetPass_label);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.Title);
            this.Name = "Forget_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forget_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label SetPass_label;
        private System.Windows.Forms.TextBox en_ID_textBox;
        private System.Windows.Forms.TextBox new_pass_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Confirm_button;
        private System.Windows.Forms.Button Clear123button;
    }
}