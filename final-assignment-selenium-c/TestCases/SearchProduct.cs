using final_assignment_selenium_c.Common;
using final_assignment_selenium_c.PageObjects;
using NUnit.Framework;
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
            string nameOfProduct = tshirtPage.getNameOfProduct();
            tshirtPage.inputToSearchTextbox(nameOfProduct);
            searchPage = tshirtPage.clickToSearchButton();
            //6. Search page: Verify name + price
            Assert.AreEqual(nameOfProduct, tshirtPage.getNameOfProduct());
        }
    }
}
