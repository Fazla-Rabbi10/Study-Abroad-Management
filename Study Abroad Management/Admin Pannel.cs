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
    }
}
