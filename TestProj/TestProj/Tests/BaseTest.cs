using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProj.Tests
{
    public class BaseTest
    {

        public IWebDriver Driver;

        public void InitializeDriver(bool isHeadless)
        {
            var options = new ChromeOptions();
            options.SetLoggingPreference(LogType.Browser, LogLevel.All);
            options.AddArgument("--start-maximized");
            options.AddArgument("--ignore-certificate-errors");

            if (isHeadless)
            {
                options.AddArgument("--headless");
                options.AddArgument("--window-size=1920,1080");
            }

            Driver = new ChromeDriver(options);

            Driver.Manage().Window.Maximize();
          

        }
    }
}
