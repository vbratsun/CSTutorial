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

            var signOutButton = ieDriver.FindElement(_signOutButtonLocator);
            signOutButton.Click();
            Thread.Sleep(9000);

            var loginFormHeader = ieDriver.FindElement(_loginFormHeaderLocator);
            Assert.AreEqual("Вход в систему", loginFormHeader.Text);

            ieDriver.Dispose();
        }
    }
}