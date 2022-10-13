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
    public class FileUpload : BaseTest, IDisposable
    {
        [TestMethod]
        public void FileUpload1()
        {
            By _fileUpload1 = By.XPath("//a[contains(text(),'File Upload')]");
            string filePath = @"C:\Temp\Test.docx";
            By _fileUploadOption = By.XPath("//input[@id='file-upload']");
            By _fileUploadButton = By.XPath("//input[@id='file-submit']");
            By _fileUploadResult = By.XPath("//h3[contains(text(),'File Uploaded!')]");

            ClickOnElement(_fileUpload1);
            Thread.Sleep(2000);

            //AttachFile(_fileUploadOption, filePath);

            Thread.Sleep(2000);
            ClickOnElement(_fileUploadButton);
            Thread.Sleep(2000);

            var result = FindElement(_fileUploadResult);
            Assert.IsNotNull(result);
        }

    }
}

