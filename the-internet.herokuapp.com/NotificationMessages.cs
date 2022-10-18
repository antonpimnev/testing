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
    public class NotificationMessages : BaseTest, IDisposable
    {
        [TestMethod]
        public void NotificationMessages1()
        {
            By _notificationMessages1 = By.XPath("//a[contains(text(),'Notification Messages')]");
            By _notificationMessageNew = By.XPath("//a[contains(text(),'Click Here')]");
            By _notificationMessage = By.XPath("//div[@id='flash']");

            ClickOnElement(_notificationMessages1);
            Thread.Sleep(2000);
            
            var result = driver.FindElement(_notificationMessage).Text;
            Console.WriteLine(result);

            //TODO: В этом месте можно сделать цикт чтобы перебрать все неповторяющиеся сообщения
            //ClickOnElement(_notificationMessageNew);
        }
    }
}

