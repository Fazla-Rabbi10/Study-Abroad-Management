using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Abroad_Management.UR
{
    public partial class UniversityRepresentative : Form
    {
        public UniversityRepresentative()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void UniversityRepresentative_Load(object sender, EventArgs e)
        {

        }

        private void addnewcoursebtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddNewCourseControl addNewCourseControl = new AddNewCourseControl();
            addNewCourseControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(addNewCourseControl);
        }

        private void coursedetailsbtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CourseDetailsControl courseDetailsControl = new CourseDetailsControl();
            courseDetailsControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(courseDetailsControl);
        }

        private void applicationbtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ApplicationControl applicationControl = new ApplicationControl();
            applicationControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(applicationControl);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
