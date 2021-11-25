using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Task_Frank_db.Models;
using Task_Frank_db;
using static Task_Frank_db.MenuViewFunctions;
using static Task_Frank_db.Menu.UpdateMenuFunctions;

namespace Task_Frank_db
{
    class Program
    {

        static void Main(string[] args)
        {

            bool menu = true;
            int choose = 0;

            // Person
            int age = 0;
            string firstName;
            string lastName;
            string gender;

            // Address
            string streetName;
            string town;
            string houseNumber;


            while (menu)
            {
                Console.WriteLine("Choose an action by typing his number: ");
                Console.WriteLine("1 - Add Person to database");
                Console.WriteLine("2 - See whole database");
                Console.WriteLine("3 - Search for a specific data in the database");
                Console.WriteLine("4 - Exit program");
                try
                {
                    int tempChoose = Convert.ToInt32(Console.ReadLine());
                    if (tempChoose >= 1 && tempChoose <= 4)
                    {
                        choose = tempChoose;
                    }
                    else
                    {
                        Console.WriteLine("\nBad input. Try again.\n");
                    }
                }
                catch
                {
                    Console.WriteLine("\nBad input. Try again.\n");
                }

                if (choose == 1)
                {
                    Console.WriteLine("Enter first name: ");
                    firstName = Console.ReadLine();

                    Console.WriteLine("Enter last name: ");
                    lastName = Console.ReadLine();

                    Console.WriteLine("Enter age: ");
                    try
                    {
                        int tempAge = Convert.ToInt32(Console.ReadLine());
                        if (tempAge >= 0 && tempAge <= 130)
                        {
                            age = tempAge;
                        }
                        else
                        {
                            Console.WriteLine("Bad input. Age must be between 0 and 130.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Bad input. Age must be between 0 and 130.");
                    }

                    Console.WriteLine("Enter gender: ");
                    gender = Console.ReadLine();

                    Console.WriteLine("Enter town: ");
                    town = Console.ReadLine();

                    Console.WriteLine("Enter streetname: ");
                    streetName = Console.ReadLine();

                    Console.WriteLine("Enter  house number: ");
                    houseNumber = Console.ReadLine();


                    using DatabaseContext myContext = new DatabaseContext();
                    var person = new Person()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Gender = gender,
                        Address = new Address
                        {
                            Town = town,
                            StreetName = streetName,
                            HouseNumber = houseNumber
                        }
                    };
                    myContext.Persons.Add(person);
                    myContext.SaveChanges();
                }

                if (choose == 2)
                {
                   GetAll();
                }


                if (choose == 3)
                {
                    bool flag = true;

                    while (flag)
                    {
                        Console.WriteLine("Choose an action by typing his number: ");
                        Console.WriteLine("1 - Search a person by his lastname");
                        Console.WriteLine("2 - Search a person by his town");
                        try
                        {
                            int tempChoose = Convert.ToInt32(Console.ReadLine());
                            if (tempChoose >= 1 && tempChoose <= 2)
                            {
                                choose = tempChoose;
                            }
                            else
                            {
                                Console.WriteLine("\nBad input. Try again.\n");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("\nBad input. Try again.\n");
                        }

                        if (choose == 1)
                        {
                            Console.Write("Write a lastname what you're looking for: ");
                            string userLastName = Console.ReadLine();
                            GetLastName(userLastName);
                            flag = false;
                        }

                        if (choose == 2)
                        {
                            Console.Write("Write a town what you're looking for: ");
                            string userTown = Console.ReadLine();
                            GetTown(userTown);
                            flag = false;
                        }
                    }
                }
                if (choose == 4)
                {
                    DatabaseContext db = new DatabaseContext();
                    var count = db.Persons.Count();
                    
                    Console.WriteLine(count);

                    Console.Write("Write an id person to edit");
                    try
                    {


                        int tempChoose = Convert.ToInt32(Console.ReadLine());
                        if (tempChoose >= 1 && tempChoose <= 4)
                        {
                            choose = tempChoose;
                        }
                        else
                        {
                            Console.WriteLine("\nBad input. Try again.\n");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nBad input. Try again.\n");
                    }

                    //string userTown = Console.ReadLine();
                    //Update("1");
                }
            }

        }
    }
}
