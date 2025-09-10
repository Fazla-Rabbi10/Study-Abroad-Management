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
    public partial class Admin_Pannel : Form
    {
        public Admin_Pannel()
        {
            InitializeComponent();
        }

        private void Admin_Pannel_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.CenterToScreen();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void application_mng_Click(object sender, EventArgs e)
        {
            Application_Management ap=new Application_Management();
            ap.Show();
            this.Hide();
        }

        private void usr_mng_Click(object sender, EventArgs e)
        {
            User_Management ur=new User_Management();
            ur.Show();
            this.Hide();
        }
    }
}
