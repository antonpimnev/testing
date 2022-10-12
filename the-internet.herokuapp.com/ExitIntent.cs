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
    public class ExitIntent : BaseTest, IDisposable
    {
        [TestMethod]
        public void ExitIntent1()
        {
            By _exitIntent1 = By.XPath("//a[contains(text(),'Entry Ad')]");
            By _entryAdClose = By.XPath("//p[contains(text(),'Close')]");

            ClickOnElement(_exitIntent1);
            Thread.Sleep(2000);

            ActionBuilder actionBuilder = new ActionBuilder();
            PointerInputDevice mouse = new PointerInputDevice(PointerKind.Mouse, "default mouse");
            actionBuilder.AddAction(mouse.CreatePointerMove(CoordinateOrigin.Viewport,
                0, 0, TimeSpan.Zero));
            ((IActionExecutor)driver).PerformActions(actionBuilder.ToActionSequenceList());

            Thread.Sleep(1000);

            bool result = driver.FindElement(_entryAdClose).Displayed;

            Assert.IsTrue(result);
        }

    }
}

