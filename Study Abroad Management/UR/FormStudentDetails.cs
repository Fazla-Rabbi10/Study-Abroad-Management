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
    public partial class FormStudentDetails : Form
    {
        private int ID { get; set; }
        private DataAccess Da {  get; set; }

        public FormStudentDetails(int id)
        {
            InitializeComponent();
            this.ID = id;
            this.lblID.Text = id.ToString();
            this.Da = new DataAccess(); 
            this.FetchData();
        }

        private void FetchData()
        {
            try
            {
                var sql = $@"select * from StudentDetails where ID = {this.ID};";

                var dataTable = this.Da.ExecuteQueryTable(sql);

                if(dataTable != null  && dataTable.Rows.Count > 0)
                {
                    this.lblName.Text = dataTable.Rows[0][1].ToString();
                    this.lblNationality.Text = dataTable.Rows[0][2].ToString();
                    this.lblGender.Text = dataTable.Rows[0]["Gender"].ToString();
                    this.lblEmail.Text = dataTable.Rows[0]["Email"].ToString();
                    this.lblAge.Text = dataTable.Rows[0]["Age"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error Fetching Data: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
