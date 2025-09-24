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
    public partial class FormCourseUpdate : Form
    {

        private string CourseCode { get; set; }
        public FormCourseUpdate()
        {
            InitializeComponent();
        }

        public FormCourseUpdate(string courseCode)
        {
            InitializeComponent();
            this.CourseCode = courseCode;
        }

        private void FetchData()
        {
            try
            {
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
