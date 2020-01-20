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
        
        [FindsBy(How = How.XPath, Using = "//div[@id = 'header_login']")]
        private IWebElement loginFormButton;

        [FindsBy(How = How.XPath, Using = "/html/body/header/div[1]/div[2]/div[4]/ul[2]/div/div/li/div[3]/form/div[1]/input")]
        private IWebElement inputEmailField;

        [FindsBy(How = How.XPath, Using = "/html/body/header/div[1]/div[2]/div[4]/ul[2]/div/div/li/div[3]/form/div[2]/input")]
        private IWebElement inputPasswordField;

        [FindsBy(How = How.XPath, Using = "//a[@class = 'ure-btn main-btn js-login-async']")]
        private IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//li[@class = 'rtab transparent-black']")]
        private IWebElement railPassesButton;

        [FindsBy(How = How.XPath, Using = "//div[@id = 'pass_results']")]
        public IWebElement railPassSearchResult;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/article/div/div[2]/div[2]/div[2]/div[1]/span/input")]
        private IWebElement firstCountryField;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'js-ptpform-submit form-submit btn-cta form-pass']")]
        private IWebElement searchRailPassButton;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'message error-message']")]
        public IWebElement wrongLoginMessage;

        [FindsBy(How = How.XPath, Using = "/html/body/div[70]/div[2]/a")]
        public IWebElement anytimeButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/article/div/div[2]/div[1]/div/div/div[2]/form/div[2]/div/div[1]/div[2]/div[1]/input[1]")]
        private IWebElement dataPickerButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[38]/table/tbody/tr[5]/td[4]")]
        private IWebElement randomDate;

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
            dataPickerButton.Click();
            randomDate.Click();
            //var rows = tableBody.FindElements(By.TagName("tr"));
            //foreach (var row in rows)
            //{
            //    var cells = row.FindElements(By.TagName("td"));
            //    foreach (var cell in cells)
            //    {
            //        var daysInDataPicker = cell.FindElement(By.TagName("a")).GetAttribute("text");
            //        if (daysInDataPicker == stringDate)
            //        {
            //            cell.Click();
            //        }
            //    }
            //}
            //new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("js-hourpickany hourpickany")));
            anytimeButton.Click();
            return this;
        }

        public MainPage InputTripInfo(TripInfo trip)
        {
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

        public MainPage RailPassesSearchButtonClick()
        {
            searchRailPassButton.Click();
            return this;
        }

        public MainPage RailPassesSearchClick()
        {
            railPassesButton.Click();
            return this;
        }

        public MainPage RailPassCountryFill()
        {
            firstCountryField.SendKeys("Belgium");
            return this;
        }

        public TrainListPage ClickSearchButton()
        {
            searchTicketButton.Click();
            return new TrainListPage(driver);
        }

    }
}
