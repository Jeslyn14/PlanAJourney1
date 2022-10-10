using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PlanAJourney1.Hooks
{
    [Binding]
    public sealed class hooks1: Driverhelper
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("Start-maximized");
            option.AddArguments("--disable-gpu");
            option.AddArguments("--headless");

            new DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver(option);
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
