using actum_task;
using actum_task.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

public class Tests : DriverDef

{
  
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Setup");
        Driver = new ChromeDriver();
        
    }

    [Test]
    public void LoginTest()
    {
        Driver.Navigate().GoToUrl("https://www.demoblaze.com/");

        HomePage homePage = new HomePage();
        LoginPage loginPage = new LoginPage();

        homePage.ClickLogin();
        Thread.Sleep(3000);
        loginPage.EnterLoginAndPassword("xtvarum01", "password");
        loginPage.ClickModalLogin();
        Assert.That

    }
}
