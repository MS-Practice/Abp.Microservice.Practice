using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class DomainArgumentException : Exception
    {
        public DomainArgumentException() : base()
        {
        }
        public DomainArgumentException(string message) : base(message) { }

        public DomainArgumentException(string message, Exception innerException) : base(message, innerException) {
        }
    }
}
