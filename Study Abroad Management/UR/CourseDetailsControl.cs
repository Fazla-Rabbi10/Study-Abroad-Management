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
    public partial class CourseDetailsControl : UserControl
    {
        DataAccess Da {  get; set; }
        public CourseDetailsControl()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        internal void PopulateGridView(string sql = "select * from URDashboard;")
        {
            try 
            { 
                dgvCourseDetails.EnableHeadersVisualStyles = false;
                dgvCourseDetails.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvCourseDetails.ColumnHeadersDefaultCellStyle.BackColor;
                dgvCourseDetails.AutoGenerateColumns = false;

                DataTable dt = Da.ExecuteQueryTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.dgvCourseDetails.DataSource = dt;
                    this.lblFoundIndicator.Visible = false;
                }
                else
                {
                    this.lblFoundIndicator.Visible  = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching course details. Please try again.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM URDashboard WHERE CourseCode = '" + this.txtCourseCode.Text + "'";

            this.PopulateGridView(sql);
        }

        private void txtCourseCode_TextChanged(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM URDashboard WHERE CourseCode LIKE '%{this.txtCourseCode.Text}%'";
            this.PopulateGridView(sql);
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //counter dite hobe

        //        string courseCode = this.dgvCourseDetails.SelectedCells[1].Value.ToString();
                
        //        var sql = $@"delete URDashboard where CourseCode = '{courseCode}';";


        //        var count = this.Da.ExecuteDMLQuery(sql);

        //        if (count != 1)
        //        {
        //            MessageBox.Show("Course can't delete", "Failled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return;
        //        }

        //        MessageBox.Show("Course has been deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.PopulateGridView();
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //    }
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string coursesName = this.dgvCourseDetails.SelectedCells[0].Value.ToString();
            string courseCode = this.dgvCourseDetails.SelectedCells[1].Value.ToString();
            string country = this.dgvCourseDetails.SelectedCells[3].Value.ToString();
            string courseDuration = this.dgvCourseDetails.SelectedCells[4].Value.ToString();
            string studyMode = this.dgvCourseDetails.SelectedCells[13].Value.ToString();
            string maxScholarship = this.dgvCourseDetails.SelectedCells[10].Value.ToString();
            string tutionFee = this.dgvCourseDetails.SelectedCells[9].Value.ToString();
            string intake = this.dgvCourseDetails.SelectedCells[11].Value.ToString();
            string deadline = this.dgvCourseDetails.SelectedCells[12].Value.ToString();
            string sat = this.dgvCourseDetails.SelectedCells[8].Value.ToString();
            string gre = this.dgvCourseDetails.SelectedCells[7].Value.ToString();
            string ielts = this.dgvCourseDetails.SelectedCells[6].Value.ToString();
            string degreeType = this.dgvCourseDetails.SelectedCells[5].Value.ToString();

           new FormCourseUpdate(coursesName, courseCode, degreeType, country, courseDuration, studyMode, maxScholarship, tutionFee, sat, ielts, gre, intake, deadline, this).ShowDialog();
        }
    }
}
