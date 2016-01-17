using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eVelopersTestTaskPart1
{
    [TestFixture]
    public class TransportMonitoring
    {
        #region
        //credentials
        private const string _login = "demo";
        private const string _password = "demo";

        //elements locators
        private readonly By _loginEditBoxElLocator = By.Id("loginuname-inputEl");
        private readonly By _passwordEditBoxElLocator = By.Id("loginpassword-inputEl");
        private readonly By _signInButtonLocator = By.Id("button-1012-btnEl");
        private readonly By _signOutButtonLocator = By.Id("logoutButton");
        private readonly By _loginFormHeaderLocator = By.Id("login-panel_header_hd-textEl");
        private readonly By _observeObjectsTabLocator = By.Id("tab-1173-btnEl");
        private readonly By _isOnlineLocator = By.XPath("//*[@id='ext-gen1774']/td[2]/div");
        #endregion

        IWebDriver ieDriver = new InternetExplorerDriver();

        [Test]
        public void LoginTest()
        {
            ieDriver.Navigate().GoToUrl("http://online.transportmonitoring.ru/");
            Thread.Sleep(9000);

            var loginEditBoxEl = ieDriver.FindElement(_loginEditBoxElLocator);            
            loginEditBoxEl.SendKeys(_login);

            var passwordEditBoxEl = ieDriver.FindElement(_passwordEditBoxElLocator);
            passwordEditBoxEl.SendKeys(_password);

            var signInButton = ieDriver.FindElement(_signInButtonLocator);
            signInButton.Click();
            Thread.Sleep(9000);

            var observeObjectsTab = ieDriver.FindElement(_observeObjectsTabLocator);
            observeObjectsTab.Click();
            Thread.Sleep(9000);

            var isOnline = ieDriver.FindElement(_isOnlineLocator).Text;
            Assert.AreEqual("Да", isOnline);

            var signOutButton = ieDriver.FindElement(_signOutButtonLocator);
            signOutButton.Click();
            Thread.Sleep(9000);

            var loginFormHeader = ieDriver.FindElement(_loginFormHeaderLocator);
            Assert.AreEqual("Вход в систему", loginFormHeader.Text);

            ieDriver.Dispose();
        }
    }
}