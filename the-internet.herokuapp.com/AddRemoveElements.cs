using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace the_internet.herokuapp.com
{
    [TestClass]
    public class AddRemoveElements : BaseTest, IDisposable
    {
        [TestMethod]
        public void AddRemoveElements1()
        {
            By _AddRemoveElements1 = By.XPath("//a[contains(text(),'Add/Remove Elements')]");
            By _AddElement = By.XPath("//button[contains(text(),'Add Element')]");
            By _RemoveElement = By.XPath("//button[contains(text(),'Delete')]");

            ClickOnElement(_AddRemoveElements1);
            Thread.Sleep(2000);
            ClickOnElement(_AddElement);
            ClickOnElement(_AddElement);
            ClickOnElement(_AddElement);
            Thread.Sleep(2000);
            ClickOnElement(_RemoveElement);
            //TODO: Реализовать удаление второго/произвольного(random.Math) элемента в найденном массиве
            var count = driver.FindElements(_RemoveElement).Count;
            Assert.IsNotNull(count);
        }
    }
}

