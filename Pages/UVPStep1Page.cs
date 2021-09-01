using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DOT_CSharp.Pages
{
    public class UVPStep1Page
    {

        public IWebDriver Driver;

        public UVPStep1Page(IWebDriver driver) => Driver = driver;

        /*
        * Setting the Vehicle Type
        * -----------------------------------------------------------------------------------
        */
        public UVPStep1Page SelectVehicleType(string VehicleType)
        {
            var selectTest = new SelectElement(GetVehicleTypeWebElement());
            selectTest.SelectByValue(VehicleType);
            return this;
        }


        /*
        * Setting the Vehicle Sub-Type / Capacity
        * -----------------------------------------------------------------------------------
        */
        public UVPStep1Page SelectSubTypeOrCapacity(string SubTypeOrCapacity)
        {
            if (SubTypeOrCapacity != null) {
                var selectTest = new SelectElement(GetSubTypeWebElement());
                selectTest.SelectByValue(SubTypeOrCapacity);
            }
            return this;
        }


        /*
        * Setting the Address
        * -----------------------------------------------------------------------------------
        */
        public UVPStep1Page SetAddress(string Address)
        {
            GetAddressWebElement().Clear();
            GetAddressWebElement().SendKeys(Address);
            return this;
        }


        /*
        * Setting the Permit Start Date
        * -----------------------------------------------------------------------------------
        */
        public UVPStep1Page SetPermitStartDate(string PermitStartDate)
        {
            GetPermitDateWebElement().Clear();
            GetPermitDateWebElement().SendKeys(PermitStartDate);
            return this;
        }

        
        /*
        * Setting the Permit Duration
        * -----------------------------------------------------------------------------------
        */
        public UVPStep1Page SelectPermitDuration(String PermitDurationInDays)
        {
            var selectTest = new SelectElement(GetPermitDurationWebElement());
            selectTest.SelectByValue(PermitDurationInDays);
            return this;
        }


        /*
        * Clicking on Calculate Button
        * -----------------------------------------------------------------------------------
        */
        public UVPStep1Page ClickCalculate()
        {
            GetCalculateWebElement().Click();
            return this;
        }


        /*
        * Getters for Locators
        * -----------------------------------------------------------------------------------
        */

        private IWebElement GetVehicleTypeWebElement()
        {
            return this.Driver.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_VehicleType_DDList"));
        }

        private IWebElement GetSubTypeWebElement()
        {
            return this.Driver.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_PassengerVehicleSubType_DDList"));
        }

        private IWebElement GetAddressWebElement()
        {
            return this.Driver.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_AddressLine_SingleLine_CtrlHolderDivShown"));
        }

        private IWebElement GetPermitDateWebElement()
        {
            return this.Driver.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_PermitStartDate_Date"));
        }

        private IWebElement GetPermitDurationWebElement()
        {
            return this.Driver.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_PermitDuration_DDList"));
        }

        private IWebElement GetCalculateWebElement()
        {
            return this.Driver.FindElement(By.LinkText("Calculate"));
        }
    }

}
