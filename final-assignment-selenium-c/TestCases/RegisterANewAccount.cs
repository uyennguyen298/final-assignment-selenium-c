using AventStack.ExtentReports;
using ExtentReportTest.Utils.ReportUtil;
using final_assignment_selenium_c.Common;
using final_assignment_selenium_c.PageObjects;
using final_assignment_selenium_c.Utilities.ReportUtil;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace final_assignment_selenium_c.TestCases
{
    class RegisterANewAccount : BasePage
    {
        private IWebDriver driver;
        private HomePageObject homePage;
        private AuthenticationPageObject authenticationPage;
        private CreateAnAccountPageObject createAnAccountPage;
        private MyAccountPageObject myAccountPage;


        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(Constant.Constant.APP_URL);

        }
        [TearDown]
        public void TearDown()
        {
                driver.Quit();
        }

        public MediaEntityModelProvider CaptureScreenshot(string name)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, name).Build();
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
            createAnAccountPage.inputToAllFields();
            //6. Register page: Click on Register button
            myAccountPage = createAnAccountPage.clickToRegisterButton();
            //7. My Account page: Validate user is created
            Assert.IsTrue(myAccountPage.isMyAccountHeaderIsDisplayed());
        }

    }
}
