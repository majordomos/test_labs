using System;
using RailEurope.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace RailEurope.Pages
{
    public class CheckoutPage
    {
        private IWebDriver driver;

        public CheckoutPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id = 'cardNumber']")]
        public IWebElement cardNumberField;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'expiryDate']")]
        public IWebElement expiryDateField;
            
        [FindsBy(How = How.XPath, Using = "//input[@id = 'cvv']")]
        public IWebElement cvvField;
            
        [FindsBy(How = How.XPath, Using = "//input[@name = 'cardholderName']")]
        public IWebElement cardHolderNameField;

        [FindsBy(How = How.XPath, Using = "//button[@id = 'primaryButton']")]
        public IWebElement payButton;
        
        public CheckoutPage InputCardDataAndPayClick(CustomerInfo customer)
        {
            cardNumberField.Click();
            cardNumberField.SendKeys(customer.cardNumber);
            expiryDateField.Click();
            expiryDateField.SendKeys(customer.validDate);
            cvvField.Click();
            cvvField.SendKeys(customer.cvvCode);
            cardHolderNameField.Click();
            cardHolderNameField.SendKeys(customer.cardOwnerName);
            payButton.Click();
            return this;
        }
    }
}
