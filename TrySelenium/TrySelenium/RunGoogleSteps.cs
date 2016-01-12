using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using TechTalk.SpecFlow;

namespace TrySelenium
{
    [Binding]
    public class RunGoogleSteps
    {
        [Given(@"open the google web site")]
        public void GivenOpenTheGoogleWebSite()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://www.google.com/");
            //ScenarioContext.Current.Pending();
        }
    }
}
