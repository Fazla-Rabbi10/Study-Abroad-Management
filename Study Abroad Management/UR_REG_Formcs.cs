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
    public partial class UR_REG_Formcs: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-01OR5KU\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
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
                !string.IsNullOrWhiteSpace(UR_count_textBox.Text) &&
                !string.IsNullOrWhiteSpace(UR_gender_comboBox.Text) &&
                !string.IsNullOrWhiteSpace(UR_EIIN_textBox.Text) &&
                !string.IsNullOrWhiteSpace(UR_pass_textBox.Text) &&
                !string.IsNullOrWhiteSpace(UR_role_comboBox.Text))
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
                        string insertUR =
                            "INSERT INTO URDetails (Name, Nationality, Gender, Email, UniversityName, EIIN, Password) " +
                            "VALUES ('" + UR_name_textBox.Text + "','" + UR_count_textBox.Text + "','" + UR_gender_comboBox.Text + "','" + UR_email_textBox.Text + "','" + UR_university_textBox.Text + "','" + UR_EIIN_textBox.Text + "','" + UR_pass_textBox.Text + "'); " +
                            "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        SqlCommand cmdUR = new SqlCommand(insertUR, con, tx);
                        // capture new identity
                        int newId = Convert.ToInt32(cmdUR.ExecuteScalar());

                        // Optional: show captured ID on the form (if you want)


                        // === B) INSERT into LoginTable using captured ID ===
                        // Columns: ID, Name, Role, Password, Status(=0)
                        string insertLogin =
                            "INSERT INTO loginTable (ID, name, role, password, status) " +
                            "VALUES (" + newId + ",'" + UR_name_textBox.Text + "','" + UR_role_comboBox.Text + "','" + UR_pass_textBox.Text + "', 0);";

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

        private void URclearToolStripMenuItem_Click(object sender, EventArgs e)
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
                this.UR_count_textBox.Clear();
                this.UR_gender_comboBox.Items.Clear();
                this.UR_EIIN_textBox.Clear();
                this.UR_pass_textBox.Clear();
                this.UR_role_comboBox.Items.Clear();
                this.UR_name_textBox.Focus();
                this.UR_role_comboBox.Items.Add("UR");
                this.UR_gender_comboBox.Items.Add("Male");
                this.UR_gender_comboBox.Items.Add("Female");


            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }

        private void UR_backToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void UR_exitToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
