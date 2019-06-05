using System.Threading.Tasks;
using Abp.Microservice.Practice.Menus;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Microservice.Practice.Todos
{
    [RemoteService]
    [Area("Practice")]
    [Route("api/Practice/todos")]
    [Authorize]
    public class TodosController : AbpController
    {
        private readonly IMenuAppService _todoAppService;

        public TodosController(IMenuAppService todoAppService)
        {
            _todoAppService = todoAppService;
        }

        [HttpGet]
        [Route("")]
        public Task<PagedResultDto<MenuDto>> GetListAsync()
        {
            return _todoAppService.GetListAsync();
        }
    }
}
