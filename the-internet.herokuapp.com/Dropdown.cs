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
    public class Dropdown : BaseTest, IDisposable
    {
        [TestMethod]
        public void Dropdown1()
        {
            By _dropdown1 = By.XPath("//a[contains(text(),'Dropdown')]");
            By _dropdownList = By.XPath("//select[@id='dropdown']");
            By _dropdownList1 = By.XPath("//option[contains(text(),'Option 1')]");
            By _dropdownList2 = By.XPath("//option[contains(text(),'Option 2')]");
            By _result = By.XPath("//option[contains(text(),'Option 2')] | //option[@selected='selected']");

            ClickOnElement(_dropdown1);
            Thread.Sleep(2000);
            ClickOnElement(_dropdownList);
            Thread.Sleep(2000);
            ClickOnElement(_dropdownList1);
            Thread.Sleep(2000);
            ClickOnElement(_dropdownList2);

            Assert.IsNotNull(_result);
        }

    }
}

