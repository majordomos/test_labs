using RailEurope.Pages;
using RailEurope.Services;
using RailEurope.Models;
using NUnit.Framework;
using System;

namespace RailEurope.Tests
{
    public class RailEuropeTests : TestConfig
    {
        [Test]
        public void RequiredDepartError()
        {
            TripInfo trip = TripInfoCreator.SetInvalidInfo();
            TrainListPage mainPage = new MainPage(Driver)
                .InputTripInfo(trip)
                .ClickSearchButton();
            Assert.IsTrue(mainPage.requiredDepartureDateSign.Displayed);
        }

        [Test]
        public void FailedLoginAttemp()
        {
            LoginInfo login = LoginInfoCreator.SetInvalidInfo();
            MainPage mainPage = new MainPage(Driver)
                .FillEmailAndPasswordFields(login)
                .LoginButtonClick();
            Assert.IsTrue(mainPage.wrongLoginMessage.Displayed);
        }

        [Test]
        public void IsRemovePassangerButtonDisabled()
        {
            MainPage mainPage = new MainPage(Driver)
                .DecreasePassangerCount();
            Assert.IsTrue(mainPage.zeroAdultPassanger.Displayed);
        }

        [Test]
        public void FailedRailPassSearch()
        {
            MainPage mainPage = new MainPage(Driver)
                .RailPassesSearchClick();
            Assert.IsTrue(mainPage.requiredCountrySign.Displayed);
        }

        [Test]
        public void SuccessfulTrainSearch()
        {
            TripInfo trip = TripInfoCreator.SetValidInfo();
            TrainListPage mainPage = new MainPage(Driver)
                .InputTripInfo(trip)
                .PickDateAndTime()
                .ClickSearchButton();
            Assert.IsTrue(mainPage.listOfTrains.Displayed);
        }

        [Test]
        public void TryToPayForTicket()
        {
            TripInfo trip = TripInfoCreator.SetValidInfo();
            PassangerInfo passanger = PassangerInfoCreator.SetValidInfo();
            CustomerInfo customer = CustomerInfoCreator.SetValidInfo()
            CheckoutPage mainPage = new MainPage(Driver)
                .InputTripInfo(trip)
                .PickDateAndTime()
                .ClickSearchButton()
                .FirstTrainClick()
                .SelectFareButtonClick()
                .InputPassangerInformation(passanger)
                .AddToCart()
                .CheckoutButtonClick()
                .InputDeliveryInformation(customer)
                .ProceedToPaymentButtonClick()
                .InputCardDataAndPayClick(customer);

        }
    }
}
