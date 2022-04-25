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
        protected void ChromeDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            Constant.Constant.WEBDRIVER = new ChromeDriver();
            Constant.Constant.WEBDRIVER.Manage().Window.Maximize();
        }

        protected String getCurrentTimeStamp()
        {
            DateTimeOffset now = DateTime.Now;
            long timeStamp = ((DateTimeOffset)now).ToUnixTimeSeconds(); ;
            return timeStamp.ToString();
        }
    }
}
