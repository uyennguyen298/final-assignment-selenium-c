using final_assignment_selenium_c.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.Utilities
{
    public class TestData : BasePage
    {
        public static string emailAddress = "uyentesting" + getCurrentTimeStamp() + "@gmail.com";
        public static string firstName = "uyen";
        public static string lastName = "nguyen";
        //public static string emailAddress = "uyentesting" + getCurrentTimeStamp() + "@gmail.com";
        public static string password = "1234567";
        public static string dob_date = "29";
        public static string dob_month = "August";
        public static string dob_year = "1997";
        public static string company = "Kido Corporation";
        public static string address = "TPHCM";
        public static string addressLine2 = "TPHCM";
        public static string city = "Vietnam";
        public static string state = "Ohio";
        public static string country = "United States";
        public static string zipPostalCode = "00000";
        public static string additionalInformation = "Testing 001";
        public static string homePhone = "0142536789";
        public static string mobilePhone = "037536987";
        public static string assignAnAddress = "Dalat";
    }
}

