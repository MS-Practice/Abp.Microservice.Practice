using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.Microservice.Practice.Domain.Exceptions
{
    public class DomainArgumentException : Exception
    {
        private string v;

        public DomainArgumentException() : base()
        {
        }
        public DomainArgumentException(string message) : base(message) { }

        public DomainArgumentException(string message, Exception innerException) : base(message, innerException) {
        }
    }
}
