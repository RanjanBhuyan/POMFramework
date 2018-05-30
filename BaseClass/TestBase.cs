using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TestUtil;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseClass
{
    public class TestBase
    {
        //public static IWebDriver driver;
        // [TestInitialize]
        //  public static void TestIntialization()
        //{
        //    driver = new ChromeDriver(@"C:\SelenuimTest\SeleniumTestProject\chromedriver");
        //    driver.Navigate().GoToUrl("https://www.freecrm.com/");
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        //    driver.Manage().Window.Maximize();
           
             
        //}

         public static IWebDriver Driver { get; set; }
         public static IWebElement Element { get; set; }



      [TestInitialize]
         public  void Initialize()
         {
             Driver = new ChromeDriver(@"C:\SelenuimTest\SeleniumTestProject\chromedriver");

             Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
             Driver.Navigate().GoToUrl("https://www.freecrm.com/");
             Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
             Driver.Manage().Window.Maximize();
         }
        [TestCleanup]
        public void CleanUp()
         {
             Driver.Quit();
         }
    }
}
