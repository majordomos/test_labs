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

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/article/div/div[2]/div[1]/div/div/div[2]/form/div[2]/div/div[1]/div[2]/div[1]/label[2]")]
        public IWebElement requiredDepartureDateSign;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/article/div/div/div/div[2]/div/div[1]/div[2]/div[5]")]
        public IWebElement listOfTrains;

        public TrainListPage WaitListOfTrains()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/article/div/div/div/div[2]/div/div[1]/div[2]/div[5]")));
            return this;
        }

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
