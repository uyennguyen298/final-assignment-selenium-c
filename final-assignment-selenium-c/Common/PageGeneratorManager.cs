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

        public static HomePageObject getHomePage(IWebDriver driver)
        {
            return new HomePageObject(driver);
        }

        public static CreateAnAccountPageObject getCreateAnAccountPage(IWebDriver driver)
        {
            return new CreateAnAccountPageObject(driver);
        }
    }
}
