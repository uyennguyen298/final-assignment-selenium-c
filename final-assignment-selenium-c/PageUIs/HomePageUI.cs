using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.DataObjects
{
    public class HomePageUI
    {
        public static string SIGN_IN_LINK = "xpath=//a[@class='login']";
        public static string WOMEN_LINK = "xpath=//a[@title='{0}']";
        public static string TSHIRTS_SUBMENU = "xpath=//a[@title='{0}']//..//a[@title='{1}']//..//a[@title='{2}']";
    }
}
