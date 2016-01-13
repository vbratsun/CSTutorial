using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace TrySelenium
{
    [Binding]
    public class RunGoogleSteps
    {
        private IWebDriver driver;

        [Given(@"open the google web site")]
        public void GivenOpenTheGoogleWebSite()
        {
            driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://www.google.com/");            
        }

        [When(@"the text '(.*)' is typed in search box")]
        public void WhenTheTextIsTypedInSearchBox(string p0)
        {
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys(p0);
        }

        [When(@"search button is clicked")]
        public void WhenSearchButtonIsClicked()
        {
            IWebElement search = driver.FindElement(By.Name("btnG"));
            search.Click();
        }

        [Then(@"opened page contains '(.*)' text")]
        public void ThenOpenedPageContainsText(string p0)
        {
            Thread.Sleep(3000);
            IWebElement result = driver.FindElement(By.Id("resultStats"));
            string text = result.Text;

            Assert.AreEqual(p0, text);

        }

        //ScenarioContext.Current.Add("key",key);
        //newKey = ScenarioContext.Current.Get<key>(key);
    }
}
