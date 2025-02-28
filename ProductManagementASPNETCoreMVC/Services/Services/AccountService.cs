using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Interfaces;

namespace Services.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountMemberRepository iAccountRepository;
        public AccountService()
        {
            iAccountRepository = new AccountMemberRepository();
        }
        public AccountMember GetAccountById(string accountId)
        {
            return iAccountRepository.GetAccountMemberById(accountId);
        }
    }
}
