using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Abroad_Management
{

    public partial class Dashboard : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        // Add this field declaration to the Dashboard class, near the top with other controls
        private TextBox id_txtbox;
       
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

        public void _clear()
        {
           // search_by_nm.Text = "";
             id_txtbox.Text = "";
        }

        private void dgvUrDs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //id_txtbox.Text = dgvUrDs.Rows[e.RowIndex].Cells[1].Value.ToString();
            // Add this initialization in the Dashboard constructor, after InitializeComponent();
            id_txtbox = this.Controls.Find("id_txtbox", true).FirstOrDefault() as TextBox;
            id_txtbox.Text = dgvUrDs.Rows[e.RowIndex].Cells["CourseCode"].Value.ToString();
        }

        private void delet_Click(object sender, EventArgs e)
        {        
            try
            {
                if (string.IsNullOrWhiteSpace(id_txtbox.Text))
                {
                    MessageBox.Show("Please select a row first.");
                    return;
                }

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string query = "DELETE FROM URDashboard WHERE CourseCode = @CourseCode";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseCode", id_txtbox.Text.Trim());
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully!");
                            show();
                            _clear();
                        }
                        else
                        {
                            MessageBox.Show("No record found with that Course Code.");
                        }
                    }
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
  
            //if (dgvUrDs.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Please select a row first!");
            //    return;
            //}

            //if (conn.State != ConnectionState.Open)
            //{
            //    conn.Open();
            //}
            //if (conn.State == ConnectionState.Open)
            //{
            //    SqlTransaction tx = conn.BeginTransaction();
            //    try
            //    {
            //        string searchText = search_by_nm.Text.Trim();
            //        string searchBy = search_option.Text;
            //        string columnName = "";

            //        if (searchBy == "Course Name")
            //            columnName = "CourseName";
            //        else if (searchBy == "University Name")
            //            columnName = "UniversityName";

            //        string stdDetailquery = "delete from StudentDetails where " + columnName + " = @val";
            //        SqlCommand cmd = new SqlCommand(stdDetailquery, conn, tx);
            //        cmd.Parameters.AddWithValue("@val", searchText);
            //        int deleteresult = cmd.ExecuteNonQuery();

            //        if (deleteresult > 0)
            //        {
            //            string loginTablequery = "delete from loginTable where " + columnName + " = @val";
            //            SqlCommand cmd2 = new SqlCommand(loginTablequery, conn, tx);
            //            cmd2.Parameters.AddWithValue("@val", searchText);
            //            int resultDelete = cmd2.ExecuteNonQuery();

            //            tx.Commit();

            //            if (resultDelete > 0)
            //            {
            //                MessageBox.Show("Deleted Successfully");
            //                show();
            //                _clear();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Deletion Failed");
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        try { tx.Rollback(); } catch { }
            //        MessageBox.Show("Deletion Failed: " + ex.Message);
            //    }
            //    finally
            //    {
            //        if (conn.State == ConnectionState.Open)
            //        {
            //            conn.Close();
            //        }
            //    }
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string adminName = GlobalData.LoggedInUserName;
            string adminID = GlobalData.LoggedInUserID.ToString();
            Adminlabel.Text = "Welcome, " + adminName;
            AdminIDlabel.Text = "ID: " + adminID;
        }

        private void search_by_nm_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string searchText = search_by_nm.Text.Trim();

                // If search box is empty, show all data again
                string query;
                if (string.IsNullOrEmpty(searchText))
                {
                    query = "SELECT * FROM URDashboard";
                }
                else
                {
                    query = "SELECT * FROM  URDashboard WHERE CourseName LIKE @searchText";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUrDs.DataSource = dt;
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
            //    string searchText = search_by_nm.Text.Trim();
            //    string searchBy = search_option.Text; // ComboBox selection (Name or ID)

            //    // Check if user selected search type
            //    if (string.IsNullOrEmpty(searchBy))
            //    {
            //        if (!string.IsNullOrEmpty(searchText))
            //        {
            //            MessageBox.Show("Please select a search operator (course Name or Uni-name).", "Search Option Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            search_by_nm.Clear();
            //        }
            //        return;
            //    }

            //    if (conn.State != ConnectionState.Open)
            //    {
            //        conn.Open();
            //    }

            //    string query = "";

            //    if (string.IsNullOrEmpty(searchText))
            //    {
            //        query = "SELECT* FROM URDashboard";
            //    }
            //    else
            //    {
            //        if (searchBy == "CourseName")
            //        {
            //            query = "SELECT* FROM URDashboard WHERE CourseName LIKE @searchText";//CAST(ID AS NVARCHAR)
            //        }
            //        else if (searchBy == "UniversityName")
            //        {
            //            query = "SELECT* FROM URDashboard WHERE UniversityName LIKE @searchText";
            //        }
            //    }

            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dgvUrDs.DataSource = dt;
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

      
    }
}
