using PersonDatabaseLogic.DataAccess;
using System.Collections.Generic;

namespace PersonDatabaseLogic.PersonLogic
{
    public class PersonController
    {
        FileWriting fileWriting = new FileWriting();

        public void AddPerson(Person p)
        {
            if (IsPersonValid(p))
            {
                fileWriting.SavePerson(p);
            }
        }

        private bool IsPersonValid(Person p)
        {
            if(p.FirstName == null)
            {
                throw new ValidationException("Jméno nesmí být prázdné.");
            }
            else if(p.LastName == null)
            {
                throw new ValidationException("Přijmení nesmí být prázdné.");
            }
            else if(p.FirstName.Contains(':') || p.FirstName.Contains('|'))
            {
                throw new ValidationException("Jméno nesmí obsahovat znaky '|' a ':'.");
            }
            else if (p.LastName.Contains(':') || p.LastName.Contains('|'))
            {
                throw new ValidationException("Příjmení nesmí obsahovat znaky '|' a ':'.");
            }
            else if (p.FirstName.Length < 2)
            {
                throw new ValidationException("Jméno musí mít minimálně dvě písmena");
            }
            else if (p.LastName.Length < 2)
            {
                throw new ValidationException("Přijmené musí mít minimálně dvě písmena");
            }
            return true;
        }

        public List<Person> GetPeople()
        {
            return fileWriting.GetPeople();
        }

        public void DeletePerson(int id)
        {
            fileWriting.DeletePerson(id);
        }
    }
}
