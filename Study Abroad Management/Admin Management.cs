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
    public partial class Admin_Management : Form
    {
        public Admin_Management()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        private void back_Click(object sender, EventArgs e)
        {
            Admin_Pannel ad=new Admin_Pannel();
            ad.Show();
            this.Hide();
        }

        private void AddAdminbutton_Click(object sender, EventArgs e)
        {
            Admin_REG_Form arf = new Admin_REG_Form();
            arf.Show();
            this.Hide();
        }
        public void clear()
        {
            id_txtbx.Text = "";
            addrs_txtbx.Text = "";
            nm_txtbx.Text = "";
            email_txtbx.Text = "";
            cntry.Text = "";
            contact_txtbx.Text="";
        }
        public void show()
        {           
                 string connectionString = @"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;";  //con string 
                 SqlConnection conn = new SqlConnection(connectionString);
                 conn.Open();
                 // string query = "SELECT * FROM AdminDetails";
                 string query = "SELECT ID,Name,Address,Email,Country,Gender,ContactNumber FROM AdminDetails";
                 SqlCommand cmd = new SqlCommand(query, conn);
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataSet ds = new DataSet();
                 da.Fill(ds);
                 DataTable dt = ds.Tables[0];
                 dgvAdmTbl.AutoGenerateColumns = true;
                 dgvAdmTbl.DataSource = dt;
             
            
        }
        private void dgvAdmTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells[0].Value.ToString();

            nm_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells[1].Value.ToString();
            addrs_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells[2].Value.ToString();         
            email_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells[3].Value.ToString();
            cntry.Text = dgvAdmTbl.Rows[e.RowIndex].Cells[4].Value.ToString();
            contact_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells[6].Value.ToString();
           
        }
        private void id_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Management_Load(object sender, EventArgs e)
        {

        }

        //private void dgvAdmTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void stts_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void showButton_Click_1(object sender, EventArgs e)
        {
            try { 
                show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            //show();
            // dgvAdmTbl.Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
           try 
            { 
                 string connectionString = @"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;";
                 SqlConnection conn = new SqlConnection(connectionString);
                 conn.Open();

                 string query = "update AdminDetails set Name='" + nm_txtbx.Text + "',Address ='" + addrs_txtbx.Text + "', Email='" + email_txtbx.Text + "', ContactNumber='" + contact_txtbx.Text + "',Country ='" + cntry.Text + "' where ID='" + id_txtbx.Text + "'"; 
                 SqlCommand cmd = new SqlCommand(query, conn);
                 cmd.ExecuteNonQuery();

                //string query2 = "delete from loginTable where ID='" + id_txtbx.Text + "'";
                //SqlCommand cmd2 = new SqlCommand(query2, conn);
                //cmd2.ExecuteNonQuery();

                show();
                clear();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void delet_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_txtbx.Text == "")
                    MessageBox.Show("Please select a row first ");
                else
                {
                    string connectionString = @"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;";
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();

                    string query = "delete from AdminDetails where ID='" + id_txtbx.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();                  

                    //string query2 = "delete from loginTable where ID='" + id_txtbx.Text + "'";
                    //SqlCommand cmd2 = new SqlCommand(query2, conn);
                    //cmd2.ExecuteNonQuery();

                    show();
                    clear();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void email_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void sttus_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void contact_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            string connectionString = @"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
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
    }
}
