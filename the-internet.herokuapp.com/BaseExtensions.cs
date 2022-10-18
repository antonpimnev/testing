using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace the_internet.herokuapp.com
{
    public static class BaseExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By locator, int timeoutSeconds)
        {
            if (timeoutSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));

                IWebElement element = null;
                wait.Until(e =>
                {
                    var list = e.FindElements(locator);
                    if (list.Count > 0)
                    {
                        element = list[0];
                        return true;
                    }
                    return false;
                });

                if (element is null)
                {
                    throw new NoSuchElementException($"localtor: {locator.Criteria}");
                }
                return element;
                //-----
            }
            return driver.FindElement(locator);
        }
    }
}
