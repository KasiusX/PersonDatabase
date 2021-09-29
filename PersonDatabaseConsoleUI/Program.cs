using PersonDatabaseLogic;
using PersonDatabaseLogic.DataAccess;
using System;
using System.Collections.Generic;

namespace PersonDatabaseConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonController personController = new PersonController();
            bool leave = false;
            while (!leave)
            {
                Console.WriteLine("1.Add person\n2.Delete person\n3.List persons\n4.Leave");
                char choice = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (choice)
                {
                    case '1':
                        Console.Write("First name:");
                        string firstName = Console.ReadLine();
                        Console.Write("Last name:");
                        string lastName = Console.ReadLine();
                        personController.AddPerson(new Person { FirstName = firstName, LastName = lastName });
                        Console.Clear();
                        break;
                    case '2':

                        break;
                    case '3':
                        List<Person> people = personController.GetPeople();
                        if (people.Count == 0)
                        {
                            Console.WriteLine("Database is empty");
                        }
                        else
                        {
                            foreach (Person person in personController.GetPeople())
                            {
                                Console.WriteLine(person.ToString());
                            }                            
                        }
                        Console.WriteLine();
                        break;
                    case '4':
                        leave = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
