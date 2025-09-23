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

        private void lblAddNewCourse_Click(object sender, EventArgs e)
        {
                AddNewCourseControl anc = new AddNewCourseControl();
                AddUserControl(anc);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCourseDetails_Click(object sender, EventArgs e)
        {
            CourseDetailsControl cdc = new CourseDetailsControl();
            AddUserControl(cdc);
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            ApplicationsControl applicationsControl = new ApplicationsControl();
            AddUserControl(applicationsControl);
        }
    }
}
