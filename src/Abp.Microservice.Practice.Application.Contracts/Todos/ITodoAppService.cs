using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Abp.Microservice.Practice.Todos
{
    public interface ITodoAppService
    {
        Task<PagedResultDto<TodoDto>> GetListAsync();
    }
}