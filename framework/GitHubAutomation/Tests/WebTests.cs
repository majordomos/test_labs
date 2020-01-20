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
        public void FailedLoginAttemp() 
        {
            LoginInfo login = LoginInfoCreator.SetInvalidInfo();
            MainPage mainPage = new MainPage(Driver)
                .LoginMenuClick()
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
        public void RailPassSearchAttempt()
        {
            MainPage mainPage = new MainPage(Driver)
                .RailPassesSearchClick()
                .RailPassCountryFill()
                .RailPassesSearchButtonClick();
            Assert.IsTrue(mainPage.railPassSearchResult.Displayed);
        }

        [Test]
        public void RequiredDepartError()
        {
            TripInfo trip = TripInfoCreator.SetInvalidInfo();
            TrainListPage mainPage = new MainPage(Driver)
                .InputTripInfo(trip)
                .ClickSearchButton();
            Assert.AreEqual(mainPage.requiredDepartureDateSign.Displayed, false);
        }

        [Test]
        public void SuccessfulTrainSearch()
        {
            TripInfo trip = TripInfoCreator.SetValidInfo();
            TrainListPage mainPage = new MainPage(Driver)
                .InputTripInfo(trip)
                .PickDateAndTime()
                .ClickSearchButton()
                .WaitListOfTrains();

            Assert.IsTrue(mainPage.listOfTrains.Displayed);
        }
        //--------------------
        //[Test]
        //public void TryToPayForTicket()
        //{
        //    PassangerInfo passanger = PassangerInfoCreator.SetValidInfo();
        //    CustomerInfo customer = CustomerInfoCreator.SetValidInfo();
        //    TripInfo trip = TripInfoCreator.SetValidInfo();
        //    CheckoutPage mainPage = new MainPage(Driver)
        //        .InputTripInfo(trip)
        //        .PickDateAndTime()
        //        .ClickSearchButton()
        //        .FirstTrainClick()
        //        .SelectFareButtonClick()
        //        .InputPassangerInformation(passanger)
        //        .AddToCart()
        //        .CheckoutButtonClick()
        //        .InputDeliveryInformation(customer)
        //        .ProceedToPaymentButtonClick()
        //        .InputCardDataAndPayClick(customer);

        //}
    }
}
