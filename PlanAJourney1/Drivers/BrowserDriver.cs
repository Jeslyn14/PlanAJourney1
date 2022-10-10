using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace PlanAJourney1.Drivers
{
    [Binding]
    public class BrowserDriver : IDisposable
    {
        private ChromeDriver? chromeDriver;
        public BrowserDriver() => chromeDriver = new ChromeDriver();

        public void Dispose()
        {
            if (chromeDriver != null)
            {
                chromeDriver.Dispose();
                chromeDriver = null;
            }
        }
    }
}
