using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace TrySelenium
{
    [Binding]
    public class OpenVkWebSteps
    {
        [Given(@"user opens messages section on VK website")]
        public void GivenUserOpensMessagesSectionOnVKWebsite()
        {
            IWebDriver driver = new InternetExplorerDriver();

            ScenarioContext.Current.Add("driver", driver);

            driver.Navigate().GoToUrl("http://vk.com/im");
                        
        }
        
        [Given(@"user brings up the dialog with friend")]
        public void GivenUserBringsUpTheDialogWithFriend()
        {
            //var driver = ScenarioContext.Current.Get<IWebDriver>(driver); //??????????????????
            var driver = ScenarioContext.Current["driver"] as IWebDriver;

            Thread.Sleep(1000);

            driver.FindElement(By.Id("im_dialog18744588")).Click(); 
        }
        
        [When(@"some text '(.*)' is typed in")]
        public void WhenSomeTextIsTypedIn(string p0)
        {
            var driver = ScenarioContext.Current["driver"] as IWebDriver;

            Thread.Sleep(1000);

            var messageEditBox = driver.FindElement(By.Id("im_editable18744588"));

            messageEditBox.SendKeys(p0);

            ScenarioContext.Current.Add("sentMessage", p0);
        }
        
        [When(@"Send button is clicked")]
        public void WhenSendButtonIsClicked()
        {
            var driver = ScenarioContext.Current["driver"] as IWebDriver;
            
            Thread.Sleep(1000);

            driver.FindElement(By.Id("im_send")).Click();
        }
        
        [Then(@"message is displayed in message section")]
        public void ThenMessageIsDisplayedInMessageSection()
        {
            var driver = ScenarioContext.Current["driver"] as IWebDriver;

            Thread.Sleep(1000);

            string expectedText = ScenarioContext.Current["sentMessage"] as string;
            
            Thread.Sleep(2000);

            var sentText = driver.FindElement(By.XPath("//*[contains(text(), 'Hello my friend')]")).Text;

            Assert.AreEqual(expectedText, sentText);
            
        }
    }
}
