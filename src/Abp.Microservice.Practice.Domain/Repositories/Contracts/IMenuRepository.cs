using Abp.Microservice.Practice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Abp.Microservice.Practice.Domain.Repositories
{
    public interface IMenuRepository : IBasicRepository<Menu, int>
    {
        Task<Menu> GetByNameOrUrlAsync(string name, string url);
    }
}
