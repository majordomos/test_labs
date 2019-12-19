using System;
using RailEurope.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace RailEurope.Pages
{
    public class TrainListPage
    {
        private IWebDriver driver;

        public TrainListPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@data-solutionid = '5190928690544996541-709844773']")]
        public IWebElement firstTrainInList;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'add-1-1']")]
        public IWebElement selectFareButton;

        [FindsBy(How = How.XPath, Using = "//input[@class = 'form-text js-departuredate required error hasDatepicker livevalidated']")]
        public IWebElement requiredDepartureDateSign;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'js-ptpresult-packagetable ptpresults-overview ptpresults-horizontal']")]
        public IWebElement listOfTrains;

        public TrainListPage FirstTrainClick()
        {
            firstTrainInList.Click();
            return this;
        }

        public PassangerInformationPage SelectFareButtonClick()
        {
            selectFareButton.Click();
            return new PassangerInformationPage(driver);
        }
    }
}
