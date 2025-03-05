using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repositories.Entities;
using Repositories.Repositories;

namespace Repositories.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyStoreContext _storeContext;
        private readonly ILogger _logger;
        public AccountMemberRepository AccountMembers { get; private set; }

        public CategoryRepository Categories { get; private set; }

        public ProductRepository Products { get; private set; }

        public UnitOfWork(MyStoreContext storeContext, ILoggerFactory loggerFactory)
        {
            _storeContext = storeContext;
            _logger = loggerFactory.CreateLogger("log");
            AccountMembers = new AccountMemberRepository(_storeContext, _logger);
            Categories = new CategoryRepository(_storeContext, _logger);
            Products = new ProductRepository(_storeContext, _logger);
        }


        public async Task CompleteAsync() => await _storeContext.SaveChangesAsync();
    }
}
