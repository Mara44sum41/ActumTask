using OpenQA.Selenium;
using System.Threading;

namespace actum_task.Pages
{
    class ContactPage : DriverDef
    {
        IWebElement btnContact=> Driver.FindElement(By.XPath("//*[@data-target='#exampleModal']"));  
        IWebElement txtEmail=> Driver.FindElement(By.Id("recipient-email"));
        IWebElement txtName => Driver.FindElement(By.Id("recipient-name"));
        IWebElement txtMsg => Driver.FindElement(By.Id("message-text"));
        IWebElement btnSendMsg => Driver.FindElement(By.XPath("//*[@onclick='send()']")); 

        public void EnterEmailNameMsg(string email, string name, string msg)
        {
            txtEmail.SendKeys(email);
            txtName.SendKeys(name);
            txtMsg.SendKeys(msg);
        }

        public void ClickContact()
        {
            btnContact.Click();
        }

        public void ClickSendMsg()
        {
            btnSendMsg.Click();
            Thread.Sleep(1500);
            IAlert simpleAlert = Driver.SwitchTo().Alert();
            simpleAlert.Accept();
        }
    }
}