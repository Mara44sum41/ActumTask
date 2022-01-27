using OpenQA.Selenium;

namespace actum_task.Pages
{
    class LoginPage : DriverDef
    {
        IWebElement btnLogin => Driver.FindElement(By.Id("login2"));
        IWebElement txtUserName => Driver.FindElement(By.Id("loginusername"));
        IWebElement txtPassword => Driver.FindElement(By.Id("loginpassword"));
        IWebElement btnModalLogin => Driver.FindElement(By.XPath("//*[@onclick='logIn()']"));

        public void EnterLoginAndPassword(string userName, string passWord)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(passWord);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }

        public void ClickModalLogin()
        {
            btnModalLogin.Click();
        }
    }
}

