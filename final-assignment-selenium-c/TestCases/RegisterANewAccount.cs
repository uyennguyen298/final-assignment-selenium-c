using final_assignment_selenium_c.Common;
using final_assignment_selenium_c.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.TestCases
{
    class RegisterANewAccount : BaseTest
    {
        private IWebDriver driver;
        private HomePageObject homePage;
        private AuthenticationPageObject authenticationPage;
        private CreateAnAccountPageObject createAnAccountPage;

        [SetUp]
        public void SetUp()
        {
            ChromeDriver();
           
    }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void SC01_RegisterANewAccount()
        {
            //1. Home page: Open this URL
            homePage = PageGeneratorManager.getHomePage(driver);
            //2. Home page: Click on Sign in Link
            authenticationPage = homePage.openAuthenticatePage();
            //3. Authenticate page: Input Email
            authenticationPage.inputToEmailAddressTextbox(Utilities.TestData.emailAddress);
            //4. Authenticate page: Click on Create an account button
            createAnAccountPage = authenticationPage.clickToCreateAnAccountButton();
            //5. Register page: Enter information
            createAnAccountPage.selectTitleCheckbox();
            createAnAccountPage.inputToFirstNameTextbox(Utilities.TestData.firstName);
            createAnAccountPage.inputToLastNameTextbox(Utilities.TestData.lastName);
            createAnAccountPage.inputToEmailAddressTextbox(Utilities.TestData.emailAddress);
            createAnAccountPage.inputToPasswordTextbox(Utilities.TestData.password);
            createAnAccountPage.selectDateDropdownlist(Utilities.TestData.dob_date);
            createAnAccountPage.selectMonthDropdownlist(Utilities.TestData.dob_month);
            createAnAccountPage.selectYearDropdownlist(Utilities.TestData.dob_year);
            createAnAccountPage.selectSignUpCheckbox();
            createAnAccountPage.selectReceiveSpecialOffersCheckbox();
            createAnAccountPage.inputToCompanyTextbox(Utilities.TestData.company);
            createAnAccountPage.inputToAddressTextbox(Utilities.TestData.address);
            createAnAccountPage.inputToAddressLine2Textbox(Utilities.TestData.addressLine2);
            createAnAccountPage.inputToCityTextbox(Utilities.TestData.city);
            createAnAccountPage.selectStateDropdownlist(Utilities.TestData.state);
            createAnAccountPage.inputToZipPostalCodeTextbox(Utilities.TestData.zipPostalCode);
            createAnAccountPage.selectCountryDropdownlist(Utilities.TestData.country);
            createAnAccountPage.inputToAdditionalInformationTextbox(Utilities.TestData.additionalInformation);
            createAnAccountPage.inputToHomePhoneTextbox(Utilities.TestData.homePhone);
            createAnAccountPage.inputToMobilePhoneTextbox(Utilities.TestData.mobilePhone);
            createAnAccountPage.inputToAssignAnAddressTextbox(Utilities.TestData.assignAnAddress);
            //6. Register page: Click on Register button
            createAnAccountPage.clickToRegisterButton();
            //7. My Account page: Validate user is created

        }
    }
}
