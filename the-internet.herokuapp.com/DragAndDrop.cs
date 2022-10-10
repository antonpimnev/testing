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
    public class DragAndDrop : BaseTest, IDisposable
    {
        [TestMethod]
        public void DragAndDrop1()
        {
            By _dragAndDrop1 = By.XPath("//a[contains(text(),'Drag and Drop')]");
            By _draggable = By.XPath("//div[@id='column-a']");
            By _droppable = By.XPath("//div[@id='column-b']");
            By _result = By.XPath("//div[(@id='column-a')] | //header[contains(text(),'B')]");

            ClickOnElement(_dragAndDrop1);
            Thread.Sleep(2000);

            // почему то не работает :(
            IWebElement draggable = driver.FindElement(_draggable);
            IWebElement droppable = driver.FindElement(_droppable);
            new Actions(driver)
                .DragAndDrop(draggable, droppable)
                .Perform();

            Assert.IsNotNull(_result);
        }

    }
}

