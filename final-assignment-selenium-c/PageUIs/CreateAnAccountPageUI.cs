﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.DataObjects
{
    public class CreateAnAccountPageUI
    {
        public static string TITLE_RADIO_BUTTON = "xpath=//label[contains(., '{0}')]//div";
        public static string TEXTBOX = "xpath=//h3[contains(text(),'{0}')]//..//label[contains(.,'{1}')]//following-sibling::input";
        public static string DROPDOWN = "xpath=//label[contains(.,'{0}')]//..//select";
        public static string DROPDOWN_OPTION = "xpath=//label[contains(.,'{0}')]//..//select/option";
        //public static String PERSONAL_INFO_LAST_NAME_TEXT_BOX = "";
        //public static String EMAIL_TEXT_BOX = "";
        //public static String PASSWORD_TEXT_BOX = "";
        public static string DOB_DATE = "id=days";
        public static string DOB_DATE_OPTION = "xpath=//select[@id='days']//option";
        public static string DOB_MONTH = "id=months";
        public static string DOB_MONTH_OPTION = "xpath=//select[@id='months']//option";
        public static string DOB_YEAR = "id=years";
        public static string DOB_YEAR_OPTION = "xpath=//select[@id='years']//option";
        public static string NEWSLETTER_CHECKBOX = "id=newsletter";
        public static string RECEIVE_SPECIAL_OFFERS_CHECKBOX = "id=optin";
        //public static String ADDRESS_FIRST_NAME_TEXT_BOX = "";
        //public static String ADDRESS_LAST_NAME_TEXT_BOX = "";
        //public static String COMPANY_TEXT_BOX = "";
        //public static String ADDRESS_TEXT_BOX = "";
        //public static String ADDRESS_LINE2_TEXT_BOX = "";
        //public static String CITY_TEXT_BOX = "";
        //public static String STATE_DROPDOWN_LIST = "";
        //public static String ZIP_POSTAL_CODE_TEXT_BOX = "";
        //public static String COUNTRY_DROPDOWN_LIST = "";
        public static string ADDITIONAL_INFORMATION_TEXT_AREA = "id=other";
        //public static String HOME_PHONE_TEXT_BOX = "";
        //public static String MOBILE_PHONE_TEXT_BOX = "";
        //public static String ASSIGN_AN_ADDRESS_TEXT_BOX = "";
        public static string REGISTER_BUTTON = "id=submitAccount";

    }
}
