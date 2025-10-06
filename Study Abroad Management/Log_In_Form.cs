using Study_Abroad_Management.UR;
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
    public partial class Log_In_Form: Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        public Log_In_Form()
        {
            InitializeComponent();
        }

        private void Sign_Up_button_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
               
                this.UR_button.Visible = true;
                this.Student_button.Visible = true;
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
            

        }


        private void UR_button_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            if (con.State == ConnectionState.Open)
            {
                UR_REG_Formcs urf = new UR_REG_Formcs();
                urf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
            

        }

        private void Student_button_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            else if (con.State == ConnectionState.Open)
            {
                Studen_REG_Form srf = new Studen_REG_Form();
                srf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
            
           
            
        }

        private void Lof_in_button_Click(object sender, EventArgs e)
        {
            try
            {
                string log_query = "select * from loginTable where ID = @ID and password = @password";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(log_query, con);
                
                cmd.Parameters.AddWithValue("@ID", int.Parse(LG_ID_textBox.Text));
                cmd.Parameters.AddWithValue("@password", Lg_Password_textBox2.Text);
                

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                if (con.State == ConnectionState.Open)
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {

                        if (dt.Rows[0][4].ToString() == "1")
                        {
                            int userID = Convert.ToInt32(dt.Rows[0][0]); 
                            string userName = dt.Rows[0][1].ToString();

                            GlobalData.LoggedInUserID = userID; 
                            GlobalData.LoggedInUserName = userName;

                            if (dt.Rows[0][2].ToString() == "admin")
                            {
                                MessageBox.Show("Login Successful as Admin");
                                Admin_Pannel a = new Admin_Pannel();
                                a.Show();
                                this.Hide();
                            }
                            else if (dt.Rows[0][2].ToString() == "UR")
                            {
                                MessageBox.Show("Login Successful as University Representative");
                                new UniversityRepresentative().Show();
                                this.Hide();
                            }
                            else if (dt.Rows[0][2].ToString() == "student")
                            {
                                MessageBox.Show("Login Successful as Student");
                                new User_Student().Show();
                                this.Hide();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Account Inactive wait for admin to active your account");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID or Password");
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
                MessageBox.Show("Login Failed: " + ex.Message +"\n ID must be numeric(only numbers no special characters and space) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            con.Close();
        }

        private void LogIN_Clear_button_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                LG_ID_textBox.Clear();
                Lg_Password_textBox2.Clear();
                LG_ID_textBox.Focus();
                if (this.UR_button.Visible == true &&
                   this.Student_button.Visible == true)
                   
                {
                    
                    this.UR_button.Visible = false;
                    this.Student_button.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }

        private void Login_Exit_button_Click(object sender, EventArgs e)
        {
            DialogResult drr = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                if (drr == DialogResult.Yes)
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

        private void Forget_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                Forget_Password fp = new Forget_Password();
                fp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }
    }
}
