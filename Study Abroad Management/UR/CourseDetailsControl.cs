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

        private void PopulateGridView(string sql = "select * from URDashboard;")
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

    }
}
