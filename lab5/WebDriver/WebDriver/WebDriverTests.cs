using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    [TestFixture]
    public class WebTests
    {
        public IWebDriver webDriver;
        WebDriverWait wait;

        [SetUp]
        public void StartBrowserAndGoToTheSite()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            webDriver.Navigate().GoToUrl("https://raileurope-world.com/");
        }

        [TearDown]
        public void QuitDriver()
        {
            webDriver.Quit();
        }

        [Test]
        //test 1
        public void IsRemovePassangerButtonDisabled()
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var countPassangers = webDriver.FindElement(By.XPath("//div[@class = 'js-travellers-select travellers-select input-pax btn-select']"));
            countPassangers.Click();

            var removeAdultPassanger = webDriver.FindElement(By.XPath("//span[@id='adults-button-min']"));
            removeAdultPassanger.Click();

            var removeAdultPassangerDisabled = webDriver.FindElement(By.XPath("//span[@class = 'min disabled']"));
            
            Assert.IsTrue(removeAdultPassanger.Displayed);
        }

        [Test]
        //test 2
        public void RequiredDepartError()
        {
            var departureStation = webDriver.FindElement(By.XPath("//input[@name = 're_ptpsearches%5B0%5D%2EoriginCityName']"));
            departureStation.SendKeys("London");

            var arrivalStation = webDriver.FindElement(By.XPath("//input[@name = 're_ptpsearches%5B0%5D%2EdestinationCityName']"));
            arrivalStation.SendKeys("Bedford");

            var searchButton = webDriver.FindElement(By.XPath("//button[@class = 'js-ptpform-submit form-submit btn-cta']"));
            searchButton.Click();

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var requiredDepart = webDriver.FindElement(By.XPath("//input[@class = 'form-text js-departuredate required error hasDatepicker livevalidated']"));

            Assert.IsTrue(requiredDepart.Displayed);
        }
    }
}