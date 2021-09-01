using BoDi;
using DOT_CSharp.Configuration;
using DOT_CSharp.Hooks;
using DOT_CSharp.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DOT_CSharp.StepDefinitions
{
    [Binding]
    public class BaseSteps
    {
        private DriverHelper _driverHelper;
        BaseClassPage basePage;

        public BaseSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            basePage = new BaseClassPage(_driverHelper.Driver);
        }


        [Given(@"User navigates to Unregistered Vehicle Permit URL")]
        public void GivenUserNavigatesToUnregisteredVehiclePermitURL()
        {
            Assert.AreEqual("Get an Unregistered Vehicle Permit : VicRoads", _driverHelper.Driver.Title);
        }


        [When(@"Clicks on Next")]
        public void WhenClicksOnNext()
        {
            basePage.ClickNext();
        }


        [Then(@"'(.*)' step is displayed")]
        public void StepIsDisplayed(string expectedStepName)
        {
            string actualStepName = basePage.GetStepName();
            Assert.AreEqual(expectedStepName, actualStepName);
        }

    }
}
