using SectB_Question2;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace HomeAffairsDigitalIdentityProcessor
{
    public class CitizenProfile
    {
        private string FullName;
        private long IDNumber;
        private int Age;
        private string CitizenshipStatus;
        private bool IsIDValid;

        public CitizenProfile(string name, long idNumber, string citizenshipStatus)
        {
            this.FullName = name;
            this.IDNumber = idNumber;
            this.CitizenshipStatus = citizenshipStatus;

            this.Age = CalculateAgeFromId(idNumber);
        }

        public void SetIdValidation(bool isValid)
        {
            this.IsIDValid = isValid;
        }

        public static int CalculateAgeFromId(long idNumber)
        {
            string idString = idNumber.ToString().PadLeft(13, '0');

            int yearShort = int.Parse(idString.Substring(0, 2));
            int month = int.Parse(idString.Substring(2, 2));
            int day = int.Parse(idString.Substring(4, 2));

            int currentYear = DateTime.Now.Year;
            int currentYearShort = currentYear % 100;

            int fullYear = (yearShort <= currentYearShort) ? 2000 + yearShort : 1900 + yearShort;

            DateTime birthDate = new DateTime(fullYear, month, day);
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            if (today < birthDate.AddYears(age))
            {
                age--;
            }

            return age;
        }

        public static bool ValidateID(long idNumber)
        {
            if (idNumber.ToString().Length != 13)
            {
                return false;
            }

            return true;
        }

        public string DisplayProfile()
        {
            if (IsIDValid == false)
            {
                return "Cannot display profile, ID is invalid";
            }

            return $"===== DIGITAL CITIZEN SUMMARY =====\nName: {this.FullName}\nID Number: {this.IDNumber}\nAge: {this.Age}\nCitizenship: {this.CitizenshipStatus}\nValidation: Valid ID. Citizen is {this.Age} years old.\nProcessed at: Home Affairs Digital Desk\nTimestamp: {DateTime.Now}";
        }
    }
}