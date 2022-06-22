using AgreementsManagement.Model.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementsManagement.Data.Repositories
{
    public interface IAccountRepository
    {
        AccountVM GetAccount(string userName); 
    }
}
