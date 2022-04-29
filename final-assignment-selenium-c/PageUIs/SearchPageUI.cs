using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.PageUIs
{
    public class SearchPageUI
    {
        public static string TSHIRT_ITEM_LIST = "xpath=//h1[contains(.,'Search')]//following-sibling::ul//following-sibling::li[@class[contains(.,'item')]]";
    }
}
