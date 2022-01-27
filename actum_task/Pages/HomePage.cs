using OpenQA.Selenium;

namespace actum_task.Pages
{
    class HomePage : DriverDef
    {
        IWebElement btnLogin => Driver.FindElement(By.Id("login2"));
        IWebElement btnLogOff => Driver.FindElement(By.Id("logout2"));
        IWebElement btnWelcome => Driver.FindElement(By.Id("nameofuser")); 

        public void ClickLogin() => btnLogin.Click();
        public bool IsLoginExist() => btnLogin.Displayed;
        public bool IsLogOffExist() => btnLogOff.Displayed;
        public bool IsWelcomeExist() => btnWelcome.Displayed;
    }
}



