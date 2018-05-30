using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelevantCodes.ExtentReports;

namespace TestCasesVerification
{
    [TestClass]
    public class ExtentReportsTest
    {
        public ExtentReports extent;
        public ExtentTest test;
        public TestContext TestContext
        {
            get;
            set;
        }
          
        public void StartReport()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string reportPath = projectPath + "Reports\\MyOwnReport.html";

            extent = new ExtentReports(reportPath, true);
            extent
            .AddSystemInfo("Host Name", "Krishna")
            .AddSystemInfo("Environment", "QA")
            .AddSystemInfo("User Name", "Krishna Sakinala");
            extent.Config();
        }
        [TestMethod]
        public void DemoReportPass()
        {
            test = extent.StartTest("DemoReportPass");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as consition is true");

        }
    
        //public void GetResult()
        //{
        //    var status = TestContext.CurrentTestOutcome;
        //    var stackTrace = "<pre>" + TestContext.CurrentTestOutcome.t.StackTrace + "</pre>";
        //    var errorMessage = TestContext.CurrentContext.Result.Message;

        //    if (status == TestStatus.Failed)
        //    {
        //        test.Log(LogStatus.Fail, stackTrace + errorMessage);
        //    }
        //    extent.EndTest(test);
        //}

      
        public void EndReport()
        {
            extent.Flush();
            extent.Close();
        }
    }
}
