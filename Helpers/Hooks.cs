using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT_CSharp.Configuration;
using DOT_CSharp.Hooks;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace DOT_CSharp.Test
{
    [Binding]
    public sealed class Hooks
    {
        private DriverHelper _driverHelper;
        public Hooks(DriverHelper driverHelper) => _driverHelper = driverHelper;

        public static ConfigSetting config;
        public static string configSettingPath = System.IO.Directory.GetParent(@"../../..").FullName + Path.DirectorySeparatorChar + "DOT_CSharp/Configuration/ConfigSetting.json";

        [BeforeScenario]
        public void BeforeScenario() {

            config = new ConfigSetting();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configSettingPath);
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);

            ChromeOptions option = new();
            option.AddArguments("--disable - gpu",
                      "--window-size=1920,1200",
                      "--ignore-certificate-errors",
                      "",
                      "--headless");

            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            Console.WriteLine("Setup");
            _driverHelper.Driver = new ChromeDriver();
            _driverHelper.Driver.Manage().Window.Maximize();
            _driverHelper.Driver.Navigate().GoToUrl(config.ApplicationURLBase+config.ApplicationURLDomain);
        }


        [AfterScenario]
        public void AfterScenario() {
            _driverHelper.Driver.Quit();
        }
    }

}

