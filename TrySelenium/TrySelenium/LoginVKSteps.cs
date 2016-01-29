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
            var editBoxText = WebBrowser.Current.FindElement(By.Id("email")).GetAttribute("value");
            Console.WriteLine(editBoxText);
            Assert.AreEqual(p0,errorMessage);
        }

        [Given(@"user opens messages link")]
        public void GivenUserOpensMessagesLink()
        {
            var messages = WebBrowser.Current.FindElement(By.Id("l_msg"));
            messages.Click();

            var dialogs = WebBrowser.Current.FindElement(By.XPath("//*[@id='tab_dialogs']/a/b[3]"));
            var dialogsText = dialogs.Text;
            Console.WriteLine(dialogsText);
        }

        [When(@"user opens '(.*)'")]
        public void WhenUserOpensMyPage(string openingTab)
        {
            switch (openingTab)
            {
                case "My Page":
                var myPage = WebBrowser.Current.FindElement(By.XPath("//*[@id='myprofile']/span"));
                myPage.Click();
                    break;

                case "My Friends":
                var myFriends = WebBrowser.Current.FindElement(By.XPath("//*[@id='l_fr']/a/span/span[2]"));
                myFriends.Click();
                    break;
            }
        }

        [Then(@"the page contains '(.*)'")]
        public void ThenThePageContainsSmileСтаниславович(string openedTab)
        {
            switch (openedTab)
            { 
                case "Smile Станиславович":
                    var owner = WebBrowser.Current.FindElement(By.XPath("//*[@id='profile_info']/h4/div[1]")).Text;
                    Assert.AreEqual(openedTab, owner);
                    break;

                case "Все друзья":
                    var friends = WebBrowser.Current.FindElement(By.XPath("//*[@id='tab_all']/a/b[3]")).Text;
                    Assert.AreEqual(openedTab, friends);
                    break;
            }
        }

    }
}
