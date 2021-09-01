using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT_CSharp.Pages
{
    public class BaseClassPage
    {
        public IWebDriver Driver;
        public BaseClassPage(IWebDriver driver) => Driver = driver;


        /*
        * Clicking the Next button
        * -----------------------------------------------------------------------------------
        */
        public BaseClassPage ClickNext()
        {
            IWebElement nextWebElement = Driver.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_btnNext"));
            nextWebElement.Click();
            return this;
        }


        /*
        * Setting the Step Name from the page
        * -----------------------------------------------------------------------------------
        */
        public string GetStepName()
        {
            return GetStepWebElement().Text;
        }


        /*
        * Asserting there are no outstanding errors in Step 1
        * -----------------------------------------------------------------------------------
        */
        public void AssertNoErrorInStep1() {
            By step1ErrorWebElement =By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_ErrorSummary");
            Assert.IsFalse(IsElementPresent(step1ErrorWebElement));
        }



        /*
        * Verifying if the element is present on Page
        * -----------------------------------------------------------------------------------
        */
        public bool IsElementPresent(By by)
        {
            try
            {
                Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


        /*
        * Getters for Locators
        * -----------------------------------------------------------------------------------
        */
        private IWebElement GetStepWebElement()
        {
            return this.Driver.FindElement(By.ClassName("progress-bar-title"));
        }

    }
}
