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
            IWebDriver driver = new InternetExplorerDriver();
            ScenarioContext.Current.Add("driver", driver);
            driver.Navigate().GoToUrl("http://vk.com");
            
        }
        
        [Given(@"email field is filled in with '(.*)'")]
        public void GivenEmailFieldIsFilledInWith(string login)
        {
            var driver = ScenarioContext.Current["driver"] as IWebDriver;

            IWebElement loginEditbox = driver.FindElement(By.Id("quick_email"));
            loginEditbox.Clear();
            loginEditbox.SendKeys(login);
        }
        
        [Given(@"password field is filled in with '(.*)'")]
        public void GivenPasswordFieldIsFilledInWith(string password)
        {
            var driver = ScenarioContext.Current["driver"] as IWebDriver;

            IWebElement passwordEditbox = driver.FindElement(By.Id("quick_pass"));
            passwordEditbox.Clear();
            Thread.Sleep(4000);
            passwordEditbox.SendKeys(password);
        }
        
        [When(@"sign in button is clicked")]
        public void WhenSignInButtonIsClicked()
        {
            var driver = ScenarioContext.Current["driver"] as IWebDriver;
            Thread.Sleep(4000);

            IWebElement signInButton = driver.FindElement(By.Id("quick_login_button"));
            signInButton.Click();
        }
        
        [Then(@"user loged in")]
        public void ThenUserLogedIn()
        {
            var driver = ScenarioContext.Current["driver"] as IWebDriver;

            Thread.Sleep(4000);
            //IWebElement userAvatar = driver.FindElement(By.Id("profile_photo_link"));
            
            //Assert.();
        }
        
        [Then(@"url contains account id '(.*)'")]
        public void ThenUrlContainsAccountId(string p0)
        {
            var driver = ScenarioContext.Current["driver"] as IWebDriver;

            string currentPageURL = driver.Url;

            Console.WriteLine(currentPageURL);


        }
    }
}
