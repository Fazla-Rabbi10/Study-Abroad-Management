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
        }
        public void show()
        {
            string connectionString = @"//database connection";  //con string 
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM [dbo].[AdminDetails]"; //  table name cng 
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
            addrs_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells[0].Value.ToString();
            nm_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells[1].Value.ToString();
            contact_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells[5].Value.ToString();
            email_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells[2].Value.ToString();
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
            show();
           // dgvAdmTbl.Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connectionString = @" //database ";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "update [dbo].[AdminDetails] set Name='" + nm_txtbx.Text + "',Status ='" + addrs_txtbx.Text + "', Email='" + email_txtbx.Text + "', ContactNumber='" + contact_txtbx.Text + "' where AdminID='" + id_txtbx.Text + "'"; //table name cng and column name cng 
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            show();
            clear();
        }

        private void delet_Click(object sender, EventArgs e)
        {
            if (id_txtbx.Text == "")
                MessageBox.Show("Please select a row first ");
            else
            {
                string connectionString = @"//database";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "delete from [dbo].[AdminDetails] where AdminID=" + id_txtbx.Text + ""; //cng tble name and column name 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                show();
                clear();
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

       
    }
}
