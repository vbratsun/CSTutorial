using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TrySelenium
{
    public static class WebBrowser
    {
        private const string Key = "browser";

        public static InternetExplorerDriver Current
        {
            get 
            {
                if (!ScenarioContext.Current.ContainsKey(Key))
                {
                    IWebDriver driver = new InternetExplorerDriver();
                     ScenarioContext.Current[Key] = driver;
                }
                return ScenarioContext.Current[Key] as InternetExplorerDriver;
            }
        }
    }
}
