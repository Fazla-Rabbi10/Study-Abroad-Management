using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Abroad_Management.UR
{
    public partial class AddNewCourseControl : UserControl
    {
        private DataAccess Da { get; set; }
        private int? URID {  get; set; }
        private string IELTS { get; set; }
        private string GRE { get; set; }
        private string SAT { get; set; }
        public AddNewCourseControl()
        {
            InitializeComponent();
            Da = new DataAccess();
            this.URID = 2; // It has assumed for temporary

            this.IELTS = cbIELTS.Checked ? txtRequiredIELTS.Text : "N/A";
            this.GRE = cbGRE.Checked ? txtRequiredGRE.Text : "N/A";
            this.IELTS = cbSAT.Checked ? txtRequiredSAT.Text : "N/A";


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private bool IsValidToAdd()
        {
            // Form fields check
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Course Name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCourseCode.Text))
            {
                MessageBox.Show("Course Code cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseCode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUniversity.Text))
            {
                MessageBox.Show("University Name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUniversity.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Country cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCountry.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCourseDuration.Text))
            {
                MessageBox.Show("Course Duration cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseDuration.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbDegreeType.Text))
            {
                MessageBox.Show("Please choose a Degree!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDegreeType.Focus();
                return false;
            }
            if (cbIELTS.Checked && string.IsNullOrWhiteSpace(txtRequiredIELTS.Text))
            {
                MessageBox.Show("IELTS is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequiredIELTS.Focus();
                return false;
            }
            if (cbGRE.Checked && string.IsNullOrWhiteSpace(txtRequiredGRE.Text))
            {
                MessageBox.Show("GRE is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequiredGRE.Focus();
                return false;
            }
            if (cbSAT.Checked && string.IsNullOrWhiteSpace(txtRequiredSAT.Text)) 
            {
                MessageBox.Show("SAT required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequiredSAT.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTutionFee.Text))
            {
                MessageBox.Show("Tution Fee cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTutionFee.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaxScholarship.Text))
            {
                MessageBox.Show("Max Scholarship cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaxScholarship.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtIntake.Text))
            {
                MessageBox.Show("Intake cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIntake.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtpDeadline.Text))
            {
                MessageBox.Show("Application Deadline cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDeadline.Focus();
                return false;
            }
            if (this.URID == null)
            {
                MessageBox.Show("URID not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!IsValidToAdd())
                return;
            
            try
            {
                string sql = @"INSERT INTO URDashboard VALUES
                                    (
                                        @CourseName,
                                        @CourseCode,
                                        @UniversityName,
                                        @Country,
                                        @CourseDuration,
                                        @DegreeType,
                                        @IELTS,
                                        @GRE,
                                        @SAT,
                                        @TutionFee,
                                        @MaxScholarship,
                                        @Intake,
                                        @ApplicationDeadline,
                                        @StudyMode,
                                        @URID
                                    );";

                string studyMode = string.Empty;

                switch (true)
                {
                    case bool _ when this.rdOnCampus.Checked:
                        studyMode = "On Campus";
                        break;

                    case bool _ when this.rdOnline.Checked:
                        studyMode = "Online";
                        break;

                    case bool _ when this.rdHybrid.Checked:
                        studyMode = "Hybrid";
                        break;

                    default:
                        studyMode = "Not Selected";
                        break;
                }


                SqlParameter[] addCourseParams = new SqlParameter[]
                {
                    new SqlParameter("@CourseName", this.txtCourseName.Text),
                    new SqlParameter("@CourseCode", this.txtCourseCode.Text),
                    new SqlParameter("@UniversityName", this.txtUniversity.Text),
                    new SqlParameter("@Country", this.txtCountry.Text),
                    new SqlParameter("@CourseDuration", this.txtCourseDuration.Text),
                    new SqlParameter("@DegreeType", this.cmbDegreeType.Text),
                    new SqlParameter("@IELTS", this.txtRequiredIELTS.Text),
                    new SqlParameter("@GRE", this.txtRequiredGRE.Text),
                    new SqlParameter("@SAT", this.txtRequiredSAT.Text),
                    new SqlParameter("@TutionFee", this.txtTutionFee.Text),
                    new SqlParameter("@MaxScholarship", this.txtMaxScholarship.Text),
                    new SqlParameter("@Intake", this.txtIntake.Text),
                    new SqlParameter("@ApplicationDeadline", this.dtpDeadline.Text),
                    new SqlParameter("@StudyMode", studyMode),
                    new SqlParameter("@URID", this.URID)
                };

                int count = this.Da.ExecuteDMLQuery(sql, addCourseParams);
                if (count != 1)
                {
                    MessageBox.Show("Course Not Added!", "Failled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Course Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearForm();

            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Database Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            // TextBoxes clear
            txtCourseName.Clear();
            txtCourseCode.Clear();
            txtUniversity.Clear();
            txtCountry.Clear();
            txtCourseDuration.Clear();
            txtRequiredIELTS.Clear();
            txtRequiredGRE.Clear();
            txtRequiredSAT.Clear();
            txtTutionFee.Clear();
            txtMaxScholarship.Clear();
            txtIntake.Clear();

            // ComboBox reset
            cmbDegreeType.SelectedIndex = -1;

            // DateTimePicker reset (optional: current date)
            dtpDeadline.Value = DateTime.Now;

            // Optional: focus first field
            txtCourseName.Focus();
        }

    }
}

