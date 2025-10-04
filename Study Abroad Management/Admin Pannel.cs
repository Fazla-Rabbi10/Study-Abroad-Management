using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Abroad_Management
{
    public partial class Admin_Pannel : Form
    {
      //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-01OR5KU\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-JCQ2J3KL\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        public Admin_Pannel()
        {
            InitializeComponent();
        }

        private void Admin_Pannel_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.CenterToScreen();
            //this.WindowState = FormWindowState.Maximized;

            string adminName = GlobalData.LoggedInUserName;
            string adminID = GlobalData.LoggedInUserID.ToString();
            Adminlabel.Text = "Welcome, " + adminName;
            AdminIDlabel.Text = "ID: " + adminID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void usr_mng_Click(object sender, EventArgs e)
        {
            User_Management ur = new User_Management();
            ur.Show();
            this.Hide();
        }

        private void ur_mng_Click(object sender, EventArgs e)
        {
            UR_Management ur = new UR_Management();
            ur.Show();
            this.Hide();
        }

        private void admn_mng_Click(object sender, EventArgs e)
        {
            Admin_Management a1 = new Admin_Management();
            a1.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            //string connectionString = @"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;";

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (conn.State == ConnectionState.Open)
            {
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
            else
            {
                MessageBox.Show("Connection Failed");
                conn.Close();
            }
        }

        private void ur_dshbrd_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void AccessButton_Click(object sender, EventArgs e)
        {
            //if (conn.State != ConnectionState.Open)
           // {
               // conn.Open();
            //}
           // if (conn.State == ConnectionState.Open)
            //{
                Access_Management af = new Access_Management();
                af.Show();
                this.Hide();
           // }
           // else
            //{
                //MessageBox.Show("Connection Failed");
               // conn.Close();
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ad_logoutbutton_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open) 
            {
                conn.Open();
            }
            if (conn.State == ConnectionState.Open)
            {
                DialogResult dr = MessageBox.Show("Do you want to logout?", "Confirm Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    this.Hide();
                    Log_In_Form l = new Log_In_Form();
                    l.Show();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
                conn.Close();
            }
        }
    }
}
