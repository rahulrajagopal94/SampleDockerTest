using SampleDocker.Pages;
using NUnit.Framework;

namespace SampleDocker.TestScript
{
    class LoginTest10 : Setup
    {
       [Test, Category("Smoke")]
        public void VerifyLogin10()
        {
            reporter = extent.CreateTest("LoginTest10").Info("Initialize");
            LoginPage.LoginToApplication(driver, ref reporter);                 
            HomePage.VerifyThatHomePageIsLoaded(driver, ref reporter);                                    
            LogoutPage.LogoutFromApplication(driver, ref reporter);
            reporter.Info("Login test finished");
        }
    }
}
