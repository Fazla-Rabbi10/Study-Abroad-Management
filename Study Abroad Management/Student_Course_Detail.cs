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
    public partial class Student_Course_Detail : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True");
        public Student_Course_Detail()
        {
            InitializeComponent();
        }

        private void Student_Course_Detail_Load(object sender, EventArgs e)
        {
     
           
            CourseNamelabel.Text = CourseNamelabel.Text +" " + User_Student.courseName.ToString();
           
            CourseCodelabel.Text = CourseCodelabel.Text + " " + User_Student.courseCode.ToString();
           
            Universitynamelabel.Text = Universitynamelabel.Text + " " + User_Student.universityName.ToString();
           
            Countrylabel.Text = Countrylabel.Text + " " + User_Student.country.ToString();
           
            CourseDurationlabel.Text = CourseDurationlabel.Text + " " + User_Student.courseDuration.ToString();
           
            DegreeTypelabel.Text = DegreeTypelabel.Text + " " + User_Student.degreeType.ToString();
           
            IELTSlabel.Text = IELTSlabel.Text + " " + User_Student.ielts.ToString();
           
            GRElabel.Text = GRElabel.Text + " " + User_Student.gre.ToString();
           
            SATlabel.Text = SATlabel.Text + " " + User_Student.sat.ToString();
           
            TutionFeelabel.Text = TutionFeelabel.Text + " " + User_Student.tutionFee.ToString();
           
            MaxScholarshiplabel.Text = MaxScholarshiplabel.Text + " " + User_Student.maxScholarship.ToString();
           
            Intakelabel.Text = Intakelabel.Text + " " + User_Student.intake.ToString();
           
            ApplicationDeadlinelabel.Text = ApplicationDeadlinelabel.Text + " " + User_Student.applicationDeadline.ToString();
            
            StudyModelabel14.Text = StudyModelabel14.Text + " " + User_Student.studyMode.ToString();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            User_Student student = new User_Student();
            this.Hide();
            student.Show();
            student.__Show();

        }
    }
}
