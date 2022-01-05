
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using AventStack.ExtentReports;
using System.Threading;
using NUnit.Framework;

namespace SampleDocker.Pages
{
    class HomePage
    {

        /// <summary>
        /// To Verify that user is able to view the homepage of the application
        /// </summary>
        /// <param name="inputjson">The input json</param>
        /// <returns>Test reports</returns>
        public static void VerifyThatHomePageIsLoaded(IWebDriver driver, ref ExtentTest reporter)
        {
            Thread.Sleep(5000);          
            try
            {
                string actualUrl = "https://demo.openmrs.org/openmrs/referenceapplication/home.page";
                string expectedUrl = driver.Url;
                Console.WriteLine(expectedUrl);
                Assert.AreEqual(expectedUrl, actualUrl);
                reporter.Log(Status.Pass, "Url Verified");

            }
            catch (Exception e)
            {
                Console.WriteLine("Homepage load failed: " + e);         
            }
        }
    }
}
