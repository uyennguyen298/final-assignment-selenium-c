using final_assignment_selenium_c.Common;
using final_assignment_selenium_c.DataObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_assignment_selenium_c.PageObjects
{
    public class CreateAnAccountPageObject : BasePage
    {
        private IWebDriver driver;
        public CreateAnAccountPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void selectTitleCheckbox()
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TITLE_RADIO_BUTTON);
            checkToCheckbox(driver, CreateAnAccountPageUI.TITLE_RADIO_BUTTON);
        }

        public void selectDateDropdownlist(string dob_date)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.DOB_DATE);
            selectItemInDropdown(driver, CreateAnAccountPageUI.DOB_DATE, dob_date);
        }

        public void selectMonthDropdownlist(string dob_month)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.DOB_MONTH);
            selectItemInDropdown(driver, CreateAnAccountPageUI.DOB_MONTH, dob_month);
        }

        public void selectYearDropdownlist(string dob_year)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.DOB_YEAR);
            selectItemInDropdown(driver, CreateAnAccountPageUI.DOB_YEAR, dob_year);
        }

        public void selectStateDropdownlist(string state)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.STATE_DROPDOWN_LIST);
            selectItemInDropdown(driver, CreateAnAccountPageUI.STATE_DROPDOWN_LIST, state);
        }

        public void selectCountryDropdownlist(string country)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.COUNTRY_DROPDOWN_LIST);
            selectItemInDropdown(driver, CreateAnAccountPageUI.COUNTRY_DROPDOWN_LIST, country);
        }

        public void selectSignUpCheckbox()
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.SIGN_UP_CHECK_BOX);
            checkToCheckbox(driver, CreateAnAccountPageUI.SIGN_UP_CHECK_BOX);
        }

        public void selectReceiveSpecialOffersCheckbox()
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.RECEIVE_SPECIAL_OFFERS_CHECK_BOX);
            checkToCheckbox(driver, CreateAnAccountPageUI.RECEIVE_SPECIAL_OFFERS_CHECK_BOX);
        }

        public void clickToRegisterButton()
        {
            waitForElementClickable(driver, CreateAnAccountPageUI.REGISTER_BUTTON);
            clickToElement(driver, CreateAnAccountPageUI.REGISTER_BUTTON);
        }

        public void inputToFirstNameTextbox(String firstName)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.PERSONAL_INFO_FIRST_NAME_TEXT_BOX);
            sendkeyToElement(driver, CreateAnAccountPageUI.PERSONAL_INFO_FIRST_NAME_TEXT_BOX, firstName);
        }

        public void inputToLastNameTextbox(String lastName)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.PERSONAL_INFO_LAST_NAME_TEXT_BOX);
            sendkeyToElement(driver, CreateAnAccountPageUI.PERSONAL_INFO_LAST_NAME_TEXT_BOX, lastName);
        }

        public void inputToEmailAddressTextbox(String emailAddress)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.EMAIL_TEXT_BOX);
            sendkeyToElement(driver, CreateAnAccountPageUI.EMAIL_TEXT_BOX, emailAddress);
        }

        public void inputToPasswordTextbox(String password)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.PASSWORD_TEXT_BOX);
            sendkeyToElement(driver, CreateAnAccountPageUI.PASSWORD_TEXT_BOX, password);
        }

        public void inputToCompanyTextbox(String company)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.COMPANY_TEXT_BOX);
            sendkeyToElement(driver, CreateAnAccountPageUI.COMPANY_TEXT_BOX, company);
        }

        public void inputToAddressTextbox(String address)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.ADDRESS_TEXT_BOX);
            sendkeyToElement(driver, CreateAnAccountPageUI.ADDRESS_TEXT_BOX, address);
        }

        public void inputToAddressLine2Textbox(String addressLine2)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.ADDRESS_LINE2_TEXT_BOX);
            sendkeyToElement(driver, CreateAnAccountPageUI.ADDRESS_LINE2_TEXT_BOX, addressLine2);
        }
        public void inputToCityTextbox(String city)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.CITY_TEXT_BOX);
            sendkeyToElement(driver, CreateAnAccountPageUI.CITY_TEXT_BOX, city);
        }
        public void inputToZipPostalCodeTextbox(String zipPostalCode)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.ZIP_POSTAL_CODE_TEXT_BOX) ;
            sendkeyToElement(driver, CreateAnAccountPageUI.ZIP_POSTAL_CODE_TEXT_BOX, zipPostalCode);
        }
        public void inputToAdditionalInformationTextbox(String addionalInformation)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.ADDITIONAL_INFORMATION_TEXT_AREA);
            sendkeyToElement(driver, CreateAnAccountPageUI.ADDITIONAL_INFORMATION_TEXT_AREA, addionalInformation);
        }
        public void inputToHomePhoneTextbox(String homePhone)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.HOME_PHONE_TEXT_BOX);
            sendkeyToElement(driver, CreateAnAccountPageUI.HOME_PHONE_TEXT_BOX, homePhone);
        }
        public void inputToMobilePhoneTextbox(String mobilePhone)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.MOBILE_PHONE_TEXT_BOX);
            sendkeyToElement(driver, CreateAnAccountPageUI.MOBILE_PHONE_TEXT_BOX, mobilePhone);
        }
        public void inputToAssignAnAddressTextbox(String assignAnAddress)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.ASSIGN_AN_ADDRESS_TEXT_BOX);
            sendkeyToElement(driver, CreateAnAccountPageUI.ASSIGN_AN_ADDRESS_TEXT_BOX, assignAnAddress);
        }
    }
}
