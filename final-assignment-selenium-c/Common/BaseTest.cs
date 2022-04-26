using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace final_assignment_selenium_c.Common
{
    public class BaseTest
    {
        private IWebDriver driver;
        public void ChromeDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(Constant.Constant.APP_URL);
        }
        public static string getCurrentTimeStamp()
        {
            DateTimeOffset now = DateTime.Now;
            long timeStamp = ((DateTimeOffset)now).ToUnixTimeSeconds(); ;
            return timeStamp.ToString();
        }
    }
}
