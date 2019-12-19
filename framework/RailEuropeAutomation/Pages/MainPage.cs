using System;
using RailEurope.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace RailEurope.Pages
{
    public class MainPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'js-travellers-select travellers-select input-pax btn-select']")]
        private IWebElement passangersCount;

        [FindsBy(How = How.XPath, Using = "//span[@id='adults-button-min']")]
        private IWebElement decreasePassangerCount;

        [FindsBy(How = How.XPath, Using = "//span[@class = 'min disabled']")]
        public IWebElement zeroAdultPassanger;

        [FindsBy(How = How.XPath, Using = "//input[@name = 're_ptpsearches%5B0%5D%2EoriginCityName']")]
        private IWebElement departureStation;

        [FindsBy(How = How.XPath, Using = "//input[@name = 're_ptpsearches%5B0%5D%2EdestinationCityName']")]
        private IWebElement arrivalStation;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'js-ptpform-submit form-submit btn-cta']")]
        private IWebElement searchTicketButton;
        
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

        [FindsBy(How = How.XPath, Using = "//a[@class = 'js-hourpickany hourpickany']")]
        public IWebElement anytimeButton;

        public static DateTime currentDate = DateTime.Today;
        string stringDate = currentDate.AddDays(3).Day.ToString();

        [FindsBy(How = How.XPath, Using = "table[@class = 'ui - datepicker - calendar']")]
        public IWebElement dataPicker;

        [FindsBy(How = How.TagName, Using = "tbody")]
        public IWebElement tableBody;

        public MainPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        public MainPage TicketsClick()
        {
            passangersCount.Click();
            decreasePassangerCount.Click();
            return this;
        }

        public MainPage PickDateAndTime()
        {
            var rows = tableBody.FindElements(By.TagName("tr"));
            foreach (var row in rows)
            {
                var cells = row.FindElements(By.TagName("td"));
                foreach (var cell in cells)
                {
                    var daysInDataPicker = cell.FindElement(By.TagName("a")).GetAttribute("text");
                    if (daysInDataPicker == stringDate)
                    {
                        cell.Click();
                    }
                }
            }
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("js-hourpickany hourpickany")));
            anytimeButton.Click();
            return this;
        }

        public MainPage InputTripInfo(TripInfo trip)
        {
            departureStation.Click();
            departureStation.SendKeys(trip.DepartureStation);
            arrivalStation.SendKeys(trip.ArrivalStation);
            return this;
        }
        
        public MainPage LoginMenuClick()
        {
            loginFormButton.Click();
            return this;
        }

        public MainPage FillEmailAndPasswordFields(LoginInfo login)
        {
            inputEmailField.SendKeys(login.Email);
            inputPasswordField.SendKeys(login.Password);
            return this;
        }

        public MainPage DecreasePassangerCount()
        {
            passangersCount.Click();
            decreasePassangerCount.Click();
            return this;
        }

        public MainPage LoginButtonClick()
        {
            loginButton.Click();
            return this;
        }

        public MainPage RailPassesSearchClick()
        {
            railPassesButton.Click();
            searchRailPassButton.Click();
            return this;
        }

        public TrainListPage ClickSearchButton()
        {
            searchTicketButton.Click();
            return new TrainListPage(driver);
        }

    }
}
