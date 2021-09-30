using System;

namespace PersonDatabaseLogic.DataAccess
{
    public class PlayerNotFoundException : Exception
    {
        public PlayerNotFoundException(string message) :base(message)
        {

        }
    }
}
