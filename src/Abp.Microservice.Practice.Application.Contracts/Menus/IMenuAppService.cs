using Abp.Microservice.Practice.Domain.Shared.Dtos;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Abp.Microservice.Practice.Menus
{
    public interface IMenuAppService
    {
        Task<PagedResultDto<MenuDto>> GetListAsync();
        Task<ListResultDto<MenuDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<AbpPracticeResponse> InsertAsync(MenuDto menu, CancellationToken cancellationToken = default);
    }
}