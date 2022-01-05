using OpenQA.Selenium;
using System;
using AventStack.ExtentReports;

namespace SampleDocker.Pages
{
    class LogoutPage
    {
      
        /// <summary>
        /// To Verify that user is able to login to the application
        /// </summary>
        /// <returns>Test reports</returns>
        public static void LogoutFromApplication(IWebDriver driver, ref ExtentTest reporter)
        {
            try
            {
                IWebElement logout = driver.FindElement(By.XPath("//header/nav[1]/div[2]/ul[1]/li[3]/a[1]/i[1]"));
                logout.Click();
                reporter.Log(Status.Pass, "Click Logout Button");
            }
            catch (Exception e)
            {
                Console.WriteLine("LoginToApplication failed: " + e);           
            }
        }
    }
}
