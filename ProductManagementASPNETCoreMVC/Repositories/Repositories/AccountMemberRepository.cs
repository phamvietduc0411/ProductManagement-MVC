using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Repositories.Entities;
using Repositories.Infrastructures;

namespace Repositories.Repositories
{
    public class AccountMemberRepository : GenericRepository<AccountMember>
    {
        public AccountMemberRepository(MyStoreContext storeContext, ILogger logger) : base(storeContext, logger)
        {
            
        }

        public AccountMember GetUser(string emailAddress)
        {
            return _dbSet.FirstOrDefault(c => c.EmailAddress == emailAddress);
        }

        public bool CheckPassword(AccountMember user, string password)
        {
            return user != null && user.MemberPassword == password;
        }
    }
}
