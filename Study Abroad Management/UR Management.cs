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
    public partial class UR_Management : Form
    {
        public UR_Management()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin_Pannel a=new Admin_Pannel();
            a.Show();
            this.Hide();
        }


        public void clear()
        {
            id_txtbox.Text = "";
            email_txtbox.Text = "";
            status_txtbox.Text = "";
            name_txtbox.Text = "";
        }
        public void show()
        {
            string connectionString = @"//database connection";  //con string 
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM //_table_name"; // aikhane table name cng 
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dgvURmng.AutoGenerateColumns = true;
            dgvURmng.DataSource = dt;

        }


        private void dgvURmng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells[0].Value.ToString();
            email_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells[1].Value.ToString();
            status_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells[2].Value.ToString();
            name_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            show();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = @" //database ";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "update ____Table set Name='" + email_txtbox.Text + "', Email='" + status_txtbox.Text + "' where AdminID='" + id_txtbox.Text + "'"; //table name cng and column name cng 
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            show();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id_txtbox.Text == "")
                MessageBox.Show("Please select a row first ");
            else
            {
                string connectionString = @"//database";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "delete from //_table_name// where AdminID=" + id_txtbox.Text + ""; //cng tble name and column name 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                show();
                clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void status_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UR_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
