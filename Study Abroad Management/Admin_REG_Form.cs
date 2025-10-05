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
    public partial class Admin_REG_Form: Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        public Admin_REG_Form()
        {
            InitializeComponent();
        }

       

        private void admin_submit_button_Click(object sender, EventArgs e)
           
        {
            // 1) Basic validation (ID check removed)
            if (!string.IsNullOrWhiteSpace(ad_name_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Ad_Address_textBox.Text) &&
                !string.IsNullOrWhiteSpace(ad_email_textBox.Text) &&
                !string.IsNullOrWhiteSpace(ad_count_comboBox.Text) &&
                !string.IsNullOrWhiteSpace(ad_gender_comboBox.Text) &&
                !string.IsNullOrWhiteSpace(contact_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Ad_pass_textBox.Text) 
                )
            {
                if (!ValidationClass.IsValidEmail(ad_email_textBox.Text))
                {
                    MessageBox.Show("Please enter a valid email address.\n For Example: abc@gmail.com");
                    ad_email_textBox.Focus();
                    return;
                }

                if (ad_email_textBox.Text == "abc@gmail.com" || ad_email_textBox.Text == "ABC@GMAIL.COM") 
                {
                    ad_email_textBox.Text.ToLower();
                    MessageBox.Show("Please enter a valid email address. You cannot use abc@gmail.com");
                    ad_email_textBox.Focus();
                    return;
                }

                if (!ValidationClass.IsValidContactNumber(contact_textBox.Text))
                {
                    MessageBox.Show("Please enter a valid contact number (11 digits).");
                    contact_textBox.Focus();
                    return;
                }

                if (!ValidationClass.validName(ad_name_textBox.Text)) 
                {
                    MessageBox.Show("Please enter a valid name (letters and spaces only).");
                    ad_name_textBox.Focus();
                    return;
                }

                if (!ValidationClass.validAddress(Ad_Address_textBox.Text))
                {
                    MessageBox.Show("Please enter a valid address (letters, numbers, spaces, commas, periods, and hyphens only).");
                    Ad_Address_textBox.Focus();
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
                        string insertAdmin =
                            "INSERT INTO AdminDetails (Name, Address, Email, Country, Gender, ContactNumber, Password) " +
                            "VALUES (@Name, @Address, @Email, @Country, @Gender, @ContactNumber, @Password); " +
                            "SELECT CAST(SCOPE_IDENTITY() AS INT);";
                        
                        SqlCommand cmdAdmin = new SqlCommand(insertAdmin, con, tx);

                        cmdAdmin.Parameters.AddWithValue("@Name", ad_name_textBox.Text);
                        cmdAdmin.Parameters.AddWithValue("@Address", Ad_Address_textBox.Text);
                        cmdAdmin.Parameters.AddWithValue("@Email", ad_email_textBox.Text);
                        cmdAdmin.Parameters.AddWithValue("@Country", ad_count_comboBox.Text);
                        cmdAdmin.Parameters.AddWithValue("@Gender", ad_gender_comboBox.Text);
                        cmdAdmin.Parameters.AddWithValue("@ContactNumber", contact_textBox.Text);
                        cmdAdmin.Parameters.AddWithValue("@Password", Ad_pass_textBox.Text);

                        // capture new identity
                        int newId = Convert.ToInt32(cmdAdmin.ExecuteScalar());

                        // Optional: show captured ID on the form (if you want)
                        

                        // === B) INSERT into LoginTable using captured ID ===
                        // Columns: ID, Name, Role, Password, Status(=0)
                        string insertLogin =
                            "INSERT INTO loginTable (ID, name, role, password, status) " +
                            "VALUES (@ID, @Name, @Role, @Password, @Status);";

                        SqlCommand cmdLogin = new SqlCommand(insertLogin, con, tx);
                        
                        cmdLogin.Parameters.AddWithValue("@ID", newId);
                        cmdLogin.Parameters.AddWithValue("@Name", ad_name_textBox.Text);
                        cmdLogin.Parameters.AddWithValue("@Role", "admin");
                        cmdLogin.Parameters.AddWithValue("@Password", Ad_pass_textBox.Text);
                        cmdLogin.Parameters.AddWithValue("@Status", 1);
                        
                        int resultLogin = cmdLogin.ExecuteNonQuery();

                        // 4) Both success → commit
                        tx.Commit();

                        if (resultLogin > 0)
                        {
                            MessageBox.Show("Sign Up Successful");
                            DialogResult drr = MessageBox.Show("This is Your ID For Log In : "+newId.ToString() +"\n Please Remember Your ID", "Your ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Admin_REG_Form_Load(object sender, EventArgs e)
        {

        }

        private void BackbuttonAdminreg_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                Admin_Management am = new Admin_Management();
                am.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Connection Failed");

                con.Close();
            }
        }

        private void exitbuttonAdminreg_Click(object sender, EventArgs e)
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

        private void ClearButtonAdminReg_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                this.ad_name_textBox.Clear();
                this.Ad_Address_textBox.Clear();
                this.ad_email_textBox.Clear();
                this.ad_count_comboBox.Items.Clear();
                this.ad_gender_comboBox.Items.Clear();
                this.contact_textBox.Clear();
                this.Ad_pass_textBox.Clear();

                this.ad_name_textBox.Focus();

                this.ad_gender_comboBox.Items.Add("Male");
                this.ad_gender_comboBox.Items.Add("Female");
                
                this.ad_count_comboBox.Items.Add("United States");
                this.ad_count_comboBox.Items.Add("India");
                this.ad_count_comboBox.Items.Add("Canada");
                this.ad_count_comboBox.Items.Add("Australia");
                this.ad_count_comboBox.Items.Add("Bangladesh");  
                this.ad_count_comboBox.Items.Add("United Kingdom");  
                this.ad_count_comboBox.Items.Add("Japan");
                this.ad_count_comboBox.Items.Add("Germany");
                this.ad_count_comboBox.Items.Add("Brazil");
                this.ad_count_comboBox.Items.Add("France");
                this.ad_count_comboBox.Items.Add("Italy");
                this.ad_count_comboBox.Items.Add("Russia");
                this.ad_count_comboBox.Items.Add("China");
                this.ad_count_comboBox.Items.Add("Mexico");
                this.ad_count_comboBox.Items.Add("South Korea");
                this.ad_count_comboBox.Items.Add("Spain");
                this.ad_count_comboBox.Items.Add("Saudi Arabia");
                this.ad_count_comboBox.Items.Add("Argentina");
                this.ad_count_comboBox.Items.Add("South Africa");
                this.ad_count_comboBox.Items.Add("Egypt");




            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }

        private void ad_email_textBox_TextChanged(object sender, EventArgs e)
        {

            ad_email_textBox.ForeColor = Color.Black;
            
        }
    }
}
