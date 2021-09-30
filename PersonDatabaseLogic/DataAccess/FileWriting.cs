using PersonDatabaseLogic.PersonLogic;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace PersonDatabaseLogic.DataAccess
{
    internal class FileWriting
    {
        internal void SavePerson(Person p)
        {
            List<Person> people = GetPeople();
            p.Id = GetNewId(people);
            people.Add(p);
            SavePeople(people);
        }

        private int GetNewId(List<Person> people)
        {
            return people.Count == 0 ? 0 : people.OrderBy(x => x.Id).Last().Id + 1;
        }

        internal void DeletePerson(int id)
        {
            List<Person> people = GetPeople();
            if (people.Where(x => x.Id == id).Count() > 0)
            {
                SavePeople(people.Where(x => x.Id != id).ToList());
            }
            else
            {
                throw new PlayerNotFoundException($"Osoba s id:{id} nenalezena.");
            }
        }

        internal List<Person> GetPeople()
        {
            string saveFile = FileExtensions.GetSaveFile();
            if (!File.Exists(saveFile))
            {
                return new List<Person>();
            }
            string data = "";
            using (StreamReader sr = new StreamReader(saveFile))
            {
                data = sr.ReadToEnd();
            }

            return data.ConvertToPersonModels();
        }

        internal void SavePeople(List<Person> people)
        {
            using (StreamWriter sw = new StreamWriter(FileExtensions.GetSaveFile()))
            {
                sw.Write(people.Count == 0? "" : people.ConvertToString());
            }
        }

    }
}
