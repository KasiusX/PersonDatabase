using PersonDatabaseLogic.PersonLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace PersonDatabaseLogic.DataAccess
{
    internal static class FileExtensions
    {
        private static readonly string saveDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\PersonDatabase\";
        private static readonly string saveFile = GetDirecotory() + "data.txt";

        private static string GetDirecotory()
        {
            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }
            return saveDirectory;
        }

        internal static string GetSaveFile()
        {            
            return saveFile;
        }

        internal static string ConvertToString(this List<Person> people)
        {
            string output = "";
            foreach(Person p in people)
            {
                output += ConvertToString(p) + "|";
            }
            return output.Substring(0,output.Length-1);
        }

        private static string ConvertToString(Person p)
        {
            return $"{p.Id}:{p.FirstName}:{p.LastName}";
        }


        internal static List<Person> ConvertToPersonModels(this string peopleData)
        {
            if(peopleData == "")
            {
                return new List<Person>();
            }

            List<Person> output = new List<Person>();
            foreach (string data in peopleData.Split("|"))
            {
                output.Add(ToPersonModel(data));
            }
            return output;
        }

        private static Person ToPersonModel(string s)
        {
            string[] data = s.Split(":");
            return new Person { Id= Convert.ToInt32(data[0]), FirstName = data[1], LastName = data[2] };
        }
    }
}
