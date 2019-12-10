using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriver
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
        public void IsRemovePassangerButtonDisabled()
        {
            StartPage startPage = new StartPage(webDriver).TicketsClick();
            Assert.IsTrue(startPage.zeroAdultPassanger.Displayed);
        }

        [Test]
        public void RequiredDepartError()
        {
            StartPage startPage = new StartPage(webDriver).FromStationClick("London").ArrivalStationClick("Bedford").SearchClick();
            Assert.IsTrue(startPage.requiredDepartureDateSign.Displayed);
        }

        [Test]
        public void FailedLoginAttemp()
        {
            StartPage startPage = new StartPage(webDriver).LoginMenuClick().FillEmailAndPasswordFields("skyblock@gmail.com", "123456").LoginButtonClick();
            Assert.IsTrue(startPage.wrongLoginMessage.Displayed);
        }

        [Test]
        public void FailedRailPassSearch()
        {
            StartPage startPage = new StartPage(webDriver).RailPassesClick().SearchRailPassesClick();
            Assert.IsTrue(startPage.requiredCountrySign.Displayed);
        }

    }
}