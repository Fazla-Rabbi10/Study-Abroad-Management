using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Abroad_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //###Just comment or uncomment the line below to run the desired form###
            
            //Application.Run(new Admin_Pannel());
            //Application.Run(new UR_Management());
<<<<<<<<< Temporary merge branch 1
            Application.Run(new User_Management());
            //Application.Run(new Log_In_Form());
            
=========
            Application.Run(new Study_Abroad_Management.UR.UniversityRepresentative());
            //Application.Run(new Log_In_Form());
>>>>>>>>> Temporary merge branch 2
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        //Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);
        //Application.Run(new Admin_Pannel());
        //}

        
    }
}
