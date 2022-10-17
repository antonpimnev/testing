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
    public class JavaScriptOnloadEventError : BaseTest, IDisposable
    {
        [TestMethod]
        public async Task JavaScriptOnloadEventError1Async()
        {
            By _javaScriptOnloadEventError1 = By.XPath("//a[contains(text(),'JavaScript onload event error')]");

            // Странно как то работает
            // https://www.selenium.dev/documentation/webdriver/bidirectional/bidi_api/
            // TODO: Standard Output: JS exception message: Uncaught

            List<string> exceptionMessages = new List<string>();
            IJavaScriptEngine monitor = new JavaScriptEngine(driver);
            monitor.JavaScriptExceptionThrown += (sender, e) =>
            {
                exceptionMessages.Add(e.Message);
            };

            await monitor.StartEventMonitoring();

            ClickOnElement(_javaScriptOnloadEventError1);
            Thread.Sleep(2000);

            foreach (string message in exceptionMessages)
            {
                Console.WriteLine("JS exception message: {0}", message);
            }

        }
    }
}

