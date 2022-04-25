using NPOI.Util;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace final_assignment_selenium_c.Common
{
    public class BasePage
    {
        private long longTimeout = 30;
		private By getByLocator(String locatorType)
		{
			By by = null;
			if (locatorType.StartsWith("id=") || locatorType.StartsWith("ID=") || locatorType.StartsWith("Id="))
			{
				by = By.Id(locatorType.Substring(3));
			}
			else if (locatorType.StartsWith("class=") || locatorType.StartsWith("CLASS=") || locatorType.StartsWith("Class="))
			{
				by = By.ClassName(locatorType.Substring(6));
			}
			else if (locatorType.StartsWith("name=") || locatorType.StartsWith("NAME=") || locatorType.StartsWith("Name="))
			{
				by = By.Name(locatorType.Substring(5));
			}
			else if (locatorType.StartsWith("css=") || locatorType.StartsWith("CSS=") || locatorType.StartsWith("Css="))
			{
				by = By.CssSelector(locatorType.Substring(4));
			}
			else if (locatorType.StartsWith("xpath=") || locatorType.StartsWith("XPATH=") || locatorType.StartsWith("Xpath="))
			{
				by = By.XPath(locatorType.Substring(6));
			}
			else
			{
				throw new RuntimeException("Locator type is not supported!");
			}
			return by;
		}

		public void waitForElementClickable(IWebDriver driver, String locatorType)
        {
            WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
            explicitWait.Until(ExpectedConditions.ElementToBeClickable(getByLocator(locatorType)));
        }

		public IWebElement getWebElement(IWebDriver driver, String locatorType)
		{
			return driver.FindElement(getByLocator(locatorType));

		}

		public void clickToElement(IWebDriver driver, String locatorType)
		{
			getWebElement(driver, locatorType).Click();
		}


	}
}
