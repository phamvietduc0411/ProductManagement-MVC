using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Repositories.Entities;
using Repositories.Infrastructures;
using Repositories.Repositories;
using Services.Interfaces;

namespace Services.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool CheckPassword(AccountMember user, string memberPassword)
        {
            return _unitOfWork.AccountMembers.CheckPassword(user, memberPassword);
        }


        public AccountMember GetUser(string accountId)
        {
            var account = _unitOfWork.AccountMembers.GetUser(accountId);
            return account;
        }
    }
}
