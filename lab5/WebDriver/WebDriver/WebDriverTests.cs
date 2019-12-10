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
        //test 1
        public void IsRemovePassangerButtonDisabled()
        {
            StartPage startPage = new StartPage(webDriver).TicketsClick();
            Assert.IsTrue(startPage.zeroAdultPassanger.Displayed);
        }

        [Test]
        //test 2
        public void RequiredDepartError()
        {
            StartPage startPage = new StartPage(webDriver).FromStationClick("London").ArrivalStationClick("Bedford").SearchClick();
            Assert.IsTrue(startPage.requiredDepartureDateSign.Displayed);
        }

        [Test]
        //test3
        public void FailedLoginAttemp()
        {
            StartPage startPage = new StartPage(webDriver).LoginMenuClick().FillEmailAndPasswordFields("skyblock@gmail.com", "123456").LoginButtonClick();
            Assert.IsTrue(startPage.wrongLoginMessage.Displayed);
        }

        [Test]
        //test4
        public void FailedRailPassSearch()
        {
            StartPage startPage = new StartPage(webDriver).RailPassesClick().SearchRailPassesClick();
            Assert.IsTrue(startPage.requiredCountrySign.Displayed);
        }

    }
}