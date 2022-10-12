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
    public class DynamicControls : BaseTest, IDisposable
    {
        [TestMethod]
        public void DynamicControls1()
        {
            By _dynamicControls1 = By.XPath("//a[contains(text(),'Dynamic Controls')]");

            By _dynamicControls2 = By.XPath("//input[@label='blah']");
            By _dynamicControls3 = By.XPath("//button[contains(text(),'Remove')]");
            By _dynamicControls4 = By.XPath("//button[contains(text(),'Enable')]");
            By _dynamicControls5 = By.XPath("//input[@type='text']");
            By _dynamicControls6 = By.XPath("//button[contains(text(),'Disable')]");

            By _result1 = By.XPath("//p[contains(text(),'It's gone!')]");
            By _result2 = By.XPath("//p[contains(text(),'It's enabled!')]");
            By _result3 = By.XPath("//p[contains(text(),'It's disabled!')]");

            ClickOnElement(_dynamicControls1);
            Thread.Sleep(2000);

            ClickOnElement(_dynamicControls2);
            Thread.Sleep(2000);
            ClickOnElement(_dynamicControls3);
            Thread.Sleep(4000);

            Assert.IsNotNull(_result1);

            Thread.Sleep(2000);
            ClickOnElement(_dynamicControls4);
            Thread.Sleep(2000);
            ClickOnElement(_dynamicControls5);
            Thread.Sleep(4000);

            Assert.IsNotNull(_result2);

            FindElement(_dynamicControls5).SendKeys("Pew!pew!pew!");
            Thread.Sleep(2000);
            ClickOnElement(_dynamicControls6);
            Thread.Sleep(4000);

            Assert.IsNotNull(_result3);
        }

    }
}

