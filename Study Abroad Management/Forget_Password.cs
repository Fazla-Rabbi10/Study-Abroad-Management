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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-01OR5KU\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
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
                    MessageBox.Show("Error: ",ex.Message, MessageBoxButtons.OK,MessageBoxIcon.Error);
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
    }
}
