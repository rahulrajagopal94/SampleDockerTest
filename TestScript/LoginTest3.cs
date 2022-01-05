using SampleDocker.Pages;
using NUnit.Framework;

namespace SampleDocker.TestScript
{
    class LoginTest3 : Setup
    {
       [Test, Category("Smoke")]
        public void VerifyLogin3()
        {
            reporter = extent.CreateTest("LoginTest3").Info("Initialize");
            LoginPage.LoginToApplication(driver, ref reporter);                 
            HomePage.VerifyThatHomePageIsLoaded(driver, ref reporter);                                    
            LogoutPage.LogoutFromApplication(driver, ref reporter);
            reporter.Info("Login test finished");
        }
    }
}
