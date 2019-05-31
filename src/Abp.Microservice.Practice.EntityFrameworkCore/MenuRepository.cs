using Abp.Microservice.Practice.Domain.Entities;
using Abp.Microservice.Practice.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Microservice.Practice.EntityFrameworkCore
{
    public class MenuRepository : EfCoreRepository<IPracticeDbContext, Menu, int>, IMenuRepository
    {
        public MenuRepository(IDbContextProvider<IPracticeDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public async Task<Menu> GetByNameOrUrlAsync(string name, string url)
        {
            return await DbSet.Where(p => p.Name == name || p.Url == url).FirstOrDefaultAsync();
        }
    }
}
