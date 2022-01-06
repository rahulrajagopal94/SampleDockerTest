using SampleDocker.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Text.RegularExpressions;
using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Remote;

namespace SampleDocker.TestScript
{
    class Setup
    {
        public static ExtentTest reporter;
        public static ExtentReports extent;
        public static ExtentHtmlReporter htmlReporter;
        public static IWebDriver driver;

        [SetUp]
        public void Before()
        {
            var options = new ChromeOptions();
            var remoteUrl = "http://localhost:4444/wd/hub";
            driver = new RemoteWebDriver(new Uri(remoteUrl), options);
       //     driver = new ChromeDriver(GetAbsoluteFilePath("WebDrivers"));
            driver.Navigate().GoToUrl("https://demo.openmrs.org/openmrs/");
        }

        [TearDown]
        public static void Exit()
        {
            driver.Quit();
        }

        [OneTimeSetUp]
        public void ConfigureExtentReport()
        {
            string testName = TestContext.CurrentContext.Test.Name;
            string reportPath = GetAbsoluteFilePath("Results\\Report\\ExtentReport\\") + testName;
            extent = new ExtentReports();
            htmlReporter = new ExtentHtmlReporter(reportPath);
            htmlReporter.Config.DocumentTitle = "Automation Testing Report";
            htmlReporter.Config.ReportName = "Automation Testing";
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public static void GenerateExtentReport()
        {
            extent.Flush();
        }

        public string GetAbsoluteFilePath(string fileOrDirectoryName)
        {
            var codeBase = System.Reflection
                .Assembly.GetExecutingAssembly().CodeBase;
            if (codeBase != null)
            {
                var exePath = Path.GetDirectoryName(codeBase);
                var appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
                if (exePath != null)
                {
                    var appRoot = appPathMatcher.Match(exePath).Value;
                    return Path.Combine(appRoot, fileOrDirectoryName);
                }
            }

            throw new InvalidOperationException();
        }
    }
}
