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
        internal int URID {get; set;}
        internal DataAccess Da { get; set;}
        internal Log_In_Form LogInRef { get; set;}

        public UniversityRepresentative(int urID, Log_In_Form logInRef)
        {
            InitializeComponent();
            this.URID = urID;
            this.Da = new DataAccess();
            this.RetrieveUserName();
            this.LogInRef = logInRef;
        }

        private void RetrieveUserName()
        {
            var sql = $"select Name from URDetails where ID = {this.URID};";

            try
            {
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.lblUserName.Text = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving user Name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUserControl(UserControl control)
        {
            pnlContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(control);
        }

        private void btnAddnewcourse_Click(object sender, EventArgs e)
        {
            AddNewCourseControl addNewCourseControl = new AddNewCourseControl(this.URID);
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
            this.LogInRef.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
        }
    }
}
