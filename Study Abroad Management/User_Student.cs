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
    public partial class User_Student : Form
    {
        string CourseName;
        string CourseCode;
        string UniversityName;
        string Country;
        string CourseDuration;
        string DegreeType;
        string IELTS;
        string GRE;
        string SAT;
        string TutionFee;
        string MaxScholarship;
        string Intake;
        string ApplicationDeadline;
        string StudyMode;


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-01OR5KU\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        public User_Student()
        {
            InitializeComponent();
        }

        private void User_Std_backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                Log_In_Form logg = new Log_In_Form();
                logg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }

        }

        private void User_Std_exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void User_StudentclearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                user_Studnet_search_textBox.Clear();
                user_Studnet_search_textBox.Focus();
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }

        private void User_Student_Load(object sender, EventArgs e)
        {
            string stduentName = GlobalData.LoggedInUserName;
            string studnetID = GlobalData.LoggedInUserID.ToString();
            Studentlabel.Text = "Welcome, " + stduentName;
            StudentIDlabel.Text = "ID: " + studnetID;
        }

        private void Student_Show_button_Click(object sender, EventArgs e)
        {
            try
            {
                string coursequery = "SELECT CourseName, CourseCode, UniversityName, Country," +
                " CourseDuration, DegreeType, IELTS, GRE, SAT, TutionFee, MaxScholarship, " +
                "Intake, ApplicationDeadline, StudyMode FROM URDashboard";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(coursequery, con);
                if (con.State == ConnectionState.Open)
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for_apply_dataGridView.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Connection Failed");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void user_Studnet_search_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchequery = "SELECT CourseName, CourseCode, UniversityName, Country," +
                " CourseDuration, DegreeType, IELTS, GRE, SAT, TutionFee, MaxScholarship, " +
                "Intake, ApplicationDeadline, StudyMode FROM URDashboard " +
                "where CourseName like  '%"+ user_Studnet_search_textBox.Text+"%'";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(searchequery, con);
                if (con.State == ConnectionState.Open)
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for_apply_dataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Connection Failed");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void for_apply_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                if (con.State == ConnectionState.Open)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = for_apply_dataGridView.Rows[e.RowIndex];
                        CourseName = row.Cells["CourseName"].Value.ToString();
                        CourseCode = row.Cells["CourseCode"].Value.ToString();
                        UniversityName = row.Cells["UniversityName"].Value.ToString();
                        Country = row.Cells["Country"].Value.ToString();
                        CourseDuration = row.Cells["CourseDuration"].Value.ToString();
                        DegreeType = row.Cells["DegreeType"].Value.ToString();
                        IELTS = row.Cells["IELTS"].Value.ToString();
                        GRE = row.Cells["GRE"].Value.ToString();
                        SAT = row.Cells["SAT"].Value.ToString();
                        TutionFee = row.Cells["TutionFee"].Value.ToString();
                        MaxScholarship = row.Cells["MaxScholarship"].Value.ToString();
                        Intake = row.Cells["Intake"].Value.ToString();
                        ApplicationDeadline = row.Cells["ApplicationDeadline"].Value.ToString();
                        StudyMode = row.Cells["StudyMode"].Value.ToString();

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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            
        }

        private void student_apply_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CourseName) &&
         !string.IsNullOrWhiteSpace(CourseCode) &&
         !string.IsNullOrWhiteSpace(UniversityName) &&
         !string.IsNullOrWhiteSpace(Country) &&
         !string.IsNullOrWhiteSpace(CourseDuration) &&
         !string.IsNullOrWhiteSpace(DegreeType) &&
         !string.IsNullOrWhiteSpace(IELTS) &&
         !string.IsNullOrWhiteSpace(GRE) &&
         !string.IsNullOrWhiteSpace(SAT) &&
         !string.IsNullOrWhiteSpace(TutionFee) &&
         !string.IsNullOrWhiteSpace(MaxScholarship) &&
         !string.IsNullOrWhiteSpace(Intake) &&
         !string.IsNullOrWhiteSpace(ApplicationDeadline) &&
         !string.IsNullOrWhiteSpace(StudyMode) &&
         //for safety
         !string.IsNullOrEmpty(CourseName) &&
         !string.IsNullOrEmpty(CourseCode) &&
         !string.IsNullOrEmpty(UniversityName) &&
         !string.IsNullOrEmpty(Country) &&
         !string.IsNullOrEmpty(CourseDuration) &&
         !string.IsNullOrEmpty(DegreeType) &&
         !string.IsNullOrEmpty(IELTS) &&
         !string.IsNullOrEmpty(GRE) &&
         !string.IsNullOrEmpty(SAT) &&
         !string.IsNullOrEmpty(TutionFee) &&
         !string.IsNullOrEmpty(MaxScholarship) &&
         !string.IsNullOrEmpty(Intake) &&
         !string.IsNullOrEmpty(ApplicationDeadline) &&
         !string.IsNullOrEmpty(StudyMode))
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        string insertApply = "INSERT INTO ApplicationStatus (ApplicationStatus, CourseName, CourseCode, UniversityName, Country," +
                        " CourseDuration, DegreeType, IELTS, GRE, SAT, TutionFee, MaxScholarship, Intake, ApplicationDeadline, StudyMode, StudentID)" +
                        " VALUES ('Pending', @CourseName, @CourseCode, @UniversityName," +
                        " @Country, @CourseDuration, @DegreeType, @IELTS, @GRE, @SAT, @TutionFee, @MaxScholarship, @Intake, @ApplicationDeadline, @StudyMode, @StudentID);";

                        SqlCommand cmdApply = new SqlCommand(insertApply, con);

                        // Add parameters to avoid SQL injection and special characters issues
                        cmdApply.Parameters.AddWithValue("@CourseName", CourseName);
                        cmdApply.Parameters.AddWithValue("@CourseCode", CourseCode);
                        cmdApply.Parameters.AddWithValue("@UniversityName", UniversityName);
                        cmdApply.Parameters.AddWithValue("@Country", Country);
                        cmdApply.Parameters.AddWithValue("@CourseDuration", CourseDuration);
                        cmdApply.Parameters.AddWithValue("@DegreeType", DegreeType);
                        cmdApply.Parameters.AddWithValue("@IELTS", IELTS);
                        cmdApply.Parameters.AddWithValue("@GRE", GRE);
                        cmdApply.Parameters.AddWithValue("@SAT", SAT);
                        cmdApply.Parameters.AddWithValue("@TutionFee", TutionFee);
                        cmdApply.Parameters.AddWithValue("@MaxScholarship", MaxScholarship);
                        cmdApply.Parameters.AddWithValue("@Intake", Intake);
                        cmdApply.Parameters.AddWithValue("@ApplicationDeadline", ApplicationDeadline);
                        cmdApply.Parameters.AddWithValue("@StudyMode", StudyMode);
                        cmdApply.Parameters.AddWithValue("@StudentID", GlobalData.LoggedInUserID);

                        // Execute the query
                        int resultApply = cmdApply.ExecuteNonQuery();

                        if (resultApply > 0)
                        {
                            MessageBox.Show("Application Submitted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Application Submission Failed");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Connection Failed");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a course from the list before applying.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void applyINFO_button_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            if (con.State == ConnectionState.Open)
            {
                Student_Application_Status studentApplicationStatus = new Student_Application_Status();
                studentApplicationStatus.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Connection Failed");
                con.Close();
            }
        }
    }
}
