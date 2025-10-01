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
    public partial class Access_Management : Form
    {
        int userid;
        public int Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-01OR5KU\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        public Access_Management()
        {
            InitializeComponent();
        }

        private void Access_Management_Load(object sender, EventArgs e)
        {
            string AdminName = GlobalData.LoggedInUserName;
            string AdminID = GlobalData.LoggedInUserID.ToString();
            Adminlabel.Text = "Welcome, " + AdminName;
            AdminIDlabel.Text = "ID: " + AdminID;
        }
        public void LoadDataaaa() 
        {
            try
            {
                string accessquery = "select ID, name, role, status from loginTable";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(accessquery, con);
                if (con.State == ConnectionState.Open)
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Access_dataGridView.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Connection Failed");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void Admin_show_button_Click(object sender, EventArgs e)
        {
            LoadDataaaa();
        }
       
        private void Admin_Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                string search = "select ID, name, role, status from loginTable where ID like @SearchID";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(search, con);
                cmd.Parameters.AddWithValue("@SearchID", "%" + Admin_Search_TextBox.Text + "%");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                if (con.State == ConnectionState.Open)
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Access_dataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Connection Failed");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void Access_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                if (con.State == ConnectionState.Open)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = Access_dataGridView.Rows[e.RowIndex];
                        Userid = int.Parse(row.Cells["ID"].Value.ToString());


                    }
                }
                else
                {
                    MessageBox.Show("Connection Failed");
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void Admin_access_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Userid.ToString()) &&
                !String.IsNullOrWhiteSpace(Userid.ToString()))
            {
                try
                {

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    if (con.State == ConnectionState.Open)
                    {
                        string accessquery = "select * from loginTable where ID = @UserId";
                        SqlCommand accesscmd = new SqlCommand(accessquery, con);
                        accesscmd.Parameters.AddWithValue("@UserId", Userid);
                        SqlDataAdapter sda = new SqlDataAdapter(accesscmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {

                            if (dt.Rows[0][4].ToString() == "0")
                            {

                                string giveaccessquery = "update loginTable set status = 1 where ID = @UserId";
                                SqlCommand cmd = new SqlCommand(giveaccessquery, con);
                                cmd.Parameters.AddWithValue("@UserId", Userid);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected == 1)
                                {
                                    MessageBox.Show("User Access Granted Successfully");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to grant access. Please try again.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("User already has access.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a user from the table.");
                        }
                        //grid table theke kichu select na kore access dile ei line execute hobe,
                        //bak else er messagebox gula dekhabe na karon rows count 1 hocche na.
                    }
                    else
                    {
                        MessageBox.Show("Connection Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user from the table.");
            }
            // tar mane grid table theke choose na korle userid empty ba null er jonoo ekhane ashte hocche na,
            //ager messagebox ta execute hoye jacche.
            LoadDataaaa();
        }

        private void Access_back_button_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                Admin_Pannel ap = new Admin_Pannel();
                ap.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }

        private void Access_exit_button_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                DialogResult dr = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }

        private void Seize_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Userid.ToString()) &&
                !String.IsNullOrWhiteSpace(Userid.ToString()))
            {
                try
                {

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    if (con.State == ConnectionState.Open)
                    {
                        string accessquery = "select * from loginTable where ID = @UserId";
                        SqlCommand accesscmd = new SqlCommand(accessquery, con);
                        accesscmd.Parameters.AddWithValue("@UserId", Userid);
                        SqlDataAdapter sda = new SqlDataAdapter(accesscmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {

                            if (dt.Rows[0][4].ToString() == "1")
                            {

                                string giveaccessquery = "update loginTable set status = 0 where ID = @UserId";
                                SqlCommand cmd = new SqlCommand(giveaccessquery, con);
                                cmd.Parameters.AddWithValue("@UserId", Userid);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected == 1)
                                {
                                    MessageBox.Show("User Access Seized Successfully");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to seize access. Please try again.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("User access has already seized.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a user from the table.");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Connection Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user from the table.");
            }
           
            LoadDataaaa();
        }

        private void Accessrefreshbutton_Click(object sender, EventArgs e)
        {
            LoadDataaaa();
        }
    }
}
