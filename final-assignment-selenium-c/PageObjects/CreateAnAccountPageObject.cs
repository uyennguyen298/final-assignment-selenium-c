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
            waitForElementClickable(driver, CreateAnAccountPageUI.TITLE_RADIO_BUTTON,"Mrs.");
            checkToCheckbox(driver, CreateAnAccountPageUI.TITLE_RADIO_BUTTON, "Mrs.");
        }

        public void selectDateDropdownlist(string dob_date)
        {
            waitForElementExist(driver, CreateAnAccountPageUI.DOB_DATE, CreateAnAccountPageUI.DOB_DATE_OPTION, dob_date);
            selectItemInDropdown(driver, CreateAnAccountPageUI.DOB_DATE, CreateAnAccountPageUI.DOB_DATE_OPTION, dob_date);
        }

        public void selectMonthDropdownlist(string dob_month)
        {
            waitForElementExist(driver, CreateAnAccountPageUI.DOB_MONTH, CreateAnAccountPageUI.DOB_MONTH_OPTION, dob_month);
            selectItemInDropdown(driver, CreateAnAccountPageUI.DOB_MONTH, CreateAnAccountPageUI.DOB_MONTH_OPTION, dob_month);
        }

        public void selectYearDropdownlist(string dob_year)
        {
            waitForElementExist(driver, CreateAnAccountPageUI.DOB_YEAR, CreateAnAccountPageUI.DOB_YEAR_OPTION, dob_year);
            selectItemInDropdown(driver, CreateAnAccountPageUI.DOB_YEAR, CreateAnAccountPageUI.DOB_YEAR_OPTION, dob_year);
        }

        public void selectStateDropdownlist(string state)
        {
            waitForElementExist(driver, CreateAnAccountPageUI.DROPDOWN,"State");
            selectItemInDropdown(driver, CreateAnAccountPageUI.DROPDOWN, CreateAnAccountPageUI.DROPDOWN_OPTION, state, "State");
        }

        public void selectCountryDropdownlist(string country)
        {
            waitForElementExist(driver, CreateAnAccountPageUI.DROPDOWN, "Country");
            selectItemInDropdown(driver, CreateAnAccountPageUI.DROPDOWN, CreateAnAccountPageUI.DROPDOWN_OPTION, country, "Country");
        }

        public void selectNewsLetterCheckbox()
        {
            scrollToElementByJS(driver, CreateAnAccountPageUI.NEWSLETTER_CHECKBOX);
            //waitForElementClickable(driver, CreateAnAccountPageUI.NEWSLETTER_CHECKBOX);
            checkToCheckbox(driver, CreateAnAccountPageUI.NEWSLETTER_CHECKBOX);
        }

        public void selectReceiveSpecialOffersCheckbox()
        {
            scrollToElementByJS(driver, CreateAnAccountPageUI.RECEIVE_SPECIAL_OFFERS_CHECKBOX);
            //waitForElementClickable(driver, CreateAnAccountPageUI.RECEIVE_SPECIAL_OFFERS_CHECKBOX);
            checkToCheckbox(driver, CreateAnAccountPageUI.RECEIVE_SPECIAL_OFFERS_CHECKBOX);
        }

        public MyAccountPageObject clickToRegisterButton()
        {
            scrollToElementByJS(driver, CreateAnAccountPageUI.REGISTER_BUTTON);
            waitForElementClickable(driver, CreateAnAccountPageUI.REGISTER_BUTTON);
            clickToElement(driver, CreateAnAccountPageUI.REGISTER_BUTTON);
            return PageGeneratorManager.getMyAccountPage(driver);
        }

        public void inputToFirstNameTextbox(String firstName)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your personal information", "First name");
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, firstName, "Your personal information","First name");
        }

        public void inputToLastNameTextbox(String lastName)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your personal information", "Last name");
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, lastName, "Your personal information", "Last name");
        }

        public void inputToEmailAddressTextbox(String emailAddress)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your personal information", "Email");
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, emailAddress, "Your personal information", "Email");
        }

        public void inputToPasswordTextbox(String password)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your personal information", "Password");
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, password, "Your personal information", "Password");
        }

        public void inputToCompanyTextbox(String company)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your address", "Company");
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, company, "Your address", "Company");
        }

        public void inputToAddressTextbox(String address)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your address", "Address");
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, address, "Your address", "Address");
        }

        public void inputToAddressLine2Textbox(String addressLine2)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your address", "Address (Line 2)");
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, addressLine2, "Your address", "Address (Line 2)");
        }
        public void inputToCityTextbox(String city)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your address", "City");
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, city, "Your address", "City");
        }
        public void inputToZipPostalCodeTextbox(String zipPostalCode)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your address", "Zip/Postal Code") ;
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, zipPostalCode, "Your address", "Zip/Postal Code");
        }
        public void inputToAdditionalInformationTextbox(String addionalInformation)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.ADDITIONAL_INFORMATION_TEXT_AREA);
            sendkeyToElement(driver, CreateAnAccountPageUI.ADDITIONAL_INFORMATION_TEXT_AREA, addionalInformation);
        }
        public void inputToHomePhoneTextbox(String homePhone)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your address", "Home phone");
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, homePhone, "Your address", "Home phone");
        }
        public void inputToMobilePhoneTextbox(String mobilePhone)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your address", "Mobile phone");
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, mobilePhone, "Your address", "Mobile phone");
        }
        public void inputToAssignAnAddressTextbox(String assignAnAddress)
        {
            waitForElementVisible(driver, CreateAnAccountPageUI.TEXTBOX, "Your address", "Assign an address");
            sendkeyToElement(driver, CreateAnAccountPageUI.TEXTBOX, assignAnAddress, "Your address", "Assign an address");
        }

        public void inputToAllFields()
        {
            selectTitleCheckbox();
            inputToFirstNameTextbox(Utilities.TestData.firstName);
            inputToLastNameTextbox(Utilities.TestData.lastName);
            inputToEmailAddressTextbox(Utilities.TestData.emailAddress);
            inputToPasswordTextbox(Utilities.TestData.password);
            selectDateDropdownlist(Utilities.TestData.dob_date);
            selectMonthDropdownlist(Utilities.TestData.dob_month);
            selectYearDropdownlist(Utilities.TestData.dob_year);
            selectNewsLetterCheckbox();
            selectReceiveSpecialOffersCheckbox();
            inputToCompanyTextbox(Utilities.TestData.company);
            inputToAddressTextbox(Utilities.TestData.address);
            inputToAddressLine2Textbox(Utilities.TestData.addressLine2);
            inputToCityTextbox(Utilities.TestData.city);
            selectStateDropdownlist(Utilities.TestData.state);
            inputToZipPostalCodeTextbox(Utilities.TestData.zipPostalCode);
            selectCountryDropdownlist(Utilities.TestData.country);
            inputToAdditionalInformationTextbox(Utilities.TestData.additionalInformation);
            inputToHomePhoneTextbox(Utilities.TestData.homePhone);
            inputToMobilePhoneTextbox(Utilities.TestData.mobilePhone);
            inputToAssignAnAddressTextbox(Utilities.TestData.assignAnAddress);
        }

    }
}
