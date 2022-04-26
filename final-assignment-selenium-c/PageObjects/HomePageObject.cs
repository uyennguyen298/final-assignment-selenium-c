using final_assignment_selenium_c.Common;
using final_assignment_selenium_c.DataObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.PageObjects
{
    public class HomePageObject : BasePage
    {
        private IWebDriver driver;
        public HomePageObject (IWebDriver driver)
        {
            this.driver = driver;
        }
        public AuthenticationPageObject openAuthenticatePage()
        {
            waitForElementClickable(driver, HomePageUI.SIGN_IN_LINK);
            clickToElement(driver, HomePageUI.SIGN_IN_LINK);
            return PageGeneratorManager.getAuthenticatePage(driver);
        }

    }
}
