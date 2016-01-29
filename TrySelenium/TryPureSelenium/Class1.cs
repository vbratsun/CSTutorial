using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using NUnit.Framework;
using System.Threading;

namespace TrySelenium
{
    [TestFixture]
    public class Class1
    {
        IWebDriver driver = new InternetExplorerDriver();
        
        [Test]       
        public void OpenVK()
        {

            driver.Navigate().GoToUrl("http://vk.com/");
            
            Thread.Sleep(3000);

            By _titleLocator = By.XPath("//*[@id='title']");

            string pageTitleText = driver.FindElement(_titleLocator).Text;
           
            string expectedText = "Добро пожаловать";

            Assert.AreEqual(pageTitleText, expectedText);

        }

    }
}
