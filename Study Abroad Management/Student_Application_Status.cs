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
    public partial class Student_Application_Status: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-01OR5KU\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");

        private void FetchStudentApplications()
        {
            try
            {
                
               

               
                string query = "SELECT ApplicationStatus.ApplicationStatus, " +
                               "ApplicationStatus.CourseName, ApplicationStatus.CourseCode, " +
                               "ApplicationStatus.UniversityName, ApplicationStatus.Country, " +
                               "ApplicationStatus.CourseDuration, ApplicationStatus.DegreeType, " +
                               "ApplicationStatus.IELTS, ApplicationStatus.GRE, ApplicationStatus.SAT, " +
                               "ApplicationStatus.TutionFee, ApplicationStatus.MaxScholarship, " +
                               "ApplicationStatus.Intake, ApplicationStatus.ApplicationDeadline, " +
                               "ApplicationStatus.StudyMode, " +
                               "StudentDetails.ID " +   
                               "FROM ApplicationStatus " +
                               "INNER JOIN StudentDetails ON ApplicationStatus.StudentID = StudentDetails.ID " +
                               "WHERE ApplicationStatus.StudentID = @StudentID";


                
                
                
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentID", GlobalData.LoggedInUserID);  // Use the global logged-in user ID

                    // DataAdapter to fill DataTable
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    // Open connection and execute query
                    
                    sda.Fill(dt);

                    // Display fetched data in DataGridView (you can change this part to show data as needed)
                    if (dt.Rows.Count > 0)
                    {
                        apply_status_dataGridView.DataSource = dt;  // Bind data to DataGridView
                    }
                    else
                    {
                        MessageBox.Show("You did not apply for any course yet.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                
               


            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        public Student_Application_Status()
        {
            InitializeComponent();
        }

        private void Student_Application_Status_Load(object sender, EventArgs e)
        {
            string stduentName = GlobalData.LoggedInUserName;
            string studnetID = GlobalData.LoggedInUserID.ToString();
            app_Student_namelabel.Text = "Welcome, " + stduentName;
            aspp_StudentIDlabel.Text = "ID: " + studnetID;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                
                FetchStudentApplications();
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
            
        }

        private void refreshbutton1_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                
                FetchStudentApplications();
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }

        private void Closebutton2_Click(object sender, EventArgs e)
        {
            User_Student us = new User_Student();
            us.Show();
            this.Hide();
        }
    }
}
