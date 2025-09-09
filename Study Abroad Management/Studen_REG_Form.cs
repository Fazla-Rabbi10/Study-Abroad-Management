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
    public partial class Studen_REG_Form: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-01OR5KU\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
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
                !string.IsNullOrWhiteSpace(std_count_textBox.Text) &&
                !string.IsNullOrWhiteSpace(std_gender_comboBox.Text) &&
                !string.IsNullOrWhiteSpace(std_pass_textBox.Text) &&
                !string.IsNullOrWhiteSpace(std_role_comboBox.Text))
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
                        string insertStudent =
                            "INSERT INTO StudentDetails (Name, Nationality, Gender, Email, Age, Password) " +
                            "VALUES ('" + std_name_textBox.Text + "','" + std_count_textBox.Text + "','" + std_gender_comboBox.Text + "','" + std_email_textBox.Text + "','" + stdage_textBox.Text + "','" + std_pass_textBox.Text + "'); " +
                            "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        SqlCommand cmdStudent = new SqlCommand(insertStudent, con, tx);
                        // capture new identity
                        int newId = Convert.ToInt32(cmdStudent.ExecuteScalar());

                        // Optional: show captured ID on the form (if you want)


                        // === B) INSERT into LoginTable using captured ID ===
                        // Columns: ID, Name, Role, Password, Status(=0)
                        string insertLogin =
                            "INSERT INTO loginTable (ID, name, role, password, status) " +
                            "VALUES (" + newId + ",'" + std_name_textBox.Text + "','" + std_role_comboBox.Text + "','" + std_pass_textBox.Text + "', 0);";

                        SqlCommand cmdLogin = new SqlCommand(insertLogin, con, tx);
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

        private void Std_backToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Std_exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void StudentclearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                this.std_name_textBox.Clear();
                this.stdage_textBox.Clear();
                this.std_email_textBox.Clear();
                this.std_count_textBox.Clear();
                this.std_gender_comboBox.Items.Clear();
                this.std_pass_textBox.Clear();
                this.std_role_comboBox.Items.Clear();
                this.std_name_textBox.Focus();
                this.std_gender_comboBox.Items.Add("Male");
                this.std_gender_comboBox.Items.Add("Female");
                this.std_role_comboBox.Items.Add("student");


            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }
    }
}
