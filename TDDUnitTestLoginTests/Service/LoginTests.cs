using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDUnitTestLogin.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDUnitTestLogin.Repository;
using NSubstitute;
using TDDUnitTestLogin.Model;

namespace TDDUnitTestLogin.Service.Tests
{
    [TestClass()]
    public class LoginTests
    {
        [TestMethod()]
        public void CheckLoginAccountLegalTest_輸入錯誤帳號_應回傳false()
        {
            //arrange準備受測物件、參數、預期結果
            List<Account> ltAccounts = new List<Account>
            {
                new Account{ UserId="admin", Pwd="123456"},
                new Account{ UserId="Jack", Pwd="123456"},
                new Account{ UserId="Rose", Pwd="123456"},
            };
            IAccountRepository accountRepository = Substitute.For<IAccountRepository>();
            Login login = new Login(accountRepository);
            accountRepository.SelectAccounts().Returns(ltAccounts);

            Boolean expected = false;

            //act執行受測方法
            Boolean actual = login.CheckLoginAccountLegal("Violet", "123456");

            //assert驗證執行結果與預測結果是否一致
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void CheckLoginAccountLegalTest_輸入正確帳號且輸入錯誤密碼_應回傳false()
        {
            //arrange準備受測物件、參數、預期結果
            List<Account> ltAccounts = new List<Account>
            {
                new Account{ UserId="admin", Pwd="123456"},
                new Account{ UserId="Jack", Pwd="123456"},
                new Account{ UserId="Rose", Pwd="123456"},
            };
            IAccountRepository accountRepository = Substitute.For<IAccountRepository>();
            Login login = new Login(accountRepository);
            accountRepository.SelectAccounts().Returns(ltAccounts);

            Boolean expected = false;

            //act執行受測方法
            Boolean actual = login.CheckLoginAccountLegal("admin", "777");

            //assert驗證執行結果與預測結果是否一致
            Assert.AreEqual(expected, actual);
        }


    }
}