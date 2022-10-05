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
    public class Checkboxes : BaseTest, IDisposable
    {
        [TestMethod]
        public void Checkboxes1()
        {
            By _Checkboxes = By.XPath("//a[contains(text(),'Checkboxes')]");
            By _locator = By.XPath("//input[@type='checkbox']");

            ClickOnElement(_Checkboxes);
            Thread.Sleep(2000);
            var elements = driver.FindElements(_locator);
            int size = elements.Count();
            Console.WriteLine(size);

            //доработать
            for (int i = 0; i < size; i++)
            {
                String check_state = elements.ElementAt(i).GetAttribute("checked");
                if (check_state == null)
                {
                    elements.ElementAt(i).Click();
                    Console.WriteLine("Checbox " + (i + 1) + " is not selected");
                }
            }
        }
    }
}

