using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace the_internet.herokuapp.com
{
    [TestClass]
    public class Test1 : BaseTest, IDisposable
    {
        [TestMethod]
        public void TC1_ABTesting()
        {
            By _abTesting1 = By.XPath("//a[contains(text(),'A/B Testing')]");
            By _abTestingExpected = By.XPath("//p[contains(text(),'Also known as split testing. This is a way in whic')]");

            ClickOnElement(_abTesting1);
            var text = FindElement(_abTestingExpected);
            Assert.IsNotNull(text);
        }

        [TestMethod]
        public void TC2_AddRemoveElements()
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

        public void handleAuth()
        {
            driver.Navigate().GoToUrl("https://" + username + ":" + password + "@" + "the-internet.herokuapp.com/basic_auth");
        }

        [TestMethod]
        public void TC3_BasicAuth()
        {
            By _textCongrats = By.XPath("//p[contains(text(),'Congratulations! You must have the proper credentials')]");

            Thread.Sleep(2000);
            handleAuth();
            //driver.SwitchTo().Alert().SendKeys(username + Keys.Tab + password + Keys.Tab + Keys.Enter);
            Thread.Sleep(5000);
            var textCongrats = FindElement(_textCongrats).ToString();
            String expected = "Congratulations! You must have the proper credentials";
            Assert.AreEqual(textCongrats.Trim(),expected);
            //Почему то не работает. Надо разобраться...
        }
    }
}

