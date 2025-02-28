using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;

namespace Repositories.Interfaces
{
    public interface IAccountMemberRepository
    {
        AccountMember GetAccountMemberById(string accountId);
    }
}
