using final_assignment_selenium_c.Common;
using final_assignment_selenium_c.PageUIs;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.PageObjects
{
    public class MyAccountPageObject : BasePage
    {
        private IWebDriver driver;
        public MyAccountPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
        public bool isMyAccountHeaderIsDisplayed()
        {
            waitForElementVisible(driver, MyAccountPageUI.MY_ACCOUNT_LABEL);
            return isElementDisplayed(driver, MyAccountPageUI.MY_ACCOUNT_LABEL);
        }
    }
}
