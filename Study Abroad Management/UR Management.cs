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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        public void show()
        {
            string connectionString = @"Data Source=DESKTOP-2VG5BCS\SQLEXPRESS;Initial Catalog=pracAdmin;Integrated Security=True;";  //con string dibi
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM AdminTable"; // aikhane table name dibi
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
            textBox1.Text = dgvURmng.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dgvURmng.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dgvURmng.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dgvURmng.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            show();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-2VG5BCS\SQLEXPRESS;Initial Catalog=pracAdmin;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "update AdminTable set Name='" + textBox2.Text + "', Email='" + textBox3.Text + "' where AdminID='" + textBox1.Text + "'"; //table name cng and column name cng 
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            show();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Please select a row first ");
            else
            {
                string connectionString = @"Data Source=DESKTOP-2VG5BCS\SQLEXPRESS;Initial Catalog=pracAdmin;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "delete from AdminTable where AdminID=" + textBox1.Text + ""; //cng tble name and column name 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                show();
                clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
