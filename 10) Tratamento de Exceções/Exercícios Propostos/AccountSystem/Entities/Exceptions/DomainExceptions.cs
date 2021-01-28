using System;

namespace AccountSystem.Entities.Exceptions
{
    class DomainExceptions : Exception
    {
        public DomainExceptions(string message) : base(message)
        {
        }
    }
}
