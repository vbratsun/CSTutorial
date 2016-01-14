using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace TrySelenium
{
    [Binding]
    public class LoginVKSteps
    {
        [Given(@"user opens vk start page")]
        public void GivenUserOpensVkStartPage()
        {
            //1st way without refactoring:
            //IWebDriver driver = new InternetExplorerDriver();
            //ScenarioContext.Current.Add("driver", driver);
            //driver.Navigate().GoToUrl("http://vk.com");
            
            //2nd variant after adding WebBrowser class
            WebBrowser.Current.Navigate().GoToUrl("http://vk.com");

        }
        
        [Given(@"email field is filled in with '(.*)'")]
        public void GivenEmailFieldIsFilledInWith(string login)
        {
            //1st way without refactoring:
            //IWebDriver driver = ScenarioContext.Current["driver"] as IWebDriver;
            //IWebElement loginEditbox = driver.FindElement(By.Id("quick_email"));
            
            //2nd variant after adding WebBrowser class
            var loginEditbox = WebBrowser.Current.FindElement(By.Id("quick_email"));
            loginEditbox.Clear();
            loginEditbox.SendKeys(login);
        }
        
        [Given(@"password field is filled in with '(.*)'")]
        public void GivenPasswordFieldIsFilledInWith(string password)
        {
            //1st way without refactoring:
            //var driver = ScenarioContext.Current["driver"] as IWebDriver;
            //IWebElement passwordEditbox = driver.FindElement(By.Id("quick_pass"));

            //2nd variant after adding WebBrowser class
            var passwordEditbox = WebBrowser.Current.FindElement(By.Id("quick_pass"));
            passwordEditbox.Clear();
            Thread.Sleep(4000);
            passwordEditbox.SendKeys(password);
        }
        
        [When(@"sign in button is clicked")]
        public void WhenSignInButtonIsClicked()
        {
            //1st way without refactoring:
            //var driver = ScenarioContext.Current["driver"] as IWebDriver;
            //Thread.Sleep(4000);
            //IWebElement signInButton = driver.FindElement(By.Id("quick_login_button"));

            //2nd variant after adding WebBrowser class
            var signInButton = WebBrowser.Current.FindElement(By.Id("quick_login_button"));
            signInButton.Click();
        }
        
        [Then(@"user loged in")]
        public void ThenUserLogedIn()
        {
            //1st way without refactoring:
            //var driver = ScenarioContext.Current["driver"] as IWebDriver;
            //Thread.Sleep(4000);
            //IWebElement userAvatar = driver.FindElement(By.Id("profile_photo_link"));

            //2nd variant after adding WebBrowser class
            var userAvatar = WebBrowser.Current.FindElement(By.Id("profile_photo_link"));
        }
        
        [Then(@"url contains account id '(.*)'")]
        public void ThenUrlContainsAccountId(string p0)
        {
            //1st way without refactoring:
            //var driver = ScenarioContext.Current["driver"] as IWebDriver;
            //string currentPageURL = driver.Url;

            //2nd variant after adding WebBrowser class
            string currentPageURL = WebBrowser.Current.Url;
            string expectedURL = "http://vk.com/id" + p0;
            
            Console.WriteLine("expected: " + expectedURL);
            Console.WriteLine("current: " + currentPageURL);

            Assert.AreEqual(expectedURL, currentPageURL);
        }

        [Then(@"close browser window")]
        public void ThenCloseBrowserWindow()
        {
            //1st way without refactoring:
            //var driver = ScenarioContext.Current["driver"] as IWebDriver;
            //driver.Quit();

            //2nd variant after adding WebBrowser class
            WebBrowser.Current.Quit();
        }

        [Then(@"the '(.*)' text is displayed")]
        public void ThenTheTextIsDisplayed(string p0)
        {
            //1st way without refactoring:
            //var driver = ScenarioContext.Current["driver"] as IWebDriver;
            //string errorMessage = driver.FindElement(By.XPath("//*[@id='message']/b[1]")).Text;

            //2nd variant after adding WebBrowser class
            string errorMessage = WebBrowser.Current.FindElement(By.XPath("//*[@id='message']/b[1]")).Text;
            Assert.AreEqual(p0,errorMessage);
        }

    }
}
