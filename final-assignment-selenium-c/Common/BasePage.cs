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
		private By getByLocator(string locatorType)
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

		public void waitForElementClickable(IWebDriver driver, string locatorType)
        {
            WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
            explicitWait.Until(ExpectedConditions.ElementToBeClickable(getByLocator(locatorType)));
        }

		public void waitForElementClickable(IWebDriver driver, string locatorType,string dynamicValues)
		{
			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			explicitWait.Until(ExpectedConditions.ElementToBeClickable(getByLocator(getDynamicXpath(locatorType, dynamicValues))));
		}

		public IWebElement getWebElement(IWebDriver driver, string locatorType)
		{
			return driver.FindElement(getByLocator(locatorType));
		}

		public void clickToElement(IWebDriver driver, string locatorType)
		{
			getWebElement(driver, locatorType).Click();
		}
		public void waitForElementVisible(IWebDriver driver, string locatorType)
		{
			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			explicitWait.Until(ExpectedConditions.ElementIsVisible(getByLocator(locatorType)));
		}
		public string getElementText(IWebDriver driver, string locatorType)
		{
			
			return getWebElement(driver, locatorType).Text;
		}
		public void sendkeyToElement(IWebDriver driver, string locatorType, string textValue)
		{
			IWebElement element = getWebElement(driver, locatorType);
			element.Clear();
			element.SendKeys(textValue);
		}

		public void selectItemInDropdown(IWebDriver driver, string parentXpath, string childXpath, string expectedItem)
		{
            clickToElement(driver, parentXpath);

            WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
            IList<IWebElement> allItems = explicitWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(getByLocator(childXpath)));


            foreach (var item in allItems)
            {
                if (item.Text.Trim().Equals(expectedItem))
                {
                    if (item.Displayed == true)
                    {
                        IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                        Console.WriteLine("---Scroll to element---");
                        jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", item);
                    }
                    item.Click();
                    break;
                }
            }
        }

		public void selectItemInDropdown(IWebDriver driver, string parentXpath, string childXpath, string expectedItem,string dynamicParent, string dynamicChild)
		{
			clickToElement(driver, getDynamicXpath(parentXpath, dynamicParent));

			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			IList<IWebElement> allItems = explicitWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(getByLocator(getDynamicXpath(childXpath,dynamicChild))));


			foreach (var item in allItems)
			{
				if (item.Text.Trim().Equals(expectedItem))
				{
					if (item.Displayed == true)
					{
						IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
						Console.WriteLine("---Scroll to element---");
						jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", item);
					}
					item.Click();
					break;
				}
			}
		}

		public void checkToCheckbox(IWebDriver driver, string locatorType)
		{
			IWebElement element = getWebElement(driver, locatorType);
			element.Click();
		}

		private string getDynamicXpath(string locatorType, string dynamicValues)
		{
			if (locatorType.StartsWith("xpath=") || locatorType.StartsWith("XPATH=") || locatorType.StartsWith("Xpath="))
			{
                locatorType = string.Format(locatorType, dynamicValues);
			}
			return locatorType;
		}

		private string getDynamicXpath(string locatorType, string dynamicValues1, string dynamicValues2)
		{
			if (locatorType.StartsWith("xpath=") || locatorType.StartsWith("XPATH=") || locatorType.StartsWith("Xpath="))
			{
				locatorType = string.Format(locatorType, dynamicValues1, dynamicValues2);
			}
			return locatorType;
		}
		public void clickToElement(IWebDriver driver, string locatorType, string dynamicValues)
		{
			getWebElement(driver, getDynamicXpath(locatorType, dynamicValues)).Click();
		}

		public void sendkeyToElement(IWebDriver driver, string locatorType, string textValue, string dynamicValues1, string dynamicValues2)
		{
			IWebElement element = getWebElement(driver, getDynamicXpath(locatorType, dynamicValues1, dynamicValues2));
			element.Clear();
			element.SendKeys(textValue);
		}
		public void waitForElementVisible(IWebDriver driver, string locatorType, string dynamicValues)
		{
			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			explicitWait.Until(ExpectedConditions.ElementIsVisible(getByLocator(getDynamicXpath(locatorType, dynamicValues))));
		}

		public void waitForElementVisible(IWebDriver driver, string locatorType, string dynamicValues1, string dynamicValues2)
		{
			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			explicitWait.Until(ExpectedConditions.ElementIsVisible(getByLocator(getDynamicXpath(locatorType, dynamicValues1, dynamicValues2))));
		}

		public void checkToCheckbox(IWebDriver driver, string locatorType, string dynamicValues)
		{
			getWebElement(driver, getDynamicXpath(locatorType, dynamicValues)).Click();
		}

		public static string getCurrentTimeStamp()
		{
			DateTimeOffset now = DateTime.Now;
			long timeStamp = ((DateTimeOffset)now).ToUnixTimeSeconds(); ;
			return timeStamp.ToString();
		}

		public void scrollToElementByJS(IWebDriver driver, string locatorType)
		{
			IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor) driver;
			jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", getWebElement(driver,locatorType));
		}

		public bool isElementDisplayed(IWebDriver driver, string locatorType)
		{
			return getWebElement(driver, locatorType).Displayed;
		}
	}
}
