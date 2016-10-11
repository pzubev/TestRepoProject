using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace TestFramework
{
    public static class Browser
    {
        static IWebDriver webDriver = new FirefoxDriver(new FirefoxBinary(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe"), new FirefoxProfile(), TimeSpan.FromMinutes(10));

        public static string Title { get { return webDriver.Title; } }

        public static IWebDriver Driver { get { return webDriver; } }

        public static void NavigateTo(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }
    }
}