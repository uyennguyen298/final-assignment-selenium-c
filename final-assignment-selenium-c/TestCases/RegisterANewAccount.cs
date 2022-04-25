using final_assignment_selenium_c.Common;
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

        [SetUp]
        public void SetUp()
        {
            ChromeDriver();
        }
        [TearDown]
        public void TearDown()
        {
            Constant.Constant.WEBDRIVER.Quit();
        }

        [Test]
        public void RegisterANewAccount()
        {

        }
    }
}
