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

    public partial class Dashboard : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;");
        public Dashboard()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin_Pannel ad = new Admin_Pannel();
            ad.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
           
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

        public void show()
        {          
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (conn.State == ConnectionState.Open)
            {

                string query = "SELECT*  FROM URDashboard";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUrDs.DataSource = dt;             
            }
            else
            {
                MessageBox.Show("Connection Failed");
                conn.Close();
            }
        }

        private void delet_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (id_txtbx.Text == "")
            //        MessageBox.Show("Please select a row first ");
            //    else
            //    {
            //        string connectionString = @"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;";
            //        SqlConnection conn = new SqlConnection(connectionString);
            //        conn.Open();

            //        string query = "delete from AdminDetails where ID='" + id_txtbx.Text + "'";
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.ExecuteNonQuery();

            //        //string query2 = "delete from loginTable where ID='" + id_txtbx.Text + "'";
            //        //SqlCommand cmd2 = new SqlCommand(query2, conn);
            //        //cmd2.ExecuteNonQuery();

            //        show();
            //        clear();

            //        conn.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
