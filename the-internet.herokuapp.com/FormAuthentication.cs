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
    public class FormAuthentication : BaseTest, IDisposable
    {
        [TestMethod]
        public void FormAuthentication1()
        {
            By _formAuthentication1 = By.XPath("//a[contains(text(),'Form Authentication')]");
            By _formAuthenticationLogin = By.XPath("//input[@id='username']");
            By _formAuthenticationPassword = By.XPath("//input[@id='password']");
            By _formAuthenticationLogButton = By.XPath("//i[contains(text(),'Login')]");
            By result = By.XPath("//h4[contains(text(),'Welcome to the Secure Area')]");
            By _formAuthenticationLogOutButton = By.XPath("//i[contains(text(),'Logout')]");
            By result2 = By.XPath("//div[contains(text(),'You logged out of the secure area')]");

            string login = "tomsmith";
            string pass = "SuperSecretPassword!";

            ClickOnElement(_formAuthentication1);
            Thread.Sleep(2000);
            ClickOnElement(_formAuthenticationLogin).SendKeys(login);
            ClickOnElement(_formAuthenticationPassword).SendKeys(pass);
            Thread.Sleep(1000);
            ClickOnElement(_formAuthenticationLogButton);
            Thread.Sleep(2000);

            Assert.IsTrue(FindElement(result).Displayed);

            Thread.Sleep(2000);
            ClickOnElement(_formAuthenticationLogOutButton);

            Assert.IsTrue(FindElement(result2).Displayed);
            Console.WriteLine(FindElement(result2).Text);
        }

    }
}

