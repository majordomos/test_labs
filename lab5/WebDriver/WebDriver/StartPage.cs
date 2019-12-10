using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriver
{
    public class StartPage
    {
        public StartPage (IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//div[@class = 'js-travellers-select travellers-select input-pax btn-select']")]
        private IWebElement passangersCount;
        
        [FindsBy(How = How.XPath, Using = "//span[@id='adults-button-min']")]
        private IWebElement decreasePassangerCountl;
        
        [FindsBy(How = How.XPath, Using = "//span[@class = 'min disabled']")]
        public IWebElement zeroAdultPassanger;
        
        [FindsBy(How = How.XPath, Using = "//input[@name = 're_ptpsearches%5B0%5D%2EoriginCityName']")]
        private IWebElement departureStation;
        
        [FindsBy(How = How.XPath, Using = "//input[@name = 're_ptpsearches%5B0%5D%2EdestinationCityName']")]
        private IWebElement arrivalStation;
        
        [FindsBy(How = How.XPath, Using = "//button[@class = 'js-ptpform-submit form-submit btn-cta']")]
        private IWebElement searchTicketButton;
        
        [FindsBy(How = How.XPath, Using = "//input[@class = 'form-text js-departuredate required error hasDatepicker livevalidated']")]
        public IWebElement requiredDepartureDateSign;
        
        [FindsBy(How = How.XPath, Using = "//div[@class = 'header_button menu_btn dropdown']")]
        private IWebElement loginFormButton;
        
        [FindsBy(How = How.XPath, Using = "//input[@name = 're_username']")]
        private IWebElement inputEmailField;
        
        [FindsBy(How = How.XPath, Using = "//input[@name = 're_password']")]
        private IWebElement inputPasswordField;
        
        [FindsBy(How = How.XPath, Using = "//a[@class = 'ure-btn main-btn js-login-async']")]
        private IWebElement loginButton;
        
        [FindsBy(How = How.XPath, Using = "//li[@class = 'rtab transparent-black']")]
        private IWebElement railPassesButton;
        
        [FindsBy(How = How.XPath, Using = "//button[@class = 'js-ptpform-submit form-submit btn-cta form-pass']")]
        private IWebElement searchRailPassButton;
        
        [FindsBy(How = How.XPath, Using = "//input[@class = 'input warning']")]
        public IWebElement requiredCountrySign;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'message error-message']")]
        public IWebElement wrongLoginMessage;
            
        public StartPage TicketsClick()
        {
            passangersCount.Click();
            decreasePassangerCountl.Click();
            return this;
        }

        public StartPage FromStationClick(string depart)
        {
            departureStation.Click();
            departureStation.SendKeys(depart);
            return this;
        }

        public StartPage ArrivalStationClick(string arrival)
        {
            arrivalStation.Click();
            arrivalStation.SendKeys(arrival);
            return this;
        }

        public StartPage SearchClick()
        {
            searchTicketButton.Click();
            return this;
        }

        public StartPage LoginMenuClick()
        {
            loginFormButton.Click();
            return this;
        }
        
        public StartPage FillEmailAndPasswordFields(string email, string pas)
        {
            inputEmailField.SendKeys(email);
            inputPasswordField.SendKeys(email);
            return this;
        }

        public StartPage LoginButtonClick()
        {
            loginButton.Click();
            return this;
        }

        public StartPage RailPassesClick()
        {
            railPassesButton.Click();
            return this;
        }

        public StartPage SearchRailPassesClick()
        {
            searchRailPassButton.Click();
            return this;
        }
    }
}
