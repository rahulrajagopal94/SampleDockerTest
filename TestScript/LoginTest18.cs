using SampleDocker.Pages;
using NUnit.Framework;

namespace SampleDocker.TestScript
{
    class LoginTest18 : Setup
    {
       [Test, Category("Smoke")]
        public void VerifyLogin18()
        {
            reporter = extent.CreateTest("LoginTest18").Info("Initialize");
            LoginPage.LoginToApplication(driver, ref reporter);                 
            HomePage.VerifyThatHomePageIsLoaded(driver, ref reporter);                                    
            LogoutPage.LogoutFromApplication(driver, ref reporter);
            reporter.Info("Login test finished");
        }
    }
}
