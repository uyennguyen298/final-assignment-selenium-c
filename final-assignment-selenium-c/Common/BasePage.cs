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
			explicitWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(getByLocator(locatorType)));
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

		public void selectItemInDropdown(IWebDriver driver, string locatorType, string textItem)
		{
			SelectElement select = new SelectElement(getWebElement(driver, locatorType));
			select.SelectByValue(textItem);
		}

		public void checkToCheckbox(IWebDriver driver, string locatorType)
		{
			IWebElement element = getWebElement(driver, locatorType);
			if (!element.Selected)
			{
				element.Click();
			}
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
		public void waitForAllElementVisible(IWebDriver driver, string locatorType, string dynamicValues)
		{
			WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(longTimeout));
			explicitWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(getByLocator(getDynamicXpath(locatorType, dynamicValues))));
		}

		public void checkToCheckbox(IWebDriver driver, string locatorType, string dynamicValues)
		{
			IWebElement element = getWebElement(driver, getDynamicXpath(locatorType, dynamicValues));
			if (!element.Selected)
			{
				element.Click();
			}
		}

		public void selectItemInDropdown(IWebDriver driver, string locatorType, string textItem, string dynamicValues)
		{
			SelectElement select = new SelectElement(getWebElement(driver, getDynamicXpath(locatorType, dynamicValues)));
			select.SelectByValue(textItem);
		}
	}
}
