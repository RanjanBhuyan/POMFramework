using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCasesVerification
{
   public  class DataSources
    {
       public TestContext TestContext
       {
           get;
           set;
       }

       public void LoginTestData()
       {
           var userid = this.TestContext.DataRow["UserId"].ToString();
           var password = this.TestContext.DataRow["Password"].ToString();
       }
    }
}
