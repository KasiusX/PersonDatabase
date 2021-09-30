using System;

namespace PersonDatabaseLogic.PersonLogic
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
}
