using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace actum_task.Pages
{
    class HomePage : DriverDef
    {
        IWebElement BtnLogin => Driver.FindElement(By.Id("login2"));

        public void ClickLogin() => BtnLogin.Click();

    }
}



