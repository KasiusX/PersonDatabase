using PersonDatabaseLogic.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDatabaseLogic
{
    public class PersonController
    {
        FileWriting fileWriting = new FileWriting();

        public void AddPerson(Person p)
        {
            if (true)
            {
                fileWriting.SavePerson(p);
            }
        }

        public List<Person> GetPeople()
        {
            return fileWriting.GetPeople();
        }
    }
}
