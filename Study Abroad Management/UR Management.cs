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
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;");
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
            id_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim();
            name_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells["Name"].Value.ToString().Trim();
            nty_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells["Nationality"].Value.ToString().Trim();
            email_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells["Email"].Value.ToString().Trim();
            unm_txtbx.Text = dgvURmng.Rows[e.RowIndex].Cells["UniversityName"].Value.ToString().Trim();
            eiin_txtbox.Text = dgvURmng.Rows[e.RowIndex].Cells["EIIN"].Value.ToString().Trim();

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


            if (!String.IsNullOrWhiteSpace(name_txtbox.Text) && !String.IsNullOrEmpty(nty_txtbox.Text) &&
               !String.IsNullOrWhiteSpace(email_txtbox.Text) && !String.IsNullOrWhiteSpace(unm_txtbx.Text)
                && !String.IsNullOrWhiteSpace(eiin_txtbox.Text) && !String.IsNullOrWhiteSpace(id_txtbox.Text))
            {
                if (!ValidationClass.validName(name_txtbox.Text))
                {
                    MessageBox.Show("Please enter a valid name (only letters and spaces are allowed). \n While updating name, clear the name text box first.");
                    name_txtbox.Focus();
                    return;
                }
                if (!ValidationClass.IsValidEmail(email_txtbox.Text))
                {
                    MessageBox.Show("Please enter a valid email address. For example : abc@gmail.com \n While updating email clear the email text box first.");
                    email_txtbox.Focus();
                    return;
                }
                if (!ValidationClass.validateEIIN(eiin_txtbox.Text))
                {
                    MessageBox.Show("Please enter a valid EIIN. 6 digits");
                    eiin_txtbox.Focus();
                    return;
                }
                if (!ValidationClass.validName(nty_txtbox.Text))
                {
                    MessageBox.Show("Please enter a valid country name (only letters and spaces are allowed).");
                    nty_txtbox.Focus();
                    return;
                }
                if (!ValidationClass.validUniversity(unm_txtbx.Text))
                {
                    MessageBox.Show("Please enter a valid University name (only letters and spaces are allowed). \n While updating U.name, clear the U.name text box first.");
                    unm_txtbx.Focus();
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
                        //string query = "update URDetails set Name='" + name_txtbox.Text + "',Nationality ='" + nty_txtbox.Text + "', Email='" + email_txtbox.Text + " ',UniversityName  = '" + unm_txtbx.Text + "',EIIN='" + eiin_txtbox.Text + "'  where ID='" + id_txtbox.Text + "'";
                        //SqlCommand cmd = new SqlCommand(query, conn, tx);
                        string query = @"UPDATE URDetails 
                                      SET Name = @Name, 
                                          Nationality = @Nationality, 
                                          Email = @Email, 
                                          UniversityName = @UniversityName, 
                                          EIIN = @EIIN 
                                          WHERE ID = @ID";

                        SqlCommand cmd = new SqlCommand(query, conn, tx);

                        cmd.Parameters.AddWithValue("@Name", name_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nationality", nty_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", email_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@UniversityName", unm_txtbx.Text.Trim());
                        cmd.Parameters.AddWithValue("@EIIN", int.Parse(eiin_txtbox.Text.Trim()));
                        cmd.Parameters.AddWithValue("@ID", int.Parse(id_txtbox.Text.Trim()));

                        int updateresult = cmd.ExecuteNonQuery();
                        if (updateresult > 0)
                        {
                            string updatequery2 = "update loginTable set Name='" + name_txtbox.Text + "' where ID='" + id_txtbox.Text + "'";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(id_txtbox.Text))
                {
                    MessageBox.Show("Please select a student first.");
                    return;
                }

                if (!int.TryParse(id_txtbox.Text, out int id))
                {
                    MessageBox.Show("Invalid ID format.");
                    return;
                }

                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to delete this UR record? This action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr != DialogResult.Yes)
                    return;

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // DELETE FROM URDashboard 
                DialogResult dashConfirm = MessageBox.Show(
                    "To delete this record, you must first remove all data from URDashboard.\n\n" +
                    "Do you want to remove them now?",
                    "URDashboard Required Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dashConfirm != DialogResult.Yes)
                {
                    MessageBox.Show("Deletion cancelled. URDashboard must be cleared first.",
                        "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int dashDeleted = 0;
                using (SqlCommand cmdDash = new SqlCommand("DELETE FROM URDashboard WHERE URID = @ID", conn))
                {
                    cmdDash.Parameters.AddWithValue("@ID", id);
                    dashDeleted = cmdDash.ExecuteNonQuery();
                }

                if (dashDeleted > 0)
                {
                    MessageBox.Show("All related records successfully removed from URDashboard.",
                        "Step 1 Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No records found in URDashboard for this ID.",
                        "Step 1 Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //  DELETE FROM URDetails+ log in 
                DialogResult urDetailsConfirm = MessageBox.Show(
                    "URDashboard data removed.\n\nDo you want to delete the URDetails record now?",
                    "Confirm URDetails Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (urDetailsConfirm == DialogResult.Yes)
                {
                    try
                    {
                        if (conn.State != ConnectionState.Open)
                            conn.Open();

                        SqlTransaction tx = conn.BeginTransaction();
                        try
                        {
                            string urDetailsQuery = "DELETE FROM URDetails WHERE ID=@ID";
                            SqlCommand cmd1 = new SqlCommand(urDetailsQuery, conn, tx);
                            cmd1.Parameters.AddWithValue("@ID", id_txtbox.Text.Trim());
                            int urDeleted = cmd1.ExecuteNonQuery();

                            if (urDeleted > 0)
                            {
                                string loginQuery = "DELETE FROM loginTable WHERE ID=@ID";
                                SqlCommand cmd2 = new SqlCommand(loginQuery, conn, tx);
                                cmd2.Parameters.AddWithValue("@ID", id_txtbox.Text.Trim());
                                int loginDeleted = cmd2.ExecuteNonQuery();

                                tx.Commit();
                                if (loginDeleted > 0)
                                {
                                    MessageBox.Show("URDetails  record deleted successfully.");
                                    _show();
                                    _clear();
                                }
                                else
                                {
                                    MessageBox.Show(" Deletion failed.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No URDetails record found for this ID.");
                            }
                        }
                        catch (Exception exInner)
                        {
                            tx.Rollback();
                            MessageBox.Show("Error during deletion: " + exInner.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                }

                //DialogResult urDetailsConfirm = MessageBox.Show(
                //    "URDashboard data removed.\n\nDo you want to delete the URDetails record now?",
                //    "Confirm URDetails Deletion",
                //    MessageBoxButtons.YesNo,
                //    MessageBoxIcon.Question);

                //if (urDetailsConfirm != DialogResult.Yes)
                //{
                //    MessageBox.Show("Deletion stopped after removing URDashboard records.",
                //        "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                //int urDeleted = 0;
                //using (SqlCommand cmdUR = new SqlCommand("DELETE FROM URDetails WHERE ID = @ID", conn))
                //{
                //    cmdUR.Parameters.AddWithValue("@ID", id);
                //    urDeleted = cmdUR.ExecuteNonQuery();
                //}

                //if (urDeleted > 0)
                //{
                //    MessageBox.Show("URDetails record deleted successfully.",
                //        "Step 2 Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("No URDetails record found for this ID.",
                //        "Step 2 Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

                ////   DELETE FROM Login 
                //DialogResult loginConfirm = MessageBox.Show(
                //    "URDetails deleted.\n\nDo you also want to delete this record from Login table?",
                //    "Confirm Login Deletion",
                //    MessageBoxButtons.YesNo,
                //    MessageBoxIcon.Question);

                //if (loginConfirm == DialogResult.Yes)
                //{
                //    int loginDeleted = 0;
                //    using (SqlCommand cmdLogin = new SqlCommand("DELETE FROM loginTable WHERE ID = @ID", conn))
                //    {
                //        cmdLogin.Parameters.AddWithValue("@ID", id);
                //        loginDeleted = cmdLogin.ExecuteNonQuery();
                //    }

                //    if (loginDeleted > 0)
                //    {
                //        MessageBox.Show("Record deleted successfully from Login table.",
                //            "Step 3 Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    else
                //    {
                //        MessageBox.Show("No record found in Login table for this ID.",
                //            "Step 3 Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }

                //    MessageBox.Show(" All related records deleted successfully (URDashboard → URDetails → Login).",
                //        "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("Login record deletion skipped.",
                //        "Skipped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
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

        private void unm_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string searchText = unm_txt.Text.Trim();
                string query;

                if (searchText == "")
                {
                    query = "SELECT ID, Name, Nationality, Email, UniversityName,EIIN FROM URdetails";
                }
                else
                {
                    query = "SELECT ID, Name, Nationality, Email, UniversityName,EIIN FROM URDetails WHERE Name LIKE '%" + searchText + "%'";
                }

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvURmng.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
}
