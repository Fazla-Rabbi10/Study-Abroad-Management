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

        private void AddUserControl(UserControl control)
        {
            pnlContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(control);
        }

        private void btnAddnewcourse_Click(object sender, EventArgs e)
        {
            AddNewCourseControl addNewCourseControl = new AddNewCourseControl();
            this.AddUserControl(addNewCourseControl);
        }

        private void btnCourseDetails_Click(object sender, EventArgs e)
        {
            CourseDetailsControl courseDetailsControl = new CourseDetailsControl();
            this.AddUserControl(courseDetailsControl);
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            ApplicationControl applicationControl = new ApplicationControl();
            this.AddUserControl(applicationControl);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
        }
    }
}
