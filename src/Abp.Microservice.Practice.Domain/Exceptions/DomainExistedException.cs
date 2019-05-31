using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace Abp.Microservice.Practice.Domain.Exceptions
{
    public class DomainExistedException : BusinessException
    {
        public DomainExistedException(string argument) : base("DE:00000001", "菜单名称或链接地址已存在") { }
    }
}
