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
    public class ForgotPassword : BaseTest, IDisposable
    {
        [TestMethod]
        public void ForgotPassword1()
        {
            By _forgotPassword1 = By.XPath("//a[contains(text(),'Forgot Password')]");
            By _forgotPasswordInput = By.XPath("//input[@id='email']");
            By _forgotPasswordRetrieve = By.XPath("//i[contains(text(),'Retrieve password')]");
            By result = By.XPath("//h1[contains(text(),'Internal Server Error')]");

            string email = "1@mail.ru";

            ClickOnElement(_forgotPassword1);
            Thread.Sleep(2000);
            ClickOnElement(_forgotPasswordInput).SendKeys(email);
            Thread.Sleep(1000);
            ClickOnElement(_forgotPasswordRetrieve);
            Thread.Sleep(2000);

            Assert.IsNotNull(FindElement(result));
        }

    }
}

