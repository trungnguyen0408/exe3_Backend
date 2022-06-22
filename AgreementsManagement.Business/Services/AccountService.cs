using AgreementsManagement.Data.EF;
using AgreementsManagement.Data.Repositories;
using AgreementsManagement.Model.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementsManagement.Business.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public AccountVM GetAccount(string userName)
        {
            return _accountRepository.GetAccount(userName);
           
        }
    }
}
