using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;
using Repositories.Repositories;

namespace Repositories.DataAccessObjects
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private static readonly object objLock = new object();
        private AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }

        public AccountMember GetAccountById(string accountId)
        {
            using var db = new MyStoreContext();
            return db.AccountMembers.FirstOrDefault(c => c.EmailAddress.Equals(accountId));
        }
    }
}
