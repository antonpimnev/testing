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
    public class StatusCodes : BaseTest, IDisposable
    {
        [TestMethod]
        public void StatusCodes1()
        {
            // BrokenImages уже было это всё
            // https://learn.microsoft.com/en-us/dotnet/api/system.net.httpstatuscode?view=netcore-3.1
        }
    }
}

