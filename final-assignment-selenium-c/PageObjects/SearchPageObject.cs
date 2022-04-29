using final_assignment_selenium_c.Common;
using final_assignment_selenium_c.PageUIs;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.PageObjects
{
    public class SearchPageObject : BasePage
    {
        private IWebDriver driver;
        public SearchPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
        public String getNameOfProduct()
        {
            waitForAllElementVisible(driver, SearchPageUI.TSHIRT_ITEM_LIST);
            return getFirstItemInList(driver, SearchPageUI.TSHIRT_ITEM_LIST);
        }

    }
}
