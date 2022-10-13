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
    public class HorizontalSlider : BaseTest, IDisposable
    {
        [TestMethod]
        public void HorizontalSlider1()
        {
            By _horizontalSlider1 = By.XPath("//a[contains(text(),'Horizontal Slider')]");
            By _horizontalSliderInput = By.XPath("//input[@type='range']");
            By _horizontalSliderResult = By.XPath("//span[@id='range']");

            ClickOnElement(_horizontalSlider1);
            Thread.Sleep(2000);

            ClickOnElement(_horizontalSliderInput).SendKeys(Keys.ArrowRight + Keys.ArrowRight);
            Thread.Sleep(2000);

            var result = driver.FindElement(_horizontalSliderResult).Text;
            Console.WriteLine(result);

            Thread.Sleep(2000);

            IWebElement tracker = driver.FindElement(_horizontalSliderInput);
            new Actions(driver)
                .MoveToElement(tracker, 0, 1)
                .Perform();
        }
    }
}

