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
    public class AuthenticationPageObject : BasePage
    {
        private IWebDriver driver;
        public AuthenticationPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void inputToEmailAddressTextbox(String emailAddress)
        {
            waitForElementVisible(driver, AuthenticationPageUI.EMAIL_ADDRESS_TEXT_BOX);
            sendkeyToElement(driver, AuthenticationPageUI.EMAIL_ADDRESS_TEXT_BOX, emailAddress);
        }

        public CreateAnAccountPageObject clickToCreateAnAccountButton()
        {
            waitForElementClickable(driver, AuthenticationPageUI.CREATE_AN_ACCOUNT_BUTTON);
            clickToElement(driver, AuthenticationPageUI.CREATE_AN_ACCOUNT_BUTTON);
            return PageGeneratorManager.getCreateAnAccountPage(driver);
        }
    }
}
