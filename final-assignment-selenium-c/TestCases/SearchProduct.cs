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
    public class SearchProduct
    {
        private IWebDriver driver;
        private HomePageObject homePage;
        private TshirtPageObject tshirtPage;
        private SearchPageObject searchPage;

        [OneTimeSetUp]
        public void GlobalSetup()
        {
            ExtentTestManager.CreateParentTest(GetType().Name);
        }

        [OneTimeTearDown]
        public void GlobalTeardown()
        {
            ExtentService.GetExtent().Flush();
        }

        [SetUp]
        public void SetUp()
        {
            ExtentTestManager.CreateTest(TestContext.CurrentContext.Test.Name);
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
            try
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var errorMessage = string.IsNullOrEmpty(TestContext.CurrentContext.Result.Message)
                    ? ""
                    : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.Message);

                var stackTrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                    ? ""
                    : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.StackTrace);

                switch (status)
                {
                    case TestStatus.Failed:
                        ReportLog.Fail("Test Failed");
                        ReportLog.Fail(errorMessage);
                        ReportLog.Fail(stackTrace);
                        ReportLog.Fail("Screenshot", CaptureScreenshot(TestContext.CurrentContext.Test.Name));
                        break;

                    case TestStatus.Skipped:
                        ReportLog.Skip("Test Skipped");
                        break;
                    case TestStatus.Passed:
                        ReportLog.Pass("Test Passed");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Exception:" + e);
            }
            driver.Quit();
        }
        public MediaEntityModelProvider CaptureScreenshot(string name)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, name).Build();
        }

        [Test]
        public void SC02_SearchProduct()
        {
            //1. Home page: Open this URL
            homePage = PageGeneratorManager.getHomePage(driver);
            //2. Home page: Move your cursor over Women's link
            homePage.hoverOnWomanLink();
            //3. Home page: Click on submenu 'T-shirts'
            tshirtPage = homePage.clickToTshirtSubMenu();
            //4. T-shirts page: Get name/text the first product displayed on the page
            //5. T-shirts page: Enter name into search bar & click on Search button
            string expectedProductName = tshirtPage.getNameOfProduct();
            tshirtPage.inputToSearchTextbox(expectedProductName);
            searchPage = tshirtPage.clickToSearchButton();
            //6. Search page: Verify name + price
            Assert.AreEqual(expectedProductName, "xx");
        }
    }
}
