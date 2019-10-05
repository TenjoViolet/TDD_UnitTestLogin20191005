using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDUnitTestLogin.Model;
using TDDUnitTestLogin.Repository;

namespace TDDUnitTestLogin.Service
{
    public class Login
    {
        IAccountRepository _AccountRepository;

        public Login(IAccountRepository iarAccountRepository)
        {
            _AccountRepository = iarAccountRepository;
        }

       public Boolean CheckLoginAccountLegal(string strUserId,string strPwd)
       {
            Boolean blnRet = false;
            List<Account> Accounts = _AccountRepository.SelectAccounts();
            try
            {
                blnRet = Accounts.Exists(x => x.UserId == strUserId);
                
            }
            catch (Exception ex)
            {

                blnRet = false;
            }
            return blnRet;
       }


    }
}
