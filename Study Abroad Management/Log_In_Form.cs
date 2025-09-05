using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Abroad_Management
{
    public partial class Log_In_Form: Form
    {
        public Log_In_Form()
        {
            InitializeComponent();
        }

        private void Log_In_Form_Load(object sender, EventArgs e)
        {

        }

        private void Sign_Up_button_Click(object sender, EventArgs e)
        {
            this.Admin_button.Visible = true;
            this.UR_button.Visible = true;
            this.Student_button.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult drr = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            //con.Open();
           // if (con.State == ConnectionState.Open)
            //{
                if (drr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            //}
            //con.Close();
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            Admin_REG_Form arf = new Admin_REG_Form();
            arf.Show();
            this.Hide();
        }

        private void UR_button_Click(object sender, EventArgs e)
        {
            UR_REG_Formcs urf = new UR_REG_Formcs();
            urf.Show();
            this.Hide();
        }

        private void Student_button_Click(object sender, EventArgs e)
        {
            Studen_REG_Form srf = new Studen_REG_Form();
            srf.Show();
            this.Hide();
        }
    }
}
