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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Normal )
                this.CenterToScreen();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //    this.CenterToScreen();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void signup_button_Click(object sender, EventArgs e)
        //{

        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{

        //}

        //private void username_Click(object sender, EventArgs e)
        //{

        //}


    }
}
