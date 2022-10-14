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
    public class Hovers : BaseTest, IDisposable
    {
        [TestMethod]
        public void Hovers1()
        {
            By _hovers1 = By.XPath("//a[contains(text(),'Hovers')]");
            By _hoversFigure2 = By.XPath("//body/div[2]/div[1]/div[1]/div[2]");
            By _hoversResult = By.XPath("//h5[contains(text(),'name: user2')]");

            ClickOnElement(_hovers1);
            Thread.Sleep(2000);

            ClickOnElement(_hoversFigure2);
            Thread.Sleep(2000);

            bool result = driver.FindElement(_hoversResult).Displayed;
            Console.WriteLine(result);
        }
    }
}

