using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Abroad_Management
{
    public partial class User_Management : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=LAPTOP-JCQ2J3KL\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;");
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;");
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
                            MessageBox.Show("Deletion Failed: " + ex.Message);
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
        

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void updt_Click(object sender, EventArgs e)
        {
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
            if (!String.IsNullOrWhiteSpace(name_txtbox.Text) && !String.IsNullOrEmpty(nty_txtbox.Text) &&
                !String.IsNullOrWhiteSpace(email_txtbox.Text) && !String.IsNullOrWhiteSpace(gender.Text)
                 && !String.IsNullOrWhiteSpace(age_txtbx.Text) && !String.IsNullOrWhiteSpace(id_txtbox.Text))
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
            //try
            //{
            //    //    string connectionString = @"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;";  //con string 
            //    //    SqlConnection conn = new SqlConnection(connectionString);
            //    //    conn.Open();

            //    //    string query = "SELECT *  FROM StudentDetails where Name like '%" + search_by_nm + "%'";
            //    //    SqlCommand cmd = new SqlCommand(query, conn);
            //    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    //    DataSet ds = new DataSet();
            //    //    da.Fill(ds);
            //    //    DataTable dt = ds.Tables[0];
            //    //    dataGridView1.AutoGenerateColumns = true;
            //    //    dataGridView1.DataSource = dt;
            //    //    Show();

            //    //    conn.Close();
            //}
            ///*try
            //{
            //    string searchequery = "SELECT* FROM StudentDetails where Name like  '%" + search_by_nm + "%'";
            //    string connectionString = @"Data Source=LAPTOP-JCQ2J3KL\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;";
            //    SqlConnection conn = new SqlConnection(connectionString);
            //    if (conn.State != ConnectionState.Open)
            //    {
            //        conn.Open();
            //    }
            //    SqlDataAdapter sda = new SqlDataAdapter(searchequery, conn);
            //    if (conn.State == ConnectionState.Open)
            //    {
            //        DataTable dt = new DataTable();
            //        sda.Fill(dt);
            //        dataGridView1.DataSource = dt;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Connection Failed");
            //        conn.Close();
            //    }*/           
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
           
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void entr_id_Click(object sender, EventArgs e)
        //{

        //}
    }
}
