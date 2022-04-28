using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.Test
{
    class testing
    {
        public static String DYNAMIC_SIDEBAR_LINK_BY_PAGE_NAME = "//div[contains(@class,'account-navigation')]//a[text()='{0}']";

        public static void main(String[] args)
        {
            clickToLink(DYNAMIC_SIDEBAR_LINK_BY_PAGE_NAME, "Customer info");


            Console.WriteLine("1 locator");

        }
        public static void clickToLink(String dynamicLocator, string test001)
        {
            String locator = String.Format(dynamicLocator, test001);
            Console.WriteLine("Click to: " + locator);
        }
    }
}