using NPOI.Util;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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

		public void waitForElementClickable(IWebDriver driver, string locatorType, params string[] dynamicValues)
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
                        jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", item);
                    }
                    item.Click();
                    break;
                }
            }
        }

		public void selectItemInDropdown(IWebDriver driver, string parentXpath, string childXpath, string expectedItem, params string[] dynamicValues)
		{
			clickToElement(driver, getDynamicXpath(parentXpath, dynamicValues));

			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			IList<IWebElement> allItems = explicitWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(getByLocator(getDynamicXpath(childXpath, dynamicValues))));


			foreach (var item in allItems)
			{
				if (item.Text.Trim().Equals(expectedItem))
				{
					if (item.Displayed == true)
					{
						IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
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

		private string getDynamicXpath(string locatorType, params string[] dynamicValues)
		{
			if (locatorType.StartsWith("xpath=") || locatorType.StartsWith("XPATH=") || locatorType.StartsWith("Xpath="))
			{
                locatorType = string.Format(locatorType, (object[]) dynamicValues);
			}
			return locatorType;
		}

		public void clickToElement(IWebDriver driver, string locatorType, params string[] dynamicValues)
		{
			getWebElement(driver, getDynamicXpath(locatorType, dynamicValues)).Click();
		}

		public void sendkeyToElement(IWebDriver driver, string locatorType, string textValue, params string[] dynamicValues)
		{
			IWebElement element = getWebElement(driver, getDynamicXpath(locatorType, dynamicValues));
			element.Clear();
			element.SendKeys(textValue);
		}
		public void waitForElementVisible(IWebDriver driver, string locatorType, params string[] dynamicValues)
		{
			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			explicitWait.Until(ExpectedConditions.ElementIsVisible(getByLocator(getDynamicXpath(locatorType, dynamicValues))));
		}

		public void waitForAllElementVisible(IWebDriver driver, string locatorType)
		{
			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			explicitWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(getByLocator(locatorType)));
		}
		public void waitForElementExist(IWebDriver driver, string locatorType, params string[] dynamicValues)
		{
			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			explicitWait.Until(ExpectedConditions.ElementExists(getByLocator(getDynamicXpath(locatorType, dynamicValues))));
			
		}

		public void waitForElementExist(IWebDriver driver, string locatorType)
		{
			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			explicitWait.Until(ExpectedConditions.ElementExists(getByLocator(locatorType)));
		}

		public void checkToCheckbox(IWebDriver driver, string locatorType, params string[] dynamicValues)
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

		public void scrollToElementByJS(IWebDriver driver, string locatorType,params string[] dynamicValues)
		{
			IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
			jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", getWebElement(driver, getDynamicXpath(locatorType,dynamicValues)));
		}

		public bool isElementDisplayed(IWebDriver driver, string locatorType)
		{
			return getWebElement(driver, locatorType).Displayed;
		}
		public void hoverOnElement(IWebDriver driver, string locatorType)
		{
			Actions action = new Actions(driver);
			action.MoveToElement(getWebElement(driver, locatorType)).Perform();
		}
		public void hoverOnElement(IWebDriver driver, string locatorType, params string[] dynamicValues)
		{
			Actions action = new Actions(driver);
			action.MoveToElement(getWebElement(driver, getDynamicXpath(locatorType, dynamicValues))).Perform();
		}

		public string getFirstItemInList(IWebDriver driver, string locatorType)
		{
			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			IList<IWebElement> allItems = explicitWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(getByLocator(locatorType)));
			return allItems.First().Text;
		}
		public string getFirstItemInList(IWebDriver driver, string locatorType, params string[] dynamicValues)
		{
			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			IList<IWebElement> allItems = explicitWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(getByLocator(getDynamicXpath(locatorType,dynamicValues))));
			return allItems.First().Text;
		}

	}
}
