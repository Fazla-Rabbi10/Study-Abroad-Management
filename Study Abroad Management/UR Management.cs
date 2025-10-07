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
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;");
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


        public void _clear()
        {
            id_txtbox.Text = "";

            name_txtbox.Text = "";
            nty_txtbox.Text="";
            email_txtbox.Text = "";
            unm_txtbx.Text = "";
            eiin_txtbox.Text = "";

        }
        public void _show()
        {           
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (conn.State == ConnectionState.Open)
            { 
                string query = "SELECT ID,Name,Nationality,Gender,Email,UniversityName,EIIN  FROM URDetails";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvURmng.DataSource = dt;               
            }
            else
            {
                MessageBox.Show("Connection Failed");
                conn.Close();

            }
        }


        private void dgvURmng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells[0].Value.ToString();
            name_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells[1].Value.ToString();
            nty_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells[2].Value.ToString();
            email_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells[4].Value.ToString();
            unm_txtbx.Text = dgvURmng.Rows[e.RowIndex].Cells[5].Value.ToString();
            eiin_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try {
                _show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :"+ex.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            //if (!String.IsNullOrWhiteSpace(name_txtbox.Text) && !String.IsNullOrEmpty(nty_txtbox.Text) &&
            //   !String.IsNullOrWhiteSpace(email_txtbox.Text) && !String.IsNullOrWhiteSpace(unm_txtbx.Text)
            //    && !String.IsNullOrWhiteSpace(eiin_txtbox.Text) && !String.IsNullOrWhiteSpace(id_txtbox.Text))
            //{
            //    if (!ValidationClass.validName(name_txtbox.Text))
            //    {
            //        MessageBox.Show("Please enter a valid name (only letters and spaces are allowed). \n While updating name, clear the name text box first.");
            //        name_txtbox.Focus();
            //        return;
            //    }
            //    if (!ValidationClass.IsValidEmail(email_txtbox.Text))
            //    {
            //        MessageBox.Show("Please enter a valid email address. For example : abc@gmail.com \n While updating email clear the email text box first.");
            //        email_txtbox.Focus();
            //        return;
            //    }
            //    if (!ValidationClass.validAge(eiin_txtbox.Text))
            //    {
            //        MessageBox.Show("Please enter a valid EIIN . \n While updating EIIN, clear the EIIN text box first.");
            //        eiin_txtbox.Focus();
            //        return;
            //    }
            //    if (!ValidationClass.validName(nty_txtbox.Text))
            //    {
            //        MessageBox.Show("Please enter a valid country name (only letters and spaces are allowed).");
            //        nty_txtbox.Focus();
            //        return;
            //    }
            //    if (!ValidationClass.validName(unm_txtbx.Text))
            //    {
            //        MessageBox.Show("Please enter a valid name (only letters and spaces are allowed). \n While updating name, clear the name text box first.");
            //        unm_txtbx.Focus();
            //        return;
            //    }

            //    if (conn.State != ConnectionState.Open)
            //    {
            //        conn.Open();
            //    }
            //    if (conn.State == ConnectionState.Open)
            //    {
            //        SqlTransaction tx = conn.BeginTransaction();
            //        try
            //        {
            //            string query = "update URDetails set Name='" + name_txtbox.Text + "',Nationality ='" + nty_txtbox.Text + "', Email='" + email_txtbox.Text + " ',UniversityName  = '" + unm_txtbx.Text + "',EIIN='" + eiin_txtbox.Text + "'  where ID='" + id_txtbox.Text + "'";
            //            SqlCommand cmd = new SqlCommand(query, conn, tx);
            //            int updateresult = cmd.ExecuteNonQuery();
            //            if (updateresult > 0)
            //            {
            //                string updatequery2 = "update loginTable set Name='" + name_txtbox.Text + "' where ID='" + id_txtbox.Text + "'";
            //                SqlCommand cmd2 = new SqlCommand(updatequery2, conn, tx);
            //                int resultUpdate = cmd2.ExecuteNonQuery();
            //                tx.Commit();
            //                if (resultUpdate > 0)
            //                {
            //                    MessageBox.Show("Updated Successfully");
            //                    _show();
            //                    _clear();
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Update Failed");
            //                }
            //            }

            //        }
            //        catch (Exception ex)
            //        {
            //            try { tx.Rollback(); } catch { }
            //            MessageBox.Show("Update Failed: " + ex.Message);
            //        }
            //        finally
            //        {
            //            if (conn.State == ConnectionState.Open)
            //            {
            //                conn.Close();
            //            }
            //        }


            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please fill all the fields");
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (id_txtbox.Text == "")
            //        MessageBox.Show("Please select a row first ");
            //    else
            //    {
            //        string connectionString = @"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;";
            //        SqlConnection conn = new SqlConnection(connectionString);
            //        conn.Open();

            //        string query = "delete from URDetails where ID=" + id_txtbox.Text + "";
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.ExecuteNonQuery();

            //        //string query2 = "delete from loginTable where ID='" + id_txtbox.Text + "'";
            //        //SqlCommand cmd2 = new SqlCommand(query2, conn);
            //        //cmd2.ExecuteNonQuery();

            //        _show();
            //        _clear();

            //        conn.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
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
            string adminName = GlobalData.LoggedInUserName;
            string adminID = GlobalData.LoggedInUserID.ToString();
            Adminlabel.Text = "Welcome, " + adminName;
            AdminIDlabel.Text = "ID: " + adminID;
        }

        private void contact_Click(object sender, EventArgs e)
        {

        }

        private void contact_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void eiin_Click(object sender, EventArgs e)
        {

        }

        private void eiin_txtbox_TextChanged(object sender, EventArgs e)
        {

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
    }
}
