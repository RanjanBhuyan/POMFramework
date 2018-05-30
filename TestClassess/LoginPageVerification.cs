using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseClass;
using POMFramework.Pages;
using RelevantCodes.ExtentReports;
//using NUnit.Framework;
namespace TestCasesVerification
{
    [TestClass]
    public class LoginPageVerification : TestBase
    {
        public TestContext TestContext
        {
            get;
            set;
        }

        
        [TestMethod]
        public void LoginPageTitleVerification()
        {
           // TestBase.Initialize();

           //string actualResult = LoginPage.ValidateLoginPageTitle();
           //Assert.AreEqual(actualResult, "Free CRM software in the cloud powers sales and customer service");

        }

        [TestMethod]
        public void ValidateImage()
        {
            LoginPage login = new LoginPage();
            bool isImagePresent = false;
            isImagePresent = login.ValidateHomoPageLogo();
            Assert.IsTrue(isImagePresent);
        }

        [TestMethod]
        [DeploymentItem("TestData\\LoginTestData.csv")]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV","LoginTestData.csv", "LoginTestData#csv", DataAccessMethod.Sequential)]
        public void LoginVerification()
        {
          
            var userid = this.TestContext.DataRow["UserId"].ToString();
            var password = this.TestContext.DataRow["Password"].ToString();
            LoginPage login = new LoginPage();

            login.Login(userid, password);
              
        }
        
    }
}
