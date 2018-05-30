using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using BaseClass;
namespace POMFramework.Pages
{
    public  class LoginPage:TestBase
    {
        [FindsBy(How = How.Name, Using = "username")]
        public  IWebElement userName;

       [FindsBy(How = How.Name, Using = "password")]
       public  IWebElement password;

       [FindsBy(How = How.XPath, Using = "//*[@id='loginForm']/div/div/input")]
       //button[contains(text(),'Sign Up']
       public   IWebElement submitButton;

      // [FindsBy(How = How.XPath, Using = "//img[@class='img-responsive']")]
      // [FindsBy(How = How.XPath, Using = "//img[contains(@class,'img-responsive']")]
       //[FindsBy(How = How.XPath, Using = "//img[contains(text(),'img-responsive')]")]
       [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/a/img")]
       public IWebElement homoPageLogo;

       public LoginPage()
       {
           PageFactory.InitElements(Driver, this);
       }

       //LoginPage login = new LoginPage();

        //Intilizing the page object
      

        //Action
        public static string ValidateLoginPageTitle(var v )
       {
           //driver.SwitchTo().Frame("iframe");
            string _title =string.Empty;
            return _title = Driver.Title; 
       }

        public  bool ValidateHomoPageLogo()
        {
            bool logopresent = false;

            if (homoPageLogo.Text == "FreeCRM")
                {
                    logopresent = homoPageLogo.Displayed;
                }
           
            //Driver.SwitchTo().Frame("iframe");
          
           
            return logopresent;
         
        }

        public void Login(string _userName,string _passWord)
        {
            userName.SendKeys(_userName);
            password.SendKeys(_passWord);
            submitButton.Click();
            
        }

    }
}
