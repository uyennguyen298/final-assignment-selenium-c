using final_assignment_selenium_c.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.Common
{
    public class PageGeneratorManager
    {
        public static AuthenticationPageObject getAuthenticatePage(IWebDriver driver)
        {
            return new AuthenticationPageObject(driver);
        }
    }
}
