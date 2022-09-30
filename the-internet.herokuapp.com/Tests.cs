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
            public void TC1()
            {
            By _1 = By.XPath("//a[contains(text(),'A/B Testing')]");
            //By _docPreviewCloseBtn = By.XPath("//div[@id='viewer']");

            //GoToUrl(_siteUrl);
            ClickOnElement(_1);
            Thread.Sleep(5000);

            }
        }
        

}

