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
            DisplayManager display = new DisplayManager();
            bool leave = false;
            while (!leave)
            {
                Console.Clear();
                Console.WriteLine("1.Přidat osobu\n2.Odstranit osobu\n3.Vypsat osoby\n4.Odejít");
                char choice = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (choice)
                {
                    case '1':
                        display.DisplayPersonAdding();
                        break;
                    case '2':
                        display.DisplayPersonDeleting();
                        break;
                    case '3':
                        display.DisplayPeopleDisplaing();
                        break;
                    case '4':
                        leave = true;
                        break;
                    default:
                        Console.WriteLine("Neplatná volba.");
                        break;
                }
            }
        }
    }
}
