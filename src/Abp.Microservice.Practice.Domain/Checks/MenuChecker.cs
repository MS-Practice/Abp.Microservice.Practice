using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Microservice.Practice.Domain.Entities;
using Abp.Microservice.Practice.Domain.Exceptions;
using Abp.Microservice.Practice.Managers;

namespace Abp.Microservice.Practice.Domain.Checks
{
    //负责领域检查
    public class MenuChecker
    {
        private MenuManager _menuManager;

        public MenuChecker(MenuManager menuManager)
        {
            _menuManager = menuManager ?? throw new ArgumentNullException(nameof(MenuManager));
        }

        public void ThrowWhenMenuIsExisted(string name,string url)
        {
            if (_menuManager.GetByNameOrUrlAsync(name, url)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult() != null)
                throw new DomainExistedException("name or url of menus existed");
        }
    }
}
