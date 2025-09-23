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
        DataAccess Da;
        public CourseDetailsControl()
        {
            InitializeComponent();
            Da = new DataAccess();
        }

        internal void PopulateGridView()
        {
            dgvCourseDetails.EnableHeadersVisualStyles = false;
            dgvCourseDetails.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvCourseDetails.ColumnHeadersDefaultCellStyle.BackColor;
            dgvCourseDetails.AutoGenerateColumns = false;

            string sql = "select * from ApplicationStatus";
            Da.ExecuteQueryTable(sql);

            //if (Da.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //{
            //    dgvCourseDetails.DataSource = ds.Tables[0];
            //}
            //else
            //{
            //    dgvCourseDetails.DataSource = null;
            //}
        }
    }
}
