using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Task_Frank_db.Models;

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
                        Console.WriteLine("Bad input. Try again.");
                    }
                }
                catch
                {
                    Console.WriteLine("Bad input. Try again.");
                }

                if (choose == 1)
                {
                    Console.WriteLine("Enter your first name: ");
                    firstName = Console.ReadLine();

                    Console.WriteLine("Enter your last name: ");
                    lastName = Console.ReadLine();

                    Console.WriteLine("Enter your age: ");
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

                    Console.WriteLine("Enter your gender: ");
                    gender = Console.ReadLine();

                    Console.WriteLine("Enter your town: ");
                    town = Console.ReadLine();

                    Console.WriteLine("Enter streetname: ");
                    streetName = Console.ReadLine();

                    Console.WriteLine("Enter your houseNumber: ");
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

                    DatabaseContext db = new DatabaseContext();
                    var a = db.Persons;
                    foreach (var i in a)
                    {
                        Console.WriteLine(i.FirstName);
                    }
                    



                    Console.WriteLine(a);
                    
                    
                    

                }
            }

        }
    }
}
