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
        private int URID {  get; set; }
        private string IELTS { get; set; }
        private string GRE { get; set; }
        private string SAT { get; set; }
        private string UniversityName { get; set; }
        private string Intake {  get; set; }

        public AddNewCourseControl(int urID)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.URID = urID;
            this.RetrieveUserInfo();
            this.cmbIntakeSeason.SelectedIndex = 0;
            this.cmbIntakeYear.SelectedIndex = 0;
            this.cmbDegreeType.SelectedIndex = 0;
            this.cmbCountry.SelectedIndex = 0;
            this.lblURID.Text = urID.ToString();
            
        }

        private void RetrieveUserInfo()
        {
            var sql = $"select UniversityName from URDetails where ID = {this.URID};";

            try
            {
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.UniversityName = ds.Tables[0].Rows[0][0].ToString();
                    this.lblUni.Text = UniversityName;
                }
                else
                {
                    MessageBox.Show("No record found for this ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving user info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (this.cmbCountry.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a country!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbCountry.Focus();
                return false;
            }
            if (this.cmbDegreeType.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a Degree!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbDegreeType.Focus();
                return false;
            }
            if (this.cmbIntakeSeason.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a semester!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbIntakeSeason.Focus();
                return false;
            }
            if (this.cmbIntakeYear.SelectedIndex == 0)
            {
                MessageBox.Show("Please select an Intake Year!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbIntakeSeason.Focus();
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
            
            if (string.IsNullOrWhiteSpace(dtpDeadline.Text))
            {
                MessageBox.Show("Application Deadline cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDeadline.Focus();
                return false;
            }

            if(this.RequiredTextbox() == false)
            {
                return false;
            }
            return true;
        }


        private bool RequiredTextbox()
        {
            if (cbGRE.Checked && string.IsNullOrWhiteSpace(txtRequiredGRE.Text))
            {
                MessageBox.Show("GRE is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequiredGRE.Focus();
                return false;
            }

            if (cbSAT.Checked && string.IsNullOrWhiteSpace(txtRequiredSAT.Text))
            {
                MessageBox.Show("SAT is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequiredSAT.Focus();
                return false;
            }

            if (cbIELTS.Checked && string.IsNullOrWhiteSpace(txtRequiredIELTS.Text))
            {
                MessageBox.Show("IELTS is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequiredIELTS.Focus();
                return false;
            }

            return true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!IsValidToAdd())
                return;

            this.Intake = cmbIntakeSeason.Text + " " +  cmbIntakeYear.Text;

            if(!cbGRE.Checked)
            {
                this.txtRequiredGRE.Text = "Not required";
            }
            if (!cbIELTS.Checked)
            {
                this.txtRequiredIELTS.Text = "Not required";
            }
            if (!cbSAT.Checked)
            {
                this.txtRequiredSAT.Text = "Not required";
            }

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
                    new SqlParameter("@UniversityName", this.UniversityName),
                    new SqlParameter("@Country", this.cmbCountry.Text),
                    new SqlParameter("@CourseDuration", this.txtCourseDuration.Text),
                    new SqlParameter("@DegreeType", this.cmbDegreeType.Text),
                    new SqlParameter("@IELTS", this.txtRequiredIELTS.Text),
                    new SqlParameter("@GRE", this.txtRequiredGRE.Text),
                    new SqlParameter("@SAT", this.txtRequiredSAT.Text),
                    new SqlParameter("@TutionFee", this.txtTutionFee.Text),
                    new SqlParameter("@MaxScholarship", this.txtMaxScholarship.Text),
                    new SqlParameter("@Intake", this.Intake),
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
            this.txtCourseName.Clear();
            this.txtCourseCode.Clear();
            this.txtCourseDuration.Clear();
            this.txtRequiredIELTS.Clear();
            this.txtRequiredGRE.Clear();
            this.txtRequiredSAT.Clear();
            this.txtTutionFee.Clear();
            this.txtMaxScholarship.Clear();

            // ComboBox reset
            this.cmbCountry.SelectedIndex = 0;
            this.cmbIntakeSeason.SelectedIndex = 0;
            this.cmbIntakeYear.SelectedIndex = 0;
            this.cmbDegreeType.SelectedIndex = 0;

            // DateTimePicker reset (optional: current date)
            this.dtpDeadline.Value = DateTime.Now;

            // Optional: focus first field
            this.txtCourseName.Focus();

            // Checkbox reset
            this.cbGRE.Checked = false;
            this.cbIELTS.Checked = false;
            this.cbIELTS.Checked = false;
        }

        private void cbSAT_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRequiredSAT.Enabled = cbSAT.Checked;
            if(!cbSAT.Checked ) txtRequiredSAT.Clear();
        }

        private void cbIELTS_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRequiredIELTS.Enabled = cbIELTS.Checked;
            if (!cbIELTS.Checked) txtRequiredIELTS.Clear();
        }


        private void cbGRE_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRequiredGRE.Enabled = this.cbGRE.Checked;
            if(!this.cbGRE.Checked) this.txtRequiredGRE.Clear();
        }

        private void txtCourseCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string input = this.txtCourseCode.Text.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    this.lblCourseCodeValidator.Visible = false;
                    return;
                }

                var sql = "Select CourseCode from URDashboard;";
                var data = this.Da.ExecuteQueryTable(sql);

                bool found = false;

                if (data.Rows.Count > 0)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        string dbCode = data.Rows[i]["CourseCode"].ToString();

                        if (dbCode.Equals(input, StringComparison.OrdinalIgnoreCase))
                        {
                            found = true;
                            break;
                        }
                    }
                }

                this.lblCourseCodeValidator.Visible = true;

                if (found)
                {
                    this.lblCourseCodeValidator.Text = "Course code already exists";
                    this.lblCourseCodeValidator.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    this.lblCourseCodeValidator.Text = "Valid course code";
                    this.lblCourseCodeValidator.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}

