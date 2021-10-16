using PersonDatabaseLogic;
using PersonDatabaseLogic.DataAccess;
using PersonDatabaseLogic.PersonLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDatabaseConsoleUI
{
    public class DisplayManager
    {
        private PersonController personController = new PersonController();

        public void DisplayPersonAdding()
        {
            Console.Write("Křestní jméno: ");
            string firstName = Console.ReadLine();
            Console.Write("Príjmení: ");
            string lastName = Console.ReadLine();
            try
            {                
                personController.AddPerson(new Person { FirstName = firstName, LastName = lastName });
                Console.WriteLine($"{firstName} {lastName} přidán/a do databáze.");
            }
            catch (ValidationException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        public void DisplayPersonDeleting()
        {
            Console.Write("Id:");
            string id = Console.ReadLine();
            try
            {
                personController.DeletePerson(Convert.ToInt32(id));
                Console.WriteLine($"Osoba s id:{id} byla odstraněna");
            }
            catch (PersonNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Prosím zadejte číslo.");
            }
            Console.ReadKey();
        }

        public void DisplayPeopleDisplaing()
        {
            List<Person> people = personController.GetPeople();
            if (people.Count == 0)
            {
                Console.WriteLine("Databáze je prázdná.");
            }
            else
            {
                foreach (Person person in personController.GetPeople())
                {
                    Console.WriteLine(person.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
