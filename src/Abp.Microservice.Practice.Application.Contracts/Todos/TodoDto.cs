using System;
using Volo.Abp.Application.Dtos;

namespace Abp.Microservice.Practice.Todos
{
    public class TodoDto : EntityDto<Guid>
    {
        public string Text { get; set; }
    }
}