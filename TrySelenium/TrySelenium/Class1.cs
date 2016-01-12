using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using NUnit.Framework;

namespace TrySelenium
{
    [TestFixture]
    public class Class1
    {

        IWebDriver driver;

        [SetUp]

        public void Setup()
        {
            driver = new InternetExplorerDriver();
        }

        [TearDown]

        public void Teardown()
        {
            driver.Quit();
        }
        
        [Test]

        public void SearchYandex()
        {

            //Navigate to the site

            driver.Navigate().GoToUrl("http://www.yandex.ru");

            //Find the Element and create an object so we can use it

            IWebElement queryBox = driver.FindElement(By.Name("text"));

            //Work with the Element that's on the page

            queryBox.SendKeys("Selenium");

            //queryBox.SendKeys(Keys.ArrowDown);

            queryBox.Submit();

            //Check that the Title is what we are expecting
            
            Assert.True(driver.Title.IndexOf("Selenium") > -1);

        }

    }
}
