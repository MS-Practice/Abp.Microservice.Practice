using Abp.Microservice.Practice.Domain.Entities;
using Abp.Microservice.Practice.Domain.Shared.Dtos;
using Abp.Microservice.Practice.Managers;
using Abp.Microservice.Practice.Menus;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Menus
{
    public class MenuAppService : ApplicationService, IMenuAppService
    {
        private readonly MenuManager _menuManager;
        private readonly IRepository<Menu> _menuRepository;
        public MenuAppService(MenuManager menuManager, IRepository<Menu> menuRepository)
        {
            _menuManager = menuManager;
            _menuRepository = menuRepository;
        }
        public async Task<ListResultDto<MenuDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var rets = await _menuRepository.GetListAsync(includeDetails: true, cancellationToken: cancellationToken);
            //组织菜单
            return Organize(rets);
        }

        private ListResultDto<MenuDto> Organize(List<Menu> rets)
        {
            var menus = new List<MenuDto>(rets.Count);
            //find parents
            var parents = rets.Where(p => p.ParentID == 0).ToList();
            menus.AddRange(parents.Select(p => new MenuDto(p.Id, p.Name, p.Url, p.Icon)));
            RecuriseFindMenu(rets, menus);
            return new ListResultDto<MenuDto>(menus);
        }

        private void RecuriseFindMenu(List<Menu> rets, List<MenuDto> targets)
        {
            for (int i = 0; i < targets.Count; i++)
            {
                var m = targets[i];
                var c = rets.Where(p => p.ParentID == m.Id);
                if (!c.Any()) continue;
                m.Childs.AddRange(c.Select(p => new MenuDto(p.Id, p.Name, p.Url, p.Icon)));
                RecuriseFindMenu(c.ToList(), targets);
            }
        }

        public Task<PagedResultDto<MenuDto>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<AbpPracticeResponse> InsertAsync([NotNull]MenuDto menuDto, CancellationToken cancellationToken = default)
        {
            var menu = new Menu(menuDto.Name, menuDto.Url, menuDto.Icon);
            var menuChilds = menuDto.Childs?.Select(p => new Menu(p.Name, p.Url, p.Icon)).ToList();
            menu.AddChildMenus(menuChilds);
            var info = await _menuManager.InsertMenuAsync(menu);
            //TODO
            return await Task.FromResult(new AbpPracticeResponse(false));
        }
    }
}
