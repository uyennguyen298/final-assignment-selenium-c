using final_assignment_selenium_c.Common;
using final_assignment_selenium_c.DataObjects;
using final_assignment_selenium_c.PageUIs;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.PageObjects
{
    public class TshirtPageObject : BasePage
    {
        private IWebDriver driver;
        public TshirtPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
        public String getNameOfProduct()
        {
            waitForElementVisible(driver, TshirtPageUI.TSHIRT_ITEM_NAME);
            scrollToElementByJS(driver, TshirtPageUI.TSHIRT_ITEM_NAME);
            return getElementText(driver, TshirtPageUI.TSHIRT_ITEM_NAME);
        }
        public void inputToSearchTextbox(String searchValue)
        {
            waitForElementVisible(driver, TshirtPageUI.SEARCH_TEXTBOX);
            scrollToElementByJS(driver, TshirtPageUI.SEARCH_TEXTBOX);
            sendkeyToElement(driver, TshirtPageUI.SEARCH_TEXTBOX, searchValue);
        }
        public SearchPageObject clickToSearchButton()
        {
            waitForElementClickable(driver, TshirtPageUI.SEARCH_TEXTBOX);
            clickToElement(driver, TshirtPageUI.SEARCH_BUTTON);
            return PageGeneratorManager.getSearchPage(driver);
        }

    }
}
