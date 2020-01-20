using System;
using RailEurope.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace RailEurope.Pages
{
    public class PassangerInformationPage
    {
        private IWebDriver driver;

        public PassangerInformationPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "input[@id = 're_0_firstname']")]
        public IWebElement firstNameField;

        [FindsBy(How = How.XPath, Using = "input[@id = 're_0_lastname']")]
        public IWebElement lastNameField;

        [FindsBy(How = How.XPath, Using = "input[@id = 'country-input-0']")]
        public IWebElement countryField;

        //rework выбор пола по нажатию из списка
        #region genderbutton
        [FindsBy(How = How.XPath, Using = "span[@id = 're_0_gender-button']")]
        public IWebElement titleChooseButton;

        [FindsBy(How = How.XPath, Using = "span[@class = 're_0_gender-button']")]
        public IWebElement genderChooseButton;
#endregion

        [FindsBy(How = How.XPath, Using = "input[@class = 'form-submit ure-btn main-btn js-ptp-pax-submit js-scroll-to-error ure-btn-proceed btn-cta']")]
        public IWebElement addToCartButton;

        public PassangerInformationPage InputPassangerInformation(PassangerInfo passangerInfo)
        {
            firstNameField.Click();
            firstNameField.SendKeys(passangerInfo.firstName);
            lastNameField.Click();
            lastNameField.SendKeys(passangerInfo.lastName);
            countryField.Click();
            countryField.SendKeys(passangerInfo.yourCountry);
            return this;
        }
        public BascketPage AddToCart()
        {
            addToCartButton.Click();
            return new BascketPage(driver);
        }
    }
}
