using System;
using RailEurope.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace RailEurope.Pages
{
    public class BascketPage
    {
        private IWebDriver driver;

        public BascketPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class = 'form-submit ure-btn main-btn ure-btn-proceed btn-cta js-cart-checkout']")]
        public IWebElement checkoutButton;

        public DeliveryInformationPage CheckoutButtonClick()
        {
            checkoutButton.Click();
            return new DeliveryInformationPage(driver);
        }
    }
}
