using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TrySelenium
{
    [Binding]
    public class NavigationSteps
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
            Thread.Sleep(4000);

        }
        
    }
}
