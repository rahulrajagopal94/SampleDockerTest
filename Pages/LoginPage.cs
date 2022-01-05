using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace SampleDocker.Pages
{

    class LoginPage
    {
        /// <summary>
        /// To Verify that user is able to login to the application
        /// </summary>
        /// <param name="inputjson">The input json</param>
        /// <returns>Test reports</returns>
        public static void LoginToApplication(IWebDriver driver, ref ExtentTest reporter)
        {
            try
            {
                Thread.Sleep(2000);
                IWebElement username = driver.FindElement(By.Id("username"));
                IWebElement password = driver.FindElement(By.Id("password"));
                IWebElement location = driver.FindElement(By.Id("Isolation Ward"));
                IWebElement button = driver.FindElement(By.Id("loginButton"));
                username.SendKeys("Admin");
                reporter.Log(Status.Pass, "Enter Username");
                password.SendKeys("Admin123");
                reporter.Log(Status.Pass, "Enter Password");
                location.Click();
                reporter.Log(Status.Pass, "Click Location");
                button.Click();
                reporter.Log(Status.Pass, "Click Button");

            }
            catch (Exception e)
            {
                Console.WriteLine("LoginToApplication failed: " + e);
            }
        }
    }
}