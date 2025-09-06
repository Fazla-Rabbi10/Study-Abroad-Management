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
    public partial class Log_In_Form: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-01OR5KU\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        public Log_In_Form()
        {
            InitializeComponent();
        }

        private void Sign_Up_button_Click(object sender, EventArgs e)
        {
            this.Admin_button.Visible = true;
            this.UR_button.Visible = true;
            this.Student_button.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult drr = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            con.Open();
           if (con.State == ConnectionState.Open)
            {
                if (drr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            con.Close();
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            Admin_REG_Form arf = new Admin_REG_Form();
            arf.Show();
            this.Hide();
        }

        private void UR_button_Click(object sender, EventArgs e)
        {
            UR_REG_Formcs urf = new UR_REG_Formcs();
            urf.Show();
            this.Hide();
        }

        private void Student_button_Click(object sender, EventArgs e)
        {
            Studen_REG_Form srf = new Studen_REG_Form();
            srf.Show();
            this.Hide();
        }

        private void Lof_in_button_Click(object sender, EventArgs e)
        {
            string log_query = "select * from loginTable where ID = '" + LG_ID_textBox.Text + "'and password = '" + Lg_Password_textBox2.Text + "'";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(log_query, con);

            if (con.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    if (dt.Rows[0][4].ToString() == "1")
                    {
                        if (dt.Rows[0][2].ToString() == "admin")
                        {
                            MessageBox.Show("Login Successful");
                            Admin_Pannel a = new Admin_Pannel();
                            a.Show();
                            this.Hide();
                        }
                        else if (dt.Rows[0][2].ToString() == "UR")
                        {
                            MessageBox.Show("Login Successful");
                            new University_Representative().Show();
                            this.Hide();
                        }
                        else if (dt.Rows[0][2].ToString() == "student")
                        {
                            MessageBox.Show("Login Successful");
                            new User_Student().Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Account Inactive wait for admin to active your account");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password");
                }
            }

        }
    }
}
