using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.PageObjects
{
    public class AuthenticationPageObject : BasePage
    {
        private IWebDriver driver;
        public AuthenticationPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}
