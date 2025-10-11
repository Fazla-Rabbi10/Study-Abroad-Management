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
    public partial class ApplicationControl : UserControl
    {
        private DataAccess Da { get; set; }
        internal int URID { get; set; }

        public ApplicationControl(int uRID)
        {
            InitializeComponent();

            URID = uRID;
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        internal void PopulateGridView(string sql = "")
        {
            if (string.IsNullOrEmpty(sql))
            {
                sql = $@"SELECT a.* 
                         FROM ApplicationStatus a
                         INNER JOIN URDashboard d
                         ON a.CourseCode = d.CourseCode
                         WHERE d.URID = {this.URID};";

            }
            try
            {
                dgvApplicationStatus.EnableHeadersVisualStyles = false;
                dgvApplicationStatus.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvApplicationStatus.ColumnHeadersDefaultCellStyle.BackColor;
                dgvApplicationStatus.AutoGenerateColumns = false;

                DataTable dt = Da.ExecuteQueryTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvApplicationStatus.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching application details. Please try again.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            UpdateApplicationStatus("Accepted");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateApplicationStatus("Rejected");
        }

        private void UpdateApplicationStatus(string newStatus)
        {
            try
            {
                if (dgvApplicationStatus.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an application first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var selectedRow = dgvApplicationStatus.SelectedRows[0];
                var id = selectedRow.Cells[15].Value;
                var courseCode = selectedRow.Cells[2].Value;
                var currentStatus = selectedRow.Cells[0].Value.ToString();

                if (currentStatus != "Pending")
                {
                    MessageBox.Show($"Application already {currentStatus}", "Application Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string sql = $@"UPDATE ApplicationStatus
                                SET ApplicationStatus = '{newStatus}'
                                WHERE StudentId = {id} AND CourseCode = '{courseCode}';";

                int count = Da.ExecuteDMLQuery(sql);

                if (count > 0)
                {
                    MessageBox.Show($"Application {newStatus}", newStatus, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(this.dgvApplicationStatus.SelectedRows[0].Cells[16].Value.ToString());

            new FormStudentDetails(id).ShowDialog(); 
        }
    }
}
