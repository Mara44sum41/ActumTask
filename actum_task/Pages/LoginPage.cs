using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actum_task.Pages
{
    class LoginPage : DriverDef
    {
        IWebElement BtnLogin => Driver.FindElement(By.Id("login2"));
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
            BtnLogin.Click();
        }

        public void ClickModalLogin()
        {
            btnModalLogin.Click();
        }
    }

}

