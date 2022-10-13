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
    public class FileDownload : BaseTest, IDisposable
    {
        [TestMethod]
        public void FileDownload1()
        {
            By _fileDownload1 = By.XPath("//a[contains(text(),'File Download')]");

            ClickOnElement(_fileDownload1);
            Thread.Sleep(2000);

            var chromeOptions = new ChromeOptions();
            var downloadDirectory = @"C:\Temp";

            chromeOptions.AddUserProfilePreference("download.default_directory", downloadDirectory);
            chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");

            var driver = new ChromeDriver(chromeOptions);

            var download = driver.FindElements(By.XPath("//a[contains(text(),'_uploadImageMoon.jpg')]")); // Почему то 0 //div[@class='example']/a/@href  (//body//a)[1]

            foreach (var t in download)
            {
                t.SendKeys(Keys.Enter);
            }

            //Thread.Sleep(1000);

            //var result = FindElement(_fileUploadResult);
            //Assert.IsNotNull(result);
        }

    }
}

