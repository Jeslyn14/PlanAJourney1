using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace PlanAJourney1.Steps
{
    [Binding]
    class PlanAJourneyStepDefinitions: Driverhelper
    {
        private string tosearchstring;
        private string fromsearchstring;
        private string p1;


        [Given(@"User navigated to the TFL home page\.")]
        public void GivenUserNavigatedToTheTFLHomePage_()
        {
            Driver.Navigate().GoToUrl("https://tfl.gov.uk/");
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.Title.ToLower().Contains("Keeping London moving - Transport for London"));
        }

        [Given(@"User is able to view the Plan a journey widget")]
        public void GivenUserIsAbleToViewThePlanAJourneyWidget()
        {
            Assert.IsTrue(Driver.FindElement(By.Id("hp - journey - planner")).Displayed);
        }

        [Given(@"User is in TFL homepage")]
        public void GivenUserIsInTFLHomepage()
        {
            Assert.IsTrue(Driver.Title.ToLower().Contains("Keeping London moving - Transport for London"));
        }

        [Given(@"User is able to view from and to search fields")]
        public void GivenUserIsAbleToViewFromAndToSearchFields()
        {
            Assert.IsTrue(Driver.FindElement(By.Id("InputFrom")).Displayed);
            Assert.IsTrue(Driver.FindElement(By.Id("InputTo")).Displayed);
        }

        [Given(@"User is able to view Planajourney button")]
        public void GivenUserIsAbleToViewPlanajourneyButton()
        {
            Assert.IsTrue(Driver.FindElement(By.Id(" plan - journey - button")).Displayed);
        }

        [When(@"User Clicks on Planmyjourneybutton")]
        public void WhenUserClicksOnPlanmyjourneybutton()
        {
            var Planajourneybutton = Driver.FindElement(By.Id(" plan - journey - button"));
            Planajourneybutton.Click();
        }

        [Then(@"MandatoryUser message should be displayed\.")]
        public void ThenMandatoryUserMessageShouldBeDisplayed_()
        {
            Assert.IsTrue(Driver.FindElement(By.Id("InputFrom-error")).Displayed);
            Assert.IsTrue(Driver.FindElement(By.Id("InputTo-error")).Displayed); 
        }

        [Given(@"User selects the Piccadilly Circus")]
        public void GivenUserSelectsThePiccadillyCircus(string fromsearchstring)
        {
            this.fromsearchstring = fromsearchstring.ToLower();
            var searchInputBox = Driver.FindElement(By.Id("InputFrom"));
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.FindElement(By.Id("InputFrom")).Selected);
        }

        [Given(@"User select the Wembley Central")]
        public void GivenUserSelectTheWembleyCentral(string tosearchstring)
        {
            this.tosearchstring = tosearchstring.ToLower();
            var searchInputBox = Driver.FindElement(By.Id("InputTo"));
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.FindElement(By.Id("InputTo")).Selected);
        }

        [Then(@"User should be navigated to the Journey result page")]
        public void ThenUserShouldBeNavigatedToTheJourneyResultPage()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.Title.ToLower().Contains("Journey results - Transport for London"));
        }

        [Then(@"user should be able to view the various transport options\.")]
        public void ThenUserShouldBeAbleToViewTheVariousTransportOptions_()
        {
            Assert.IsTrue(Driver.FindElement(By.Name("JourneyTypePlaceHolder")).Displayed);
        }

        [Given(@"User selects the from location as ""(.*)""")]
        public void GivenUserSelectsTheFromLocationAs(string p0)
        {
            this.p1 = p0.ToLower();
            var searchInputBox = Driver.FindElement(By.Id("InputFrom"));
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.FindElement(By.Id("InputFrom")).Selected);
        }

        [Given(@"User selects the To location as ""(.*)""")]
        public void GivenUserSelectsTheToLocationAs(string p0)
        {
            this.p1 = p0.ToLower();
            var searchInputBox = Driver.FindElement(By.Id("InputFrom"));
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.FindElement(By.Id("InputFrom")).Selected);
        }

        [Given(@"User clicks on Planmyjourner button")]
        public void GivenUserClicksOnPlanmyjournerButton()
        {
            var Planmyjourneybutton = Driver.FindElement(By.Id(" plan - journey - button"));
            Planmyjourneybutton.Click();
        }

        [Given(@"User is navigated to the Journey result page")]
        public void GivenUserIsNavigatedToTheJourneyResultPage()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.Title.ToLower().Contains("Journey results - Transport for London"));
        }

        [Given(@"User should be able to view the various transport options\.")]
        public void GivenUserShouldBeAbleToViewTheVariousTransportOptions_()
        {
            Assert.IsTrue(Driver.FindElement(By.Name("JourneyTypePlaceHolder")).Displayed);
        }

        [Then(@"Edit Journey link should be available\.")]
        public void ThenEditJourneyLinkShouldBeAvailable_()
        {
            Assert.IsTrue(Driver.FindElement(By.ClassName("edit - journey")).Displayed);
        }

        [When(@"User clicks on Edit journey link")]
        public void WhenUserClicksOnEditJourneyLink()
        {
            var editjourneyclick = Driver.FindElement(By.ClassName("edit - journey"));
            editjourneyclick.Click();
        }

        [Then(@"User should be navigated to Edit journey panel\.")]
        public void ThenUserShouldBeNavigatedToEditJourneyPanel_()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.FindElement(By.Id("plan-a-journey")).Displayed);
        }

        [When(@"User selects the Sudbury Hill Harrow Rail Station")]
        public void WhenUserSelectsTheSudburyHillHarrowRailStation(String s1)
        {
            this.fromsearchstring = s1.ToLower();
            var searchInputBox = Driver.FindElement(By.Id("InputFrom"));
            searchInputBox.SendKeys(fromsearchstring);
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.FindElement(By.Id("InputFrom")).Selected);
        }

        [When(@"User selects the (.*)")]
        public void WhenUserSelectsThe(string p0)
        {
            this.tosearchstring = p0.ToLower();
            var searchInputBox = Driver.FindElement(By.Id("InputTo"));
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.FindElement(By.Id("InputTo")).Selected);
            searchInputBox.SendKeys(tosearchstring);
        }

        [When(@"User clicks on Update Journeybutton")]
        public void WhenUserClicksOnUpdateJourneybutton()
        {
            var updatejourneyclick = Driver.FindElement(By.ClassName("plan-journey-button"));
            updatejourneyclick.Click();
        }

        [Then(@"User Should be able to view journey result based on updated journey option\.")]
        public void ThenUserShouldBeAbleToViewJourneyResultBasedOnUpdatedJourneyOption_()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.FindElement(By.Name("JourneyTypePlaceHolder")).Displayed);
        }

        [Then(@"user should be able to invaliderror message")]
        public void ThenUserShouldBeAbleToInvaliderrorMessage()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Assert.IsTrue(Driver.FindElement(By.ClassName("field - validation - error")).Displayed);
        }

        [Given(@"User clicks on recents tab\.")]
        public void GivenUserClicksOnRecentsTab_()
        {
            Assert.IsTrue(Driver.FindElement(By.Id("jp-recent-tab-jp")).Displayed);
        }

        [Then(@"User should be able to view the recent search journeys\.")]
        public void ThenUserShouldBeAbleToViewTheRecentSearchJourneys_()
        {
            Assert.IsTrue(Driver.FindElement(By.Id("jp-recent-content-jp-")).Displayed);
        }

    }
}
