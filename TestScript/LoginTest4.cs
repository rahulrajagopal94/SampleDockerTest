using SampleDocker.Pages;
using NUnit.Framework;

namespace SampleDocker.TestScript
{
    class LoginTest4 : Setup
    {
       [Test, Category("Smoke")]
        public void VerifyLogin4()
        {
            reporter = extent.CreateTest("LoginTest4").Info("Initialize");
            LoginPage.LoginToApplication(driver, ref reporter);                 
            HomePage.VerifyThatHomePageIsLoaded(driver, ref reporter);                                    
            LogoutPage.LogoutFromApplication(driver, ref reporter);
            reporter.Info("Login test finished");
        }
    }
}
