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
    public class ShiftingContent : BaseTest, IDisposable
    {
        [TestMethod]
        public void ShiftingContent1()
        {
            By _shiftingContent1 = By.XPath("//a[contains(text(),'Shifting Content')]");
            By _shiftingContentMenuElement = By.XPath("//a[contains(text(),'Example 1: Menu Element')]");

            ClickOnElement(_shiftingContent1);
            Thread.Sleep(2000);

            ClickOnElement(_shiftingContentMenuElement);
            Thread.Sleep(2000);

            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile("screenshot.png", ScreenshotImageFormat.Png);

            //TODO
            // Как вытащить содержимое тэга .shift из разметки?
            //Console.WriteLine();
        }
    }
}

