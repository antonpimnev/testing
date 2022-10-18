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
    public class SortableDataTables : BaseTest, IDisposable
    {
        [TestMethod]
        public void SortableDataTables1()
        {
            By _sortableDataTables1 = By.XPath("//a[contains(text(),'Sortable Data Tables')]");
            By _sortableDataEmails = By.XPath("//td[@class='email']");

            ClickOnElement(_sortableDataTables1);
            Thread.Sleep(2000);

            IList<IWebElement> elements = driver.FindElements(_sortableDataEmails);
            foreach (IWebElement e in elements)
            {
                Console.WriteLine(e.Text);
            }
        }
    }
}

