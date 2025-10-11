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
using System.Text.RegularExpressions;

namespace Study_Abroad_Management
{
    public partial class Studen_REG_Form: Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        public Studen_REG_Form()
        {
            InitializeComponent();
        }

        private void student_submit_button_Click(object sender, EventArgs e)
        {
            // 1) Basic validation (ID check removed)
            if (!string.IsNullOrWhiteSpace(std_name_textBox.Text) &&
                !string.IsNullOrWhiteSpace(stdage_textBox.Text) &&
                !string.IsNullOrWhiteSpace(std_email_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Std_count_comboBox.Text) &&
                !string.IsNullOrWhiteSpace(std_gender_comboBox.Text) &&
                !string.IsNullOrWhiteSpace(std_pass_textBox.Text))
            {
                if (!ValidationClass.IsValidEmail(std_email_textBox.Text)) 
                {
                    MessageBox.Show("Please enter a valid email address. \n For example : abc@gmail.com");
                    
                    std_email_textBox.Focus();
                    return;
                }

                if (std_email_textBox.Text == "abc@gmail.com" || std_email_textBox.Text == "ABC@GMAIL.COM")
                {
                    std_email_textBox.Text.ToLower();
                    MessageBox.Show("Please enter a valid email address. You cannot use abc@gmail.com");
                    std_email_textBox.Focus();
                    return;
                }


                if (!ValidationClass.validAge(stdage_textBox.Text))
                {
                    MessageBox.Show("Please enter a valid age (18-99) and age must be in numbers.");
                   
                    stdage_textBox.Focus();
                    return;
                }

                if (!ValidationClass.validName(std_name_textBox.Text))
                {
                    MessageBox.Show("Please enter a valid name (only letters and spaces are allowed).");
                   
                    std_name_textBox.Focus();
                    return;
                }

                if (!ValidationClass.validPassword(std_pass_textBox.Text)) 
                {
                    MessageBox.Show("Password must be exactly 6 characters long and can contain only letters, digits, and underscores.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    std_pass_textBox.Focus();
                    return;
                }

                // 2) Open connection
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                if (con.State == ConnectionState.Open)
                {
                    // 3) Begin transaction
                    SqlTransaction tx = con.BeginTransaction();

                    try
                    {
                        // === A) INSERT into AdminDetails + capture new ID ===
                        // Explicit columns use korsi jate column-order mismatch na hoy
                        string insertStudent =
                            "INSERT INTO StudentDetails (Name, Nationality, Gender, Email, Age, Password) " +
                            "VALUES(@Name, @Nationality, @Gender, @Email, @Age, @Password);" +
                            "SELECT CAST(SCOPE_IDENTITY() AS INT);";
                        //('" + std_name_textBox.Text + "', '" + Std_count_comboBox.Text + "', '" + std_gender_comboBox.Text + "', '" + std_email_textBox.Text + "', '" + stdage_textBox.Text + "', '" + std_pass_textBox.Text + "');

                        SqlCommand cmdStudent = new SqlCommand(insertStudent, con, tx);

                        cmdStudent.Parameters.AddWithValue("@Name", std_name_textBox.Text);
                        cmdStudent.Parameters.AddWithValue("@Nationality", Std_count_comboBox.Text);
                        cmdStudent.Parameters.AddWithValue("@Gender", std_gender_comboBox.Text);
                        cmdStudent.Parameters.AddWithValue("@Email", std_email_textBox.Text);
                        cmdStudent.Parameters.AddWithValue("@Age", int.Parse(stdage_textBox.Text));
                        cmdStudent.Parameters.AddWithValue("@Password", std_pass_textBox.Text);

                        // capture new identity
                        int newId = Convert.ToInt32(cmdStudent.ExecuteScalar());

                        
                        string insertLogin =
                            "INSERT INTO loginTable (ID, name, role, password, status) " +
                            "VALUES(@ID, @name, @role, @password, @status); ";
                        //(" + newId + ", '" + std_name_textBox.Text + "', 'student', '" + std_pass_textBox.Text + "', 0);

                        SqlCommand cmdLogin = new SqlCommand(insertLogin, con, tx);
                        
                        cmdLogin.Parameters.AddWithValue("@ID", newId);
                        cmdLogin.Parameters.AddWithValue("@Name", std_name_textBox.Text);
                        cmdLogin.Parameters.AddWithValue("@role", "student");
                        cmdLogin.Parameters.AddWithValue("@password", std_pass_textBox.Text);
                        cmdLogin.Parameters.AddWithValue("@status", 0);
                        
                        int resultLogin = cmdLogin.ExecuteNonQuery();

                        //  Both success → commit
                        tx.Commit();

                        if (resultLogin == 1)
                        {
                            MessageBox.Show("Sign Up Successful");
                            DialogResult drr = MessageBox.Show("This is Your ID For Log In : " + newId.ToString() + "\n Please Remeber Your ID", "Your ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (drr == DialogResult.OK)
                            {
                                Log_In_Form log = new Log_In_Form();
                                log.Show();
                                this.Hide();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Sign Up Failed");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Any error → rollback
                        try { tx.Rollback(); } catch { }
                        MessageBox.Show("Sign Up Failed: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Connection Failed");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Fill all the fields");
            }
        }

       

        private void Studen_REG_Form_Load(object sender, EventArgs e)
        {

        }

        private void CLEARbutton_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                std_name_textBox.Clear();
               stdage_textBox.Clear();
                std_email_textBox.Clear();
                
                Std_count_comboBox.Text = "";
                std_gender_comboBox.Items.Clear();
                std_pass_textBox.Clear();

                std_name_textBox.Focus();

                std_gender_comboBox.Items.Add("Male");
                std_gender_comboBox.Items.Add("Female");



                //Std_count_comboBox.Items.Add("United States");
                //Std_count_comboBox.Items.Add("India");
                //Std_count_comboBox.Items.Add("Canada");
                //Std_count_comboBox.Items.Add("Australia");
                //Std_count_comboBox.Items.Add("Bangladesh");
                //Std_count_comboBox.Items.Add("United Kingdom");
                //Std_count_comboBox.Items.Add("Japan");
                //Std_count_comboBox.Items.Add("Germany");
                //Std_count_comboBox.Items.Add("Brazil");
                //Std_count_comboBox.Items.Add("France");
                //Std_count_comboBox.Items.Add("Italy");
                //Std_count_comboBox.Items.Add("Russia");
                //Std_count_comboBox.Items.Add("China");
                //Std_count_comboBox.Items.Add("Mexico");
                //Std_count_comboBox.Items.Add("South Korea");
                //Std_count_comboBox.Items.Add("Spain");
                //Std_count_comboBox.Items.Add("Saudi Arabia");
                //Std_count_comboBox.Items.Add("Argentina");
                //Std_count_comboBox.Items.Add("South Africa");
                //Std_count_comboBox.Items.Add("Egypt");

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;



            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }

        private void ExitbuttonStd_Click(object sender, EventArgs e)
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

        private void BackbuttonStd_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                Log_In_Form log = new Log_In_Form();
                log.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
            con.Close();
        }

        private void std_email_textBox_TextChanged(object sender, EventArgs e)
        {
            std_email_textBox.ForeColor = Color.Black;
            label2.Visible = true;
            if (!ValidationClass.IsValidEmail(std_email_textBox.Text))
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Use a valid email format (e.g. abc@gmail.com)";

            }
            else 
            {
                label2.ForeColor = Color.Green;
                label2.Text = "Use a valid email format (e.g. abc@gmail.com)";
            }
        }

        private void std_name_textBox_TextChanged(object sender, EventArgs e)
        {
               label1.Visible = true;
               
               if (!ValidationClass.validName(std_name_textBox.Text))
               {
                    
                    label1.ForeColor = Color.Red;
                    label1.Text = "Name can only contain letters and spaces";
               }
               else
               {
                    
                    label1.ForeColor = Color.Green;
                    label1.Text = "Name can only contain letters and spaces";
               }
        }

        private void stdage_textBox_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = true;

            if (!ValidationClass.validAge(stdage_textBox.Text))
            {
               
                label3.ForeColor = Color.Red;
                label3.Text = "Age must be a number between 18 and 99";
            }
            else
            {
               
                label3.ForeColor = Color.Green;
                label3.Text = "Age must be a number between 18 and 99";
            }
        }

        private void std_pass_textBox_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            if (!ValidationClass.validPassword(std_pass_textBox.Text))
            {
                
                label5.ForeColor = Color.Red;
                label5.Text = "Password must be exactly 6 characters long and can contain only letters, digits, and underscores.";
            }
            else
            {
               
                label5.ForeColor = Color.Green;
                label5.Text = "Password must be exactly 6 characters long and can contain only letters, digits, and underscores.";
            } 
        }
        private void Std_count_comboBox_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            if (ValidationClass.validName(Std_count_comboBox.Text))
            {
               
                label4.ForeColor = Color.Green;
                label4.Text = "Country names can only contain letters, spaces";
            }
            else 
            {
               
                label4.ForeColor = Color.Red;
                label4.Text = "Country names can only contain letters, spaces";
            }
        }

        private void std_name_textBox_Leave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void std_email_textBox_Leave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void stdage_textBox_Leave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        

        private void Std_count_comboBox_Leave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void std_pass_textBox_Leave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }
    }
}
