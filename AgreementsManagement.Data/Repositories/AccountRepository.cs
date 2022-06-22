using AgreementsManagement.Data.EF;
using AgreementsManagement.Model.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementsManagement.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AgreementsManagementDbContext _context;

        public AccountRepository(AgreementsManagementDbContext context)
        {
            _context = context;
        }
        public AccountVM GetAccount(string userName)
        {
            var accountIsGet = _context.Accounts.SingleOrDefault(account => account.userName == userName);
            if (accountIsGet != null)
            {
                return new AccountVM()
                {
                    userName = accountIsGet.userName,
                    password = accountIsGet.password,
                    fullName = accountIsGet.fullName
                };
            }
            return null;
        }
    }
}
