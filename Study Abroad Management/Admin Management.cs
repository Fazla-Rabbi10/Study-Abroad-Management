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
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;");
        public Admin_Management()
        {
            InitializeComponent();
        }

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
        public void 
            
           _clear()
        {
            id_txtbx.Text = "";
            addrs_txtbx.Text = "";
            nm_txtbx.Text = "";
            email_txtbx.Text = "";
            cntry.Text = "";
            contact_txtbx.Text="";
        }
        public void _show()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (conn.State == ConnectionState.Open)
            {               
                string query = "SELECT ID,Name,Address,Email,Country,Gender,ContactNumber FROM AdminDetails";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAdmTbl.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Connection Failed");
                conn.Close();

            }
        }
        private void dgvAdmTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            nm_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells["Name"].Value.ToString().Trim();
            addrs_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells["Address"].Value.ToString().Trim();         
            email_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells["Email"].Value.ToString().Trim();
            cntry.Text = dgvAdmTbl.Rows[e.RowIndex].Cells["Country"].Value.ToString().Trim();
            contact_txtbx.Text = dgvAdmTbl.Rows[e.RowIndex].Cells["ContactNumber"].Value.ToString().Trim();
           
        }
        private void id_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Management_Load(object sender, EventArgs e)
        {
            string adminName = GlobalData.LoggedInUserName;
            string adminID = GlobalData.LoggedInUserID.ToString();
            Adminlabel.Text = "Welcome, " + adminName;
            AdminIDlabel.Text = "ID: " + adminID;
        }

        private void stts_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void showButton_Click_1(object sender, EventArgs e)
        {
            try { 
                _show();
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
            if (!String.IsNullOrWhiteSpace(nm_txtbx.Text) && !String.IsNullOrWhiteSpace(addrs_txtbx.Text) &&
               !String.IsNullOrWhiteSpace(email_txtbx.Text) && !String.IsNullOrWhiteSpace(cntry.Text) &&
               !String.IsNullOrWhiteSpace(contact_txtbx.Text) && !String.IsNullOrWhiteSpace(id_txtbx.Text))
            {

                if (!ValidationClass.IsValidEmail(email_txtbx.Text))
                {
                    MessageBox.Show("Please enter a valid email address. For example : abc@gmail.com \n While updating email clear the email text box first.");
                    email_txtbx.Focus();
                    return;
                }

                if (!ValidationClass.validAddress(addrs_txtbx.Text))
                {
                    MessageBox.Show("Please enter a valid address. \n While updating address,clear the address text box first.");
                    addrs_txtbx.Focus();
                    return;
                }

                if (!ValidationClass.validName(nm_txtbx.Text))
                {
                    MessageBox.Show("Please enter a valid name (only letters and spaces are allowed). \n While updating name, clear the name text box first.");
                    nm_txtbx.Focus();
                    return;
                }

                if (!ValidationClass.validName(cntry.Text))// be changed to validCountry
                {
                    MessageBox.Show("Please enter a valid country name (only letters and spaces are allowed).");
                    cntry.Focus();
                    return;
                }
                if (!ValidationClass.IsValidContactNumber(contact_txtbx.Text))
                {
                    MessageBox.Show("Please enter a valid contact number (only digits are allowed and length should be 11). \n While updating contact number, clear the contact number text box first.");
                    contact_txtbx.Focus();
                    return;
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                if (conn.State == ConnectionState.Open)
                {
                    SqlTransaction tx = conn.BeginTransaction();
                    try
                    {
                        //string query = "update AdminDetails set Name='" + nm_txtbx.Text + "',Address ='" + addrs_txtbx.Text + "', Email='" + email_txtbx.Text + " ',ContactNumber = '" + contact_txtbx.Text + "',Country='" + cntry.Text + "'  where ID='" + id_txtbx.Text + "'";
                        //SqlCommand cmd = new SqlCommand(query, conn, tx);
                        string query = @"UPDATE AdminDetails 
                                          SET Name = @Name, 
                                              Address = @Address, 
                                              Email = @Email, 
                                              ContactNumber = @ContactNumber, 
                                              Country = @Country 
                                              WHERE ID = @ID";

                        SqlCommand cmd = new SqlCommand(query, conn, tx);

                        cmd.Parameters.AddWithValue("@Name", nm_txtbx.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", addrs_txtbx.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", email_txtbx.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", contact_txtbx.Text.Trim());
                        cmd.Parameters.AddWithValue("@Country", cntry.Text.Trim());
                        cmd.Parameters.AddWithValue("@ID", int.Parse(id_txtbx.Text.Trim()));

                        int updateresult = cmd.ExecuteNonQuery();
                        if (updateresult > 0)
                        {
                            string updatequery2 = "update loginTable set Name='" + nm_txtbx.Text + "' where ID='" + id_txtbx.Text + "'";
                            SqlCommand cmd2 = new SqlCommand(updatequery2, conn, tx);
                            int resultUpdate = cmd2.ExecuteNonQuery();
                            tx.Commit();
                            if (resultUpdate > 0)
                            {
                                MessageBox.Show("Updated Successfully");
                                _show();
                                _clear();
                            }
                            else
                            {
                                MessageBox.Show("Update Failed");
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        MessageBox.Show("Update Failed: " + ex.Message);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void delet_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(id_txtbx.Text) && !String.IsNullOrEmpty(id_txtbx.Text))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                if (conn.State == ConnectionState.Open)
                {
                    SqlTransaction tx = conn.BeginTransaction();
                    try
                    {
                        string admDetailquery = "delete from AdminDetails where ID=" + id_txtbx.Text + "";
                        SqlCommand cmd = new SqlCommand(admDetailquery, conn, tx);
                        int deleteresult = cmd.ExecuteNonQuery();

                        if (deleteresult > 0)
                        {

                            string loginTablequery = "delete from loginTable where ID=" + id_txtbx.Text + "";
                            SqlCommand cmd2 = new SqlCommand(loginTablequery, conn, tx);
                            int resultDelete = cmd2.ExecuteNonQuery();
                            tx.Commit();

                            if (resultDelete > 0)
                            {
                                MessageBox.Show("Deleted Successfully");
                                _show();
                                _clear();

                            }
                            else
                            {
                                MessageBox.Show("Deletion Failed");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        MessageBox.Show("Deletion Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }


                }
            }
            else
            {
                MessageBox.Show("Please select a row first ");
            }

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

        private void AdminIDlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
