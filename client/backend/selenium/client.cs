//External NuGet
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;


namespace GGSClient.client.backend.selenium
{
    internal class client
    {
        static ChromeDriver driver;
        public static void runSeleniumDriver(string url, bool hidden = false)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("user-data-dir=userdata");
            options.AddArgument("--windows-size=1,1");
            if (hidden == true)
            {
                options.AddArgument("headless");
            }
            client.driver = new ChromeDriver(options);
            client.driver.Navigate().GoToUrl(url);
        }

        public static IWebElement FindElememt(string tag, string type, string value, int timeoutInSecond = 5)
        {
            return client.driver.FindElement(By.XPath("//" + tag + "[@" + type + "='" + value + "']"));
        }

        public static string getCookie(string name)
        {
            return client.driver.Manage().Cookies.GetCookieNamed(name).Value;
        }

        public static void execJS(string command)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript(command);
        }
    }
}
