using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using ENSEKCandidateTest.Pages;

namespace WebpageAutomation.Steps
{
    [Binding]
    public sealed class LoginSteps
    {

        //Anti-Context Ingection Code
        LandingPage landingPage = null;



        //Step Definitions
        [Given(@"I launch the WebPage URL")]
        public void GivenILaunchTheWebPageURL()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ensekautomationcandidatetest.azurewebsites.net/");
            landingPage = new LandingPage(webDriver);
        }


        [Then(@"I should see Find Out More option")]
        public void ThenIShouldSeeFindOutMoreOption()
        {
            Assert.That(landingPage.IsFindOutMoreExists(), Is.True);
        }


        //Scenario 2
        [Given(@"I click on the About Link")]
        public void GivenIClickOnTheAboutLink()
        {
            landingPage.ClickAbout();
        }


        [Given(@"I click on Learn More Button")]
        public void GivenIClickOnTheLearnMoreButton()
        {
            landingPage.ClickFindOutMore();
        }

        [Then(@"I should see Our purpose is to accelerate")]
        public void ThenIShouldSeeOurPurposeIsToAccelerate()
        {
            Assert.That(landingPage.IsOurPurposeIsToAccelerateExists(), Is.True);
        }




        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}

