using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.Microservice.Practice.Domain.Shared.Dtos
{
    public class AbpPracticeResponse<T>
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
        public List<T> Items { get; set; }
    }

    public class AbpPracticeResponse
    {
        public AbpPracticeResponse() : this(false) { }

        public AbpPracticeResponse(bool success)
        {
            Success = success;
        }

        public string Message { get; set; }
        public bool Success { get; set; }
        public object Data { get; set; }
    }
}
