using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace the_internet.herokuapp.com
{
        [TestInitialize]

        
        [TestMethod]
        public void TC6()
        {
            var docName = TestContext.TestName;
            By _docPreviewBtn = By.XPath("//span[contains(text(),'Предварительный просмотр')]");
            By _docPreviewCloseBtn = By.XPath("//div[@id='viewer']");

            Login(_emailAdmin);
            GoToUrl(_correspondencePageUrl);

#region
            ClickOnElement(_insideDOCBtn);
            ClickOnElement(_createDocumentBtn);
            ClickOnElement(_docNameInp).SendKeys(docName);
            ClickOnElement(_docTypeSelector);
            ClickOnElement(_docTypeSelector1);
            ClickOnElement(_docSaveDocumentBtn);
            Thread.Sleep(5000);
            ClickOnElement(_docRegistryBtn);
            Thread.Sleep(5000);
            //ClickOnElement(_docPreviewBtn);
            //Thread.Sleep(3000);
            //ClickOnElement(_docPreviewCloseBtn).SendKeys(Keys.Escape);
            ClickOnElement(_docUnRegistryBtn);
#endregion
        }
}

