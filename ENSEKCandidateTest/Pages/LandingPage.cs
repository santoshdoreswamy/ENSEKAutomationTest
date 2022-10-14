using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace ENSEKCandidateTest.Pages
{
    public class LandingPage
    {
        public IWebDriver WebDriver { get; }

        public LandingPage(OpenQA.Selenium.IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI Elements
        //Scenario 1
        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));

        public IWebElement lnkFindOutMore => WebDriver.FindElement(By.LinkText("Find out more »"));

        public bool IsFindOutMoreExists() => lnkFindOutMore.Displayed;


        //Scenario 2
        public IWebElement lnkAbout => WebDriver.FindElement(By.LinkText("About"));

        public IWebElement btnFindOutMoreAboutUs => WebDriver.FindElement(By.CssSelector(".btn-primary.btn-lg"));
      
        public IWebElement TxtOurPurposeIsToAccelerate => WebDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div/div[1]/h2"));

        public void ClickAbout() => lnkAbout.Click();

        public void ClickFindOutMore() => btnFindOutMoreAboutUs.Click();
       
        public bool IsOurPurposeIsToAccelerateExists() => TxtOurPurposeIsToAccelerate.Displayed;

    }
}

