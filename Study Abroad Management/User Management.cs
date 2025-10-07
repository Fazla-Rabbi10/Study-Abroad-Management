using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions; // this is added for validation
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Abroad_Management
{
    public partial class User_Management : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
       
        public User_Management()
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

        private void id_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            name_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            nty_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            email_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            gender.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            age_txtbx.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            string adminName = GlobalData.LoggedInUserName;
            string adminID = GlobalData.LoggedInUserID.ToString();
            Adminlabel.Text = "Welcome, " + adminName;
            AdminIDlabel.Text = "ID: " + adminID;
        }

        public void _Show()
        {

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (conn.State == ConnectionState.Open)
            {
               
                string query = "SELECT ID,Name,Nationality,Gender,Email,Age  FROM StudentDetails";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else 
            { 
                MessageBox.Show("Connection Failed");
                conn.Close();
            }

        }
        public void _clear()
        {
            id_txtbox.Text = "";
            name_txtbox.Text = "";
            nty_txtbox.Text="";
            email_txtbox.Text = "";
            gender.Text = "";
            age_txtbx.Text="";


        }

        private void show_Click(object sender, EventArgs e)
        {
            try
            {
                _Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

        }

        private void delet_txtbox_Click(object sender, EventArgs e)
        {

            //try
            //{
            //if (id_txtbox.Text == "")
            //    MessageBox.Show("Please select a row first ");
            //else
            //{
            //    string connectionString = @"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;";
            //    SqlConnection conn = new SqlConnection(connectionString);
            //    conn.Open();

            //    string query = "delete from StudentDetails where ID=" + id_txtbox.Text + "";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.ExecuteNonQuery();

            //    //string query2 = "delete from loginTable where ID='" + id_txtbox.Text + "'";
            //    //SqlCommand cmd2 = new SqlCommand(query2, conn);
            //    //cmd2.ExecuteNonQuery();

            //    _Show();
            //    clear();

            //    conn.Close();
            //}


            //catch (Exception ex)
            //{
            // MessageBox.Show("Error: " + ex.Message);
            //}
            DialogResult dr = MessageBox.Show("Before delete this student's information." +
                "\nMake sure you have deleted this student's application records by using the [check button] and [remove button]." +
                "\nOtherwise you cannot delete this user from the system there will occur an error.",
                "Confirm Deletion : Are you sure you want to delete this user?", 
                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if (dr == DialogResult.Yes) 
            { 
                if (!String.IsNullOrWhiteSpace(id_txtbox.Text) && !String.IsNullOrEmpty(id_txtbox.Text))
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
                                string stdDetailquery = "delete from StudentDetails where ID=" + id_txtbox.Text + "";
                                SqlCommand cmd = new SqlCommand(stdDetailquery, conn, tx);
                                int deleteresult = cmd.ExecuteNonQuery();

                            if (deleteresult > 0)
                            {

                                string loginTablequery = "delete from loginTable where ID=" + id_txtbox.Text + "";
                                SqlCommand cmd2 = new SqlCommand(loginTablequery, conn, tx);
                                int resultDelete = cmd2.ExecuteNonQuery();
                                tx.Commit();

                                if (resultDelete > 0)
                                {
                                    MessageBox.Show("Deleted Successfully");
                                    _Show();
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
            }
        }
        

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void updt_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(name_txtbox.Text) && !String.IsNullOrEmpty(nty_txtbox.Text) &&
                !String.IsNullOrWhiteSpace(email_txtbox.Text) && !String.IsNullOrWhiteSpace(gender.Text)
                 && !String.IsNullOrWhiteSpace(age_txtbx.Text) && !String.IsNullOrWhiteSpace(id_txtbox.Text))
            {

                if (!ValidationClass.IsValidEmail(email_txtbox.Text))
                {
                    MessageBox.Show("Please enter a valid email address. For example : abc@gmail.com \n While updating email clear the email text box first.");
                    email_txtbox.Focus();
                    return;
                }

                if (!ValidationClass.validAge(age_txtbx.Text))
                {
                    MessageBox.Show("Please enter a valid age (18-99). \n While updating age clear the age text box first.");
                    age_txtbx.Focus();
                    return;
                }

                if (!ValidationClass.validName(name_txtbox.Text))
                {
                    MessageBox.Show("Please enter a valid name (only letters and spaces are allowed). \n While updating name, clear the name text box first.");
                    name_txtbox.Focus();
                    return;
                }

                if (!ValidationClass.validName(nty_txtbox.Text))
                {
                    MessageBox.Show("Please enter a valid country name (only letters and spaces are allowed).");
                    nty_txtbox.Focus();
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
                        string query = "update StudentDetails set Name='" + name_txtbox.Text + "',Nationality ='" + nty_txtbox.Text + "', Email='" + email_txtbox.Text + " ',Gender = '" + gender.Text + "',Age='" + age_txtbx.Text + "'  where ID='" + id_txtbox.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, conn, tx);
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
                                _Show();
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
            //try
            //{

            //        // string connectionString = @"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;";
            //        //SqlConnection conn = new SqlConnection(connectionString);
            //        //conn.Open();
            //        string query = "update StudentDetails set Name='" + name_txtbox.Text + "',Nationality ='" + nty_txtbox.Text + "', Email='" + email_txtbox.Text + " ',Gender = '" + gender + "',Age='" + age_txtbx + "'  where ID='" + id_txtbox.Text + "'";
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.ExecuteNonQuery();

            //        //string query2 = "update from loginTable where ID='" + id_txtbox.Text + "'";
            //        //SqlCommand cmd2 = new SqlCommand(query2, conn);
            //        //cmd2.ExecuteNonQuery();

            //        _Show();
            //        _clear();

            //        //conn.Close();
            //    


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

            //}
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

        private void search_by_nm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = search_by_nm.Text.Trim();
                string searchBy = search_option.Text; // ComboBox selection (Name or ID)

                // Check if user selected search type
                if (string.IsNullOrEmpty(searchBy))
                {
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        MessageBox.Show("Please select a search operator (Name or ID).", "Search Option Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        search_by_nm.Clear();
                    }
                    return;
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "";

                if (string.IsNullOrEmpty(searchText))
                {
                    query = "SELECT ID, Name, Nationality, Gender, Email, Age FROM StudentDetails";
                }
                else
                {
                    if (searchBy == "ID")
                    {
                        query = "SELECT ID, Name, Nationality, Gender, Email, Age FROM StudentDetails WHERE CAST(ID AS NVARCHAR) LIKE @searchText";
                    }
                    else if (searchBy == "Name")
                    {
                        query = "SELECT ID, Name, Nationality, Gender, Email, Age FROM StudentDetails WHERE Name LIKE @searchText";
                    }
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //try
            //{
            //    if (conn.State != ConnectionState.Open)
            //    {
            //        conn.Open();
            //    }

            //    string searchText = search_by_nm.Text.Trim();

            //    // If search box is empty, show all data again
            //    string query;
            //    if (string.IsNullOrEmpty(searchText))
            //    {
            //        query = "SELECT ID, Name, Nationality, Gender, Email, Age FROM StudentDetails";
            //    }
            //    else
            //    {
            //        query = "SELECT ID, Name, Nationality, Gender, Email, Age FROM StudentDetails WHERE Name LIKE @searchText";
            //    }

            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    if (conn.State == ConnectionState.Open)
            //    {
            //        conn.Close();
            //    }
            //}

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_option_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void check_apply_button_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!String.IsNullOrWhiteSpace(id_txtbox.Text))
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    if (conn.State == ConnectionState.Open)
                    {
                        String applyQuery = "select * from ApplicationStatus where StudentID = @ID";
                        SqlCommand applycmd = new SqlCommand(applyQuery, conn);

                        applycmd.Parameters.AddWithValue("@ID", int.Parse(id_txtbox.Text));

                        SqlDataAdapter sda = new SqlDataAdapter(applycmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Student Has Applied For Courses.");
                        }
                        else
                        {
                            MessageBox.Show("Student Did not Applied for any Courses.");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Connection Failed");
                        conn.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Please select a student first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void Apply_remove_button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to remove this student's application records? This action cannot be undone.", 
                    "Confirm Removal", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes) 
                {
                    if (!String.IsNullOrWhiteSpace(id_txtbox.Text))
                    {
                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        if (conn.State == ConnectionState.Open)
                        {
                            String removeQuery = "delete from ApplicationStatus where StudentID = @ID";
                            SqlCommand removecmd = new SqlCommand(removeQuery, conn);
                            removecmd.Parameters.AddWithValue("@ID", int.Parse(id_txtbox.Text));
                            int result = removecmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show(" Student Application Records Removed Successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No Application Records Found for this Student.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Connection Failed");
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a student first.");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //private void bname_Click(object sender, EventArgs e)
        //{

        //}
    }
}
