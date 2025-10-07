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

namespace Study_Abroad_Management.UR
{
    public partial class FormCourseUpdate : Form
    {
        private DataAccess Da { get; set; }
        private CourseDetailsControl CdcRef { get; set; }
        public FormCourseUpdate(string courseName,
                                string courseCode,
                                string degreeType,
                                string country,
                                string courseDuration,
                                string studyMode,
                                string maxScholarship,
                                string tutionFee,
                                string sat,
                                string ielts,
                                string gre,
                                string intake,
                                string deadline,
                                CourseDetailsControl cdcRef)
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.CdcRef = cdcRef;

            // === Basic Info ===
            this.txtCourseName.Text = courseName;
            this.txtCourseCode.Text = courseCode;
            this.txtCourseDuration.Text = courseDuration;
            this.txtMaxScholarship.Text = maxScholarship;
            this.txtTutionFee.Text = tutionFee;

            // === ComboBox Selections ===
            SelectComboBoxItem(this.cmbCountry, country);
            SelectComboBoxItem(this.cmbDegreeType, degreeType);

            // === Study Mode Radio Buttons ===
            if (studyMode.Equals("On Campus", StringComparison.OrdinalIgnoreCase))
                this.rdOnCampus.Checked = true;
            else if (studyMode.Equals("Online", StringComparison.OrdinalIgnoreCase))
                this.rdOnline.Checked = true;
            else if (studyMode.Equals("Hybrid", StringComparison.OrdinalIgnoreCase))
                this.rdHybrid.Checked = true;

            // === SAT / GRE / IELTS ===
            if (!string.Equals(sat, "Not required", StringComparison.OrdinalIgnoreCase))
            {
                this.cbSAT.Checked = true;
                this.txtRequiredSAT.Text = sat;
            }

            if (!string.Equals(gre, "Not required", StringComparison.OrdinalIgnoreCase))
            {
                this.cbGRE.Checked = true;
                this.txtRequiredGRE.Text = gre;
            }

            if (!string.Equals(ielts, "Not required", StringComparison.OrdinalIgnoreCase))
            {
                this.cbIELTS.Checked = true;
                this.txtRequiredIELTS.Text = ielts;
            }

            // === Intake Split (Season + Year) ===
            string[] parts = intake.Split(' ');
            string intakeSeason = parts.Length > 0 ? parts[0] : "";
            string intakeYear = parts.Length > 1 ? parts[1] : "";

            SelectComboBoxItem(this.cmbIntakeSeason, intakeSeason);
            SelectComboBoxItem(this.cmbIntakeYear, intakeYear);

            // === Deadline ===
            if (DateTime.TryParse(deadline, out DateTime parsedDeadline))
            {
                this.dtpDeadline.Value = parsedDeadline;
            }
        }

        // === Helper Method for ComboBox Selection ===
        private void SelectComboBoxItem(ComboBox combo, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                combo.SelectedIndex = -1;
                return;
            }

            int index = combo.Items.Cast<object>()
                                   .Select((item, i) => new { Text = item.ToString(), Index = i })
                                   .Where(x => x.Text.Equals(value, StringComparison.OrdinalIgnoreCase))
                                   .Select(x => x.Index)
                                   .FirstOrDefault();

            combo.SelectedIndex = index >= 0 ? index : -1;
        }

        // === Validation ===
        private bool IsValidToUpdate()
        {
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

            if (this.cmbCountry.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a Country!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbCountry.Focus();
                return false;
            }

            if (this.cmbDegreeType.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a Degree Type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbDegreeType.Focus();
                return false;
            }

            if (this.cmbIntakeSeason.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select an Intake Season!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbIntakeSeason.Focus();
                return false;
            }

            if (this.cmbIntakeYear.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select an Intake Year!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbIntakeYear.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCourseDuration.Text))
            {
                MessageBox.Show("Course Duration cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseDuration.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTutionFee.Text))
            {
                MessageBox.Show("Tuition Fee cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTutionFee.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMaxScholarship.Text))
            {
                MessageBox.Show("Max Scholarship cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaxScholarship.Focus();
                return false;
            }

            if (!RequiredTextbox())
                return false;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!IsValidToUpdate())
                return;

            var intake = cmbIntakeSeason.Text + " " + cmbIntakeYear.Text;

            if (!cbGRE.Checked)
                this.txtRequiredGRE.Text = "Not required";
            if (!cbIELTS.Checked)
                this.txtRequiredIELTS.Text = "Not required";
            if (!cbSAT.Checked)
                this.txtRequiredSAT.Text = "Not required";

            try
            {
                string sql = @"UPDATE URDashboard
                               SET 
                                   CourseName = @CourseName,
                                   Country = @Country,
                                   CourseDuration = @CourseDuration,
                                   DegreeType = @DegreeType,
                                   IELTS = @IELTS,
                                   GRE = @GRE,
                                   SAT = @SAT,
                                   TutionFee = @TutionFee,
                                   MaxScholarship = @MaxScholarship,
                                   Intake = @Intake,
                                   ApplicationDeadline = @ApplicationDeadline,
                                   StudyMode = @StudyMode
                               WHERE CourseCode = @CourseCode;";

                string studyMode = rdOnCampus.Checked ? "On Campus" :
                                   rdOnline.Checked ? "Online" :
                                   rdHybrid.Checked ? "Hybrid" : "Not Selected";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@CourseName", txtCourseName.Text),
                    new SqlParameter("@CourseCode", txtCourseCode.Text),
                    new SqlParameter("@Country", cmbCountry.Text),
                    new SqlParameter("@CourseDuration", txtCourseDuration.Text),
                    new SqlParameter("@DegreeType", cmbDegreeType.Text),
                    new SqlParameter("@IELTS", txtRequiredIELTS.Text),
                    new SqlParameter("@GRE", txtRequiredGRE.Text),
                    new SqlParameter("@SAT", txtRequiredSAT.Text),
                    new SqlParameter("@TutionFee", txtTutionFee.Text),
                    new SqlParameter("@MaxScholarship", txtMaxScholarship.Text),
                    new SqlParameter("@Intake", intake),
                    new SqlParameter("@ApplicationDeadline", dtpDeadline.Value),
                    new SqlParameter("@StudyMode", studyMode)
                };

                int count = this.Da.ExecuteDMLQuery(sql, parameters);
                if (count == 1)
                {
                    MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.CdcRef.PopulateGridView();
                }
                else
                {
                    MessageBox.Show("Update Failed! Please check again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void cbSAT_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRequiredSAT.Enabled = cbSAT.Checked;
            if (!cbSAT.Checked) txtRequiredSAT.Clear();
        }

        private void cbIELTS_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRequiredIELTS.Enabled = cbIELTS.Checked;
            if (!cbIELTS.Checked) txtRequiredIELTS.Clear();
        }

        private void cbGRE_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRequiredGRE.Enabled = cbGRE.Checked;
            if (!cbGRE.Checked) txtRequiredGRE.Clear();
        }
    }
}
