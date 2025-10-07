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
    public partial class UR_REG_Formcs: Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        public UR_REG_Formcs()
        {
            InitializeComponent();
        }

        

        private void UR_submit_button_Click(object sender, EventArgs e)
        {
            // 1) Basic validation (ID check removed)
            if (!string.IsNullOrWhiteSpace(UR_name_textBox.Text) &&
                !string.IsNullOrWhiteSpace(UR_university_textBox.Text) &&
                !string.IsNullOrWhiteSpace(UR_email_textBox.Text) &&
                !string.IsNullOrWhiteSpace(UR_count_comboBox.Text) &&
                !string.IsNullOrWhiteSpace(UR_gender_comboBox.Text) &&
                !string.IsNullOrWhiteSpace(UR_EIIN_textBox.Text) &&
                !string.IsNullOrWhiteSpace(UR_pass_textBox.Text))
            {
                if (!ValidationClass.IsValidEmail(UR_email_textBox.Text)) 
                {
                    MessageBox.Show("Please Enter a valid Email \n For Example : abc@gmail.com");
                    
                    UR_email_textBox.Focus();

                    return;
                }

                if (UR_email_textBox.Text == "abc@gmail.com" || UR_email_textBox.Text == "ABC@GMAIL.COM")
                {
                    UR_email_textBox.Text.ToLower();
                    MessageBox.Show("Please enter a valid email address. You cannot use abc@gmail.com");
                    UR_email_textBox.Focus();
                    return;
                }

                if (!ValidationClass.validateEIIN(UR_EIIN_textBox.Text))
                {
                    MessageBox.Show("Please Enter a valid EIIN \n EIIN must be numeric and 6 digits");
                    
                    UR_EIIN_textBox.Focus();
                    return;
                }
                if (!ValidationClass.validName(UR_name_textBox.Text))
                {
                    MessageBox.Show("Please Enter a valid Name \n Name can only contain letters and spaces");
                   
                    UR_name_textBox.Focus();
                    return;
                }

                if (!ValidationClass.validUniversity(UR_university_textBox.Text))
                {
                    MessageBox.Show("Please Enter a valid University Name \n University Name can only contain letters, spaces and hyphens");
                    
                    UR_university_textBox.Focus();
                    return;
                }

                if (!ValidationClass.validPassword(UR_pass_textBox.Text)) 
                {
                    MessageBox.Show("Password must be exactly 6 characters long and can contain only letters, digits, and underscores.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    UR_pass_textBox.Focus();
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
                        string insertUR =
                            "INSERT INTO URDetails (Name, Nationality, Gender, Email, UniversityName, EIIN, Password) " +
                            "VALUES (@Name, @Nationality, @Gender, @Email, @UniversityName, @EIIN, @Password)" +
                            "SELECT CAST(SCOPE_IDENTITY() AS INT);";
                        //('" + UR_name_textBox.Text + "', '" + UR_count_comboBox.Text + "', '" + UR_gender_comboBox.Text + "', '" + UR_email_textBox.Text + "', '" + UR_university_textBox.Text + "', '" + UR_EIIN_textBox.Text + "', '" + UR_pass_textBox.Text + "');
                        SqlCommand cmdUR = new SqlCommand(insertUR, con, tx);
                        
                        cmdUR.Parameters.AddWithValue("@Name", UR_name_textBox.Text);
                        cmdUR.Parameters.AddWithValue("@Nationality", UR_count_comboBox.Text);
                        cmdUR.Parameters.AddWithValue("@Gender", UR_gender_comboBox.Text);
                        cmdUR.Parameters.AddWithValue("@Email", UR_email_textBox.Text);
                        cmdUR.Parameters.AddWithValue("@UniversityName", UR_university_textBox.Text);
                        cmdUR.Parameters.AddWithValue("@EIIN", int.Parse(UR_EIIN_textBox.Text));
                        cmdUR.Parameters.AddWithValue("@Password", UR_pass_textBox.Text);

                        // capture new identity
                        int newId = Convert.ToInt32(cmdUR.ExecuteScalar());

                        // Optional: show captured ID on the form (if you want)


                        // === B) INSERT into LoginTable using captured ID ===
                        // Columns: ID, Name, Role, Password, Status(=0)
                        string insertLogin =
                            "INSERT INTO loginTable (ID, name, role, password, status) " +
                            "VALUES(@ID, @name, @role, @password, @status)";
                        //(" + newId + ", '" + UR_name_textBox.Text + "', 'UR', '" + UR_pass_textBox.Text + "', 0);
                        SqlCommand cmdLogin = new SqlCommand(insertLogin, con, tx);
                        cmdLogin.Parameters.AddWithValue("@ID", newId);
                        cmdLogin.Parameters.AddWithValue("@name", UR_name_textBox.Text);
                        cmdLogin.Parameters.AddWithValue("@role", "UR");
                        cmdLogin.Parameters.AddWithValue("@password", UR_pass_textBox.Text);
                        cmdLogin.Parameters.AddWithValue("@status", 0);
                        int resultLogin = cmdLogin.ExecuteNonQuery();

                        // 4) Both success → commit
                        tx.Commit();

                        if (resultLogin > 0)
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

        private void ClearButtonURReg_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                this.UR_name_textBox.Clear();
                this.UR_university_textBox.Clear();
                this.UR_email_textBox.Clear();
               
                this.UR_count_comboBox.Text = "";
                
                this.UR_gender_comboBox.Text = "";
                
                this.UR_EIIN_textBox.Clear();
                this.UR_pass_textBox.Clear();
               
                this.UR_name_textBox.Focus();
                
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;

            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }

        private void exitbuttonURreg_Click(object sender, EventArgs e)
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
            }
            con.Close();
        }

        private void BackbuttonURreg_Click(object sender, EventArgs e)
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

                con.Close();
            }
        }

        private void UR_EIIN_textBox_TextChanged(object sender, EventArgs e)
        {
            UR_EIIN_textBox.ForeColor = Color.Black;
            if (ValidationClass.validateEIIN(UR_EIIN_textBox.Text))
            {
                label6.Visible = true;
                label6.ForeColor = Color.Green;
                label6.Text = "EIIN must be numeric and 6 digits";
            }
            else 
            {
                label6.Visible = true;
                label6.ForeColor = Color.Red;
                label6.Text = "EIIN must be numeric and 6 digits";
            }
        }

        private void UR_email_textBox_TextChanged(object sender, EventArgs e)
        {
            UR_email_textBox.ForeColor = Color.Black;
            if (ValidationClass.IsValidEmail(UR_email_textBox.Text))
            {
                label2.Visible = true;
                label2.ForeColor = Color.Green;
                label2.Text = "email should be in a valid format(eg: abc@gmail.com)";
            }
            else
            {
                label2.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = "email should be in a valid format(eg: abc@gmnail.com)";
            }
        }

        private void UR_name_textBox_TextChanged(object sender, EventArgs e)
        {
           if (ValidationClass.validName(UR_name_textBox.Text))
           {
                label1.Visible = true;
                label1.ForeColor = Color.Green;
                label1.Text = "Name can only contain letters and spaces";
           }
           else 
           {
                label1.Visible = true;
                label1.ForeColor = Color.Red;
                label1.Text = "Name can only contain letters and spaces";
           }
        }

        private void UR_university_textBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidationClass.validUniversity(UR_university_textBox.Text))
            {
                label4.Visible = true;
                label4.ForeColor = Color.Green;
                label4.Text = "University Name can only contain letters, spaces and hyphens";
            }
            else 
            {
                label4.Visible = true;
                label4.ForeColor = Color.Red;
                label4.Text = "University Name can only contain letters, spaces and hyphens";
            }
        }

        private void UR_pass_textBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidationClass.validPassword(UR_pass_textBox.Text))
            {
                label5.Visible = true;
                label5.ForeColor = Color.Green;
                label5.Text = "Password must be exactly 6 characters long and can contain only letters, digits, and underscores.";
            }
            else 
            {
                label5.Visible = true;
                label5.ForeColor = Color.Red;
                label5.Text = "Password must be exactly 6 characters long and can contain only letters, digits, and underscores.";
            }
        }

        private void UR_name_textBox_Leave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void UR_email_textBox_Leave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void UR_count_comboBox_Leave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void UR_university_textBox_Leave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void UR_pass_textBox_Leave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void UR_EIIN_textBox_Leave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void UR_count_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidationClass.validName(UR_count_comboBox.Text))
            {
                label3.Visible = true;
                label3.ForeColor = Color.Green;
                label3.Text = "Country name can contain only letters and spaces";
            }
            else 
            {
                label3.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "Country name can contain only letters and spaces";
            }
        }
    }
}
