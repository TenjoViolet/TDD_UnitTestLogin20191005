using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDUnitTestLogin.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDUnitTestLogin.Service.Tests
{
    [TestClass()]
    public class LoginTests
    {
        [TestMethod()]
        public void CheckLoginAccountLegalTest_輸入錯誤帳號_應回傳false()
        {
            Assert.Fail();
        }
    }
}