using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Study_Abroad_Management
{
    internal class ValidationClass
    {
        public static bool IsValidEmail(string email)
        {
            Regex emailregex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return emailregex.IsMatch(email);
            //took it from youtube
        }

        public static bool IsValidContactNumber(string contactNumber)
        {
            // Regex pattern for validating contact number (11 digits)
            Regex contactRegex = new Regex(@"^\d{11}$");
            return contactRegex.IsMatch(contactNumber);
        }
        public static bool validateEIIN(string eiin)
        {
            Regex eiinregex = new Regex(@"^\d{6}$");
            return eiinregex.IsMatch(eiin);

        }
        public static bool validAge(string age)
        {
            Regex regex = new Regex(@"^(1[89]|[2-9][0-9])$");
            return regex.IsMatch(age);
        }

        public static bool validName(string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z\s]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(name);
        }

        public static bool validUniversity(string university)
        {
            Regex regex = new Regex(@"^[a-zA-Z\s-]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(university);
        }

        public static bool validAddress(string address)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9\s,.-]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(address);
        }

        public static bool validPassword(String password) 
        {
            Regex passregex = new Regex(@"^[\w]{6}$", RegexOptions.IgnoreCase);

            return passregex.IsMatch(password);
        }
    }
}
