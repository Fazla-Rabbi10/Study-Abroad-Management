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
    public partial class Forget_Password : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void Clear123button_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                en_ID_textBox.Clear();
                new_pass_textBox.Clear();
                en_ID_textBox.Focus();
                label2.Visible = false;
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(en_ID_textBox.Text)
                && !String.IsNullOrWhiteSpace(new_pass_textBox.Text)
                && !String.IsNullOrEmpty(en_ID_textBox.Text)
                && !String.IsNullOrEmpty(new_pass_textBox.Text))
            {
                if (!ValidationClass.validPassword(new_pass_textBox.Text))
                {
                    MessageBox.Show("Password must be exactly 6 characters long and can contain only letters, digits, and underscores.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    new_pass_textBox.Focus();
                    return;
                }
                try
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        string update_query = "update loginTable set password = @newpass where ID = @id";
                        SqlCommand cmd = new SqlCommand(update_query, con);
                        cmd.Parameters.AddWithValue("@newpass", new_pass_textBox.Text);
                        cmd.Parameters.AddWithValue("@id", int.Parse(en_ID_textBox.Text));
                        int result = cmd.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("Password Updated Successfully");
                            Log_In_Form lif = new Log_In_Form();
                            lif.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error: ID not found");
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
                    MessageBox.Show("Password Update Failed: " + ex.Message + " ID must be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please Fill up all the fields");
            }
        }

        private void Back_button1_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                Log_In_Form lif = new Log_In_Form();
                lif.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }

        private void Exit_button2_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            if (con.State == ConnectionState.Open)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) 
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

        private void new_pass_textBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidationClass.validPassword(new_pass_textBox.Text)) 
            {
                label2.Visible = true;
                label2.ForeColor = Color.Green;
                label2.Text = "Password must be exactly 6 characters long and can contain only letters, digits, and underscores.";
            }
            else
            {
                label2.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = "Password must be exactly 6 characters long and can contain only letters, digits, and underscores.";
            }
        }

        private void new_pass_textBox_Leave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}
