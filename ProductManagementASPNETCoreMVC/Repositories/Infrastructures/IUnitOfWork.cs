using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Repositories;

namespace Repositories.Infrastructures
{
    public interface IUnitOfWork
    {
        AccountMemberRepository AccountMembers { get; }
        CategoryRepository Categories { get; }
        ProductRepository Products { get; }
        Task CompleteAsync();
    }
}
