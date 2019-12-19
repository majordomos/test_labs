using System;
using RailEurope.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace RailEurope.Pages
{
    public class DeliveryInformationPage
    {
        private IWebDriver driver;

        public DeliveryInformationPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id = 'ticketing-options-submit']")]
        public IWebElement proceedToPaymentButton;
        
        [FindsBy(How = How.XPath, Using = "span[@id = 're_0_gender-button']")]
        public IWebElement titleChooseListButton;

        [FindsBy(How = How.XPath, Using = "div[@id = 'ui-id-405']")]
        public IWebElement genderChooseButton;

        [FindsBy(How = How.XPath, Using = "//input[@id = 're_billing_firstname']")]
        public IWebElement firstNameField;

        [FindsBy(How = How.XPath, Using = "//input[@id = 're_billing_lastname']")]
        public IWebElement lastNameField; 

        [FindsBy(How = How.XPath, Using = "//input[@id = 'billing-email']")]
        public IWebElement emailField;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'billing-email-verify']")]
        public IWebElement emailVerifyField; 

        [FindsBy(How = How.XPath, Using = "//input[@id = 'billing-phone']")]
        public IWebElement phoneNumberField;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'billing-address1']")]
        public IWebElement firstAdressLine;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'billing-city']")]
        public IWebElement cityField;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'billing-zip']")]
        public IWebElement zipCodeField;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'country-input-4']")]
        public IWebElement countryField;

        [FindsBy(How = How.XPath, Using = "//label[@for = 're_protectionplan_no']")]
        public IWebElement declineRailProtectionPlan;

        public DeliveryInformationPage InputDeliveryInformation(CustomerInfo customerInfo)
        {
            titleChooseListButton.Click();
            genderChooseButton.Click();
            firstNameField.Click();
            firstNameField.SendKeys(customerInfo.firstName);
            lastNameField.Click();
            lastNameField.SendKeys(customerInfo.lastName);
            emailField.Click();
            emailField.SendKeys(customerInfo.emailAddress);
            emailVerifyField.Click();
            emailVerifyField.SendKeys(customerInfo.emailAddress);
            phoneNumberField.Click();
            phoneNumberField.SendKeys(customerInfo.phoneNumber);
            firstAdressLine.Click();
            firstAdressLine.SendKeys(customerInfo.addressLine);
            cityField.Click();
            cityField.SendKeys(customerInfo.yourCity);
            zipCodeField.Click();
            zipCodeField.SendKeys(customerInfo.zipCode);
            countryField.Click();
            countryField.SendKeys(customerInfo.yourCountry);
            declineRailProtectionPlan.Click();
            return this;
        }
        public CheckoutPage ProceedToPaymentButtonClick()
        {
            proceedToPaymentButton.Click();
            return new CheckoutPage(driver);
        }
    }
}
