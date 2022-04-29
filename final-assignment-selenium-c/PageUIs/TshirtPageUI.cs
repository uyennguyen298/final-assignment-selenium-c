using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.PageUIs
{
    public class TshirtPageUI
    {
        public static string TSHIRT_ITEM_LIST = "xpath=//h1[contains(.,'{0}')]//following-sibling::ul//li//a[@class='product-name']";
        public static string SEARCH_TEXTBOX = "id=search_query_top";
        public static string SEARCH_BUTTON = "xpath=//button[@name='submit_search']";
    }
}
