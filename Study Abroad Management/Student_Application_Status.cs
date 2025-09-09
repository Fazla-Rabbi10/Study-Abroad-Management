using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Abroad_Management
{
    public partial class Student_Application_Status: Form
    {
        public Student_Application_Status()
        {
            InitializeComponent();
        }

        private void Student_Application_Status_Load(object sender, EventArgs e)
        {
            string stduentName = GlobalData.LoggedInUserName;
            string studnetID = GlobalData.LoggedInUserID.ToString();
            app_Student_namelabel.Text = "Welcome, " + stduentName;
            aspp_StudentIDlabel.Text = "ID: " + studnetID;
        }
    }
}
