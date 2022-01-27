using actum_task;
using actum_task.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Assert = NUnit.Framework.Assert;

public class Tests : DriverDef

{
    string test_url = "https://www.demoblaze.com/";

    [SetUp]
    public void Setup()
    {
        Driver = new ChromeDriver();
    }

    [Test]
    public void LoginTest()
    {
        Driver.Navigate().GoToUrl(test_url);

        HomePage homePage = new HomePage();
        LoginPage loginPage = new LoginPage();

        homePage.ClickLogin();
        Thread.Sleep(3000);
        loginPage.EnterLoginAndPassword("xtvarum01", "password");
        loginPage.ClickModalLogin();
        Thread.Sleep(3000);
        //Asserts
        Assert.That(homePage.IsLogOffExist(), Is.True);
        Assert.That(homePage.IsWelcomeExist(), Is.True);
    }
  
    [Test]
    public void ContactTest()
    {
        Driver.Navigate().GoToUrl(test_url);

        HomePage homePage = new HomePage();
        ContactPage ContactPage = new ContactPage();
        
        ContactPage.ClickContact();
        Thread.Sleep(3000);
        ContactPage.EnterEmailNameMsg("iloveautomation@automation.com", "Mara", "Just filing here random message");
        Thread.Sleep(3000);
        ContactPage.ClickSendMsg();
        //Asserts
        Thread.Sleep(3000);
        Assert.That(homePage.IsLoginExist(), Is.True);
    }
 
    [Test]
    public void EasyWebTest()
    {
        Driver.Navigate().GoToUrl(test_url);
        //Asserts
        Assert.AreEqual("STORE", Driver.Title);
    }
}