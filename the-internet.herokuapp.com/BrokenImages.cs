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
    public class BrokenImages : BaseTest, IDisposable
    {
        [TestMethod]
        public async Task BrokenImages1()
        {
            int broken_images = 0;
            String test_url = "https://the-internet.herokuapp.com/broken_images";
            driver.Url = test_url;
            using var client = new HttpClient();
            var image_list = driver.FindElements(By.TagName("img"));

            //Loop through all the images
            foreach (var img in image_list)
            {
                try
                {
                    // Get the URI
                    HttpResponseMessage response = await client.GetAsync(img.GetAttribute("src"));
                    // Reference - https://docs.microsoft.com/en-us/dotnet/api/system.net.httpwebresponse.statuscode?view=netcore-3.1
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        System.Console.WriteLine("Image at the link " + img.GetAttribute("src") + " is OK, status is "
                                + response.StatusCode);
                    }
                    else
                    {
                        System.Console.WriteLine("Image at the link " + img.GetAttribute("src") + " is Broken, status is "
                                + response.StatusCode);
                        broken_images++;
                    }
                }
                catch (Exception ex)
                {
                    if ((ex is ArgumentNullException) ||
                       (ex is NotSupportedException))
                    {
                        System.Console.WriteLine("Exception occured\n");
                    }
                }
            }
            //Perform wait to check the output
            Thread.Sleep(2000);
            Console.WriteLine("\nThe page " + test_url + " has " + broken_images + " broken images");
        }
    }
}

