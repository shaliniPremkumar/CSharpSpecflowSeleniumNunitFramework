using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using DOT_CSharp.Hooks;
using DOT_CSharp.Pages;

namespace DOT_CSharp.StepDefinitions
{
    [Binding]
    public class UnregisteredVehiclePermitStep1
    {
        private DriverHelper _driverHelper;
        UVPStep1Page step1Page;

        public UnregisteredVehiclePermitStep1(DriverHelper driverHelper) {
            _driverHelper = driverHelper;
            step1Page = new UVPStep1Page(_driverHelper.Driver);
        }


        [When(@"User enters the mandatory details (.*), (.*), (.*), (.*) and (.*) in Step 1 of 7: Calculate Fee")]
        public void UserEntersTheMandatoryDetailsAndInStepOfCalculateFee(string VehicleType, string SubTypeOrCapacity, string Address, string PermitStartDate, string PermitDurationInDays)
        {
            step1Page.SelectVehicleType(VehicleType)
                .SelectSubTypeOrCapacity(SubTypeOrCapacity)
                .SetAddress(Address)
                .SetPermitStartDate(PermitStartDate)
                .SelectPermitDuration(PermitDurationInDays);
        }


        [When(@"User Clicks on Calculate")]
        public void WhenUserClicksOnCalculate()
        {
            step1Page.ClickCalculate(); ;
        }

    }
}
