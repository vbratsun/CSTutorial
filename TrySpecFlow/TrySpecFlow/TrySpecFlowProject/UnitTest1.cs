using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace TrySpecFlowProject
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            Driver = new driver();
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Assert.IsTrue(Driver.Title == "Яндекс");           
        }
    }
}
