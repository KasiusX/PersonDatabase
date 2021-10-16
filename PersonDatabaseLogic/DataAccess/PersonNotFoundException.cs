using System;

namespace PersonDatabaseLogic.DataAccess
{
    public class PersonNotFoundException : Exception
    {
        public PersonNotFoundException(string message) :base(message)
        {

        }
    }
}
