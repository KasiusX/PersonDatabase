using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace PersonDatabaseLogic.DataAccess
{
    internal class FileWriting
    {
        internal void SavePerson(Person p)
        {
            List<Person> people = GetPeople();
            if (people.Count == 0)
            {
                p.Id = 0;
            }
            else
            {
                p.Id = people.OrderBy(x => x.Id).First().Id + 1;
            }
            people.Add(p);
            using(StreamWriter sw = new StreamWriter(FileExtensions.GetSaveFile()))
            {
                sw.Write(people.ConvertToString());
                Console.WriteLine(people.ConvertToString());
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

            return data == "" ? new List<Person>() : data.ConvertToPersonModels();
        }
    }
}
