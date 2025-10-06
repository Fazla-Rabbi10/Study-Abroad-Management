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
                this.UR_count_comboBox.Items.Clear();
                this.UR_gender_comboBox.Items.Clear();
                this.UR_EIIN_textBox.Clear();
                this.UR_pass_textBox.Clear();
               
                this.UR_name_textBox.Focus();
                
                
                
                this.UR_gender_comboBox.Items.Add("Male");
                this.UR_gender_comboBox.Items.Add("Female");


                this.UR_count_comboBox.Items.Add("United States");
                this.UR_count_comboBox.Items.Add("India");
                this.UR_count_comboBox.Items.Add("Canada");
                this.UR_count_comboBox.Items.Add("Australia");
                this.UR_count_comboBox.Items.Add("Bangladesh");
                this.UR_count_comboBox.Items.Add("United Kingdom");
                this.UR_count_comboBox.Items.Add("Japan");
                this.UR_count_comboBox.Items.Add("Germany");
                this.UR_count_comboBox.Items.Add("Brazil");
                this.UR_count_comboBox.Items.Add("France");
                this.UR_count_comboBox.Items.Add("Italy");
                this.UR_count_comboBox.Items.Add("Russia");
                this.UR_count_comboBox.Items.Add("China");
                this.UR_count_comboBox.Items.Add("Mexico");
                this.UR_count_comboBox.Items.Add("South Korea");
                this.UR_count_comboBox.Items.Add("Spain");
                this.UR_count_comboBox.Items.Add("Saudi Arabia");
                this.UR_count_comboBox.Items.Add("Argentina");
                this.UR_count_comboBox.Items.Add("South Africa");
                this.UR_count_comboBox.Items.Add("Egypt");

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

        private void UR_REG_Formcs_Load(object sender, EventArgs e)
        {
            UR_email_textBox.ForeColor = Color.Black;
        }

        private void UR_EIIN_textBox_TextChanged(object sender, EventArgs e)
        {
            UR_EIIN_textBox.ForeColor = Color.Black;
        }
    }
}
