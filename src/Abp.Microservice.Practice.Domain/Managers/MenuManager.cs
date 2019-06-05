using Abp.Microservice.Practice.Domain.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using Abp.Microservice.Practice.Domain.Entities;
using Abp.Microservice.Practice.Domain.Checks;

namespace Abp.Microservice.Practice.Managers
{
    public class MenuManager : DomainService
    {
        private readonly IMenuRepository _menuRepository;
        private readonly MenuChecker _menuChcker;

        public MenuManager(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
            _menuChcker = new MenuChecker(this);
        }

        public async Task<Menu> GetByNameOrUrlAsync(string name, string url)
        {
            return await _menuRepository.GetByNameOrUrlAsync(name, url);
        }

        public async Task AddOrUpdateMenuAsync(int id, string name, string url, string icon)
        {
            CheckedMenuId(id);
            var menu = await _menuRepository.FindAsync(id);
            await AddOrUpdateMenuAsync(menu, name, url, icon);
        }

        public async Task AddOrUpdateMenuAsync(Menu menu, string name, string url, string icon)
        {
            menu = menu ?? new Menu(name, url, icon);
            if(menu.Id>0)
            {
                _menuChcker.ThrowWhenMenuIsExisted(menu.Name, menu.Url);
                await _menuRepository.InsertAsync(menu);
            }
            else
            {
                menu.UpdateUrl(url);
                menu.UpdateName(name);
                menu.UpdateIcon(icon);
                await _menuRepository.UpdateAsync(menu);
            }
        }

        private void CheckedMenuId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("id is not valid");
        }
        //Q：新增的实体的DTO是放在Domain层还是在Domain.Share层
        public async Task<Menu> InsertMenuAsync(Menu menu)
        {
            _menuChcker.ThrowWhenMenuIsExisted(menu.Name, menu.Url);
            return await _menuRepository.InsertAsync(menu);
        }
    }
}
