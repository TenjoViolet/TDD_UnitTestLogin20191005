using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDUnitTestLogin.Model;

namespace TDDUnitTestLogin.Repository
{
    public interface IAccountRepository
    {
        List<Account> SelectAccounts();
    }
}
