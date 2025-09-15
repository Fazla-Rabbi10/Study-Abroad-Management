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
    public partial class Admin_REG_Form: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-01OR5KU\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
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
                !string.IsNullOrWhiteSpace(ad_count_textBox.Text) &&
                !string.IsNullOrWhiteSpace(ad_gender_comboBox.Text) &&
                !string.IsNullOrWhiteSpace(contact_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Ad_pass_textBox.Text) 
                )
            {
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
                            "VALUES ('" + ad_name_textBox.Text + "','" + Ad_Address_textBox.Text + "','" + ad_email_textBox.Text + "','" + ad_count_textBox.Text + "','" + ad_gender_comboBox.Text + "','" + contact_textBox.Text + "','" + Ad_pass_textBox.Text + "'); " +
                            "SELECT CAST(SCOPE_IDENTITY() AS INT);";
                        
                        SqlCommand cmdAdmin = new SqlCommand(insertAdmin, con, tx);
                        // capture new identity
                        int newId = Convert.ToInt32(cmdAdmin.ExecuteScalar());

                        // Optional: show captured ID on the form (if you want)
                        

                        // === B) INSERT into LoginTable using captured ID ===
                        // Columns: ID, Name, Role, Password, Status(=0)
                        string insertLogin =
                            "INSERT INTO loginTable (ID, name, role, password, status) " +
                            "VALUES (" + newId + ",'" + ad_name_textBox.Text + "','admin','" + Ad_pass_textBox.Text + "', 0);";

                        SqlCommand cmdLogin = new SqlCommand(insertLogin, con, tx);
                        int resultLogin = cmdLogin.ExecuteNonQuery();

                        // 4) Both success → commit
                        tx.Commit();

                        if (resultLogin > 0)
                        {
                            MessageBox.Show("Sign Up Successful");
                            DialogResult drr = MessageBox.Show("This is Your ID For Log In : "+newId.ToString() +"\n Please Remeber Your ID", "Your ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Admin_backToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Admin_exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AdminclearToolStripMenuItem_Click(object sender, EventArgs e)
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
                this.ad_count_textBox.Clear();
                this.ad_gender_comboBox.Items.Clear();
                this.contact_textBox.Clear();
                this.Ad_pass_textBox.Clear();
                
                this.ad_name_textBox.Focus();
               
                this.ad_gender_comboBox.Items.Add("Male");
                this.ad_gender_comboBox.Items.Add("Female");


            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }














        //{
        //    string insert_query = "insert into AdminDetails values('" + ad_name_textBox.Text + "','" + Ad_Address_textBox.Text + "','" + ad_email_textBox.Text + "','"+ad_count_textBox.Text+"','"+ad_gender_comboBox.Text+"','"+contact_textBox.Text+ "','"+Ad_pass_textBox.Text+"')";
        //    SqlCommand cmd = new SqlCommand(insert_query, con);
        //    con.Open();
        //    if (con.State == ConnectionState.Open)
        //    {

        //        if (!string.IsNullOrWhiteSpace(ad_name_textBox.Text) &&
        //            !string.IsNullOrWhiteSpace(Ad_Address_textBox.Text) &&
        //            !string.IsNullOrWhiteSpace(ad_email_textBox.Text) && 
        //            !string.IsNullOrWhiteSpace(ad_count_textBox.Text) &&
        //            !string.IsNullOrWhiteSpace(ad_gender_comboBox.Text)&&
        //            !string.IsNullOrWhiteSpace(contact_textBox.Text)&&
        //            !string.IsNullOrWhiteSpace(Ad_pass_textBox.Text)&&
        //            !string.IsNullOrWhiteSpace(ad_ID_textBox.Text)&&
        //            !string.IsNullOrWhiteSpace(ad_role_comboBox.Text))
        //        {
        //            int result = cmd.ExecuteNonQuery();

        //            if (result > 0)
        //            {
        //                MessageBox.Show("Sign Up Successful");
        //                Log_In_Form log = new Log_In_Form();
        //                log.Show();
        //                this.Hide();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Sign Up Failed");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please Fill all the fields");
        //        }


        //    }
        //    else
        //    {
        //        MessageBox.Show("Connection Failed");
        //    }
        //    con.Close();
        //}
    }
}
