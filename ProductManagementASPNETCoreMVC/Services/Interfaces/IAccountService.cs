﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;

namespace Services.Interfaces
{
    public interface IAccountService
    {
        bool CheckPassword(AccountMember user, string memberPassword);
        AccountMember GetUser(string accountId); 
    }
}
