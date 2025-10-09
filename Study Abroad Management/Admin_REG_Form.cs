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

                if (!ValidationClass.validPassword(Ad_pass_textBox.Text))
                {
                    MessageBox.Show("Password must be exactly 6 characters long and can contain only letters, digits, and underscores.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Ad_pass_textBox.Focus();
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
                this.ad_count_comboBox.Text = "";
                this.ad_gender_comboBox.Items.Clear();
                this.contact_textBox.Clear();
                this.Ad_pass_textBox.Clear();

                this.ad_name_textBox.Focus();

                this.ad_gender_comboBox.Items.Add("Male");
                this.ad_gender_comboBox.Items.Add("Female");
                
              


                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label7.Visible = false;





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

            if (!ValidationClass.IsValidEmail(ad_email_textBox.Text))
            {
                label4.Visible = true;
                label4.ForeColor = Color.Red;
                label4.Text = "email should follow a valid format(eg; abc@gmail.com)";
            }
            else 
            {
                label4.Visible = true;
                label4.ForeColor = Color.Green;
                label4.Text = "email should follow a valid format(eg; abc@gmail.com)";
            }

        }

        private void Ad_pass_textBox_Leave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void Ad_pass_textBox_TextChanged(object sender, EventArgs e)
        {
           if (!ValidationClass.validPassword(Ad_pass_textBox.Text))
            {
                label2.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = "Password must be exactly 6 characters long and can contain only letters, digits, and underscores.";
            }
            else
            {
                label2.Visible = true;
                label2.ForeColor = Color.Green;
                label2.Text = "Password must be exactly 6 characters long and can contain only letters, digits, and underscores.";
            }
        }

        private void ad_name_textBox_Leave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void ad_name_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationClass.validName(ad_name_textBox.Text))
            {
                label1.Visible = true;
                label1.ForeColor = Color.Red;
                label1.Text = "Name can contain only letters and spaces";
            }
            else
            {
                label1.Visible = true;
                label1.ForeColor = Color.Green;
                label1.Text = "Name can contain only letters and spaces";
            }
        }

        private void ad_email_textBox_Leave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void Ad_Address_textBox_Leave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void Ad_Address_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationClass.validAddress(Ad_Address_textBox.Text))
            {
                label3.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "Address can contain only letters, numbers, spaces, commas, periods, and hyphens";
            }
            else
            {
                label3.Visible = true;
                label3.ForeColor = Color.Green;
                label3.Text = "Address can contain only letters, numbers, spaces, commas, periods, and hyphens";
            }
        }

        private void ad_count_comboBox_Leave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void contact_textBox_Leave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void contact_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationClass.IsValidContactNumber(contact_textBox.Text)) 
            {
                label7.Visible = true;
                label7.ForeColor = Color.Red;
                label7.Text = "Contact number should be 11 digits";
            }
            else 
            {
                label7.Visible = true;
                label7.ForeColor = Color.Green;
                label7.Text = "Contact number should be 11 digits";
            }

        }

        private void ad_count_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationClass.validName(ad_count_comboBox.Text))
            {
                label5.Visible = true;
                label5.ForeColor = Color.Red;
                label5.Text = "Country name can contain only letters and spaces";
            }
            else 
            {
                label5.Visible = true;
                label5.ForeColor = Color.Green;
                label5.Text = "Country name can contain only letters and spaces";
            }
        }
    }
}
