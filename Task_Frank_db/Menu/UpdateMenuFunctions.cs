using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Frank_db.Models;

namespace Task_Frank_db.Menu
{
    public class UpdateMenuFunctions
    {

        public static void Update(int id)
        {
            bool flag = true;

            DatabaseContext db = new DatabaseContext();
            var b = db.Persons.Include("Address")
                .Where(s => s.Id == Convert.ToInt32(id))
                        .Include("Address")
                        .FirstOrDefault();

            Console.Write(Convert.ToString(b.Id) + " ");
            Console.Write(b.FirstName + " ");
            Console.Write(b.LastName + " ");
            Console.Write(b.Gender + " ");
            Console.Write(Convert.ToString(b.Age) + " ");
            Console.Write(b.Address.Town + " ");
            Console.Write(b.Address.StreetName + " ");
            Console.Write(b.Address.HouseNumber + " \n\n");

            while (flag)
            {
                int choose = 0;
                Console.WriteLine("What would you like to update? Choose a number to make a decision.");
                Console.WriteLine("1 - Update first name");
                Console.WriteLine("2 - Update last name");
                Console.WriteLine("3 - Update gender");
                Console.WriteLine("4 - Update age");
                Console.WriteLine("5 - Update town");
                Console.WriteLine("6 - Update street");
                Console.WriteLine("7 - Update house number");
                Console.WriteLine("8 - Exit");

                try
                {
                    int tempChoose = Convert.ToInt32(Console.ReadLine());
                    if (tempChoose >= 1 && tempChoose <= 8)
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
                    Console.WriteLine("Please write a new first name: ");
                    string newFirstName = Console.ReadLine();
                    b.FirstName = newFirstName;
                    db.SaveChanges();
                    Console.WriteLine($"\nFirst name changed. New first name is {newFirstName}\n");
                }


                if (choose == 2)
                {
                    Console.WriteLine("Please write a new last name: ");
                    string newLastName = Console.ReadLine();
                    b.LastName = newLastName;
                    db.SaveChanges();
                    Console.WriteLine($"\nLast name changed. New last name is {newLastName}\n");
                }

                if (choose == 3)
                {
                    Console.WriteLine("Please write a new gender: ");
                    string newGender = Console.ReadLine();
                    b.Gender = newGender;
                    db.SaveChanges();
                    Console.WriteLine($"\nGender changed. New gender is {newGender}\n");
                }

                if (choose == 4)
                {
                    bool intFlag = true;
                    while (intFlag)
                    {
                        Console.WriteLine("Please write a new age: ");
                        try
                        {
                            int newAge = Convert.ToInt32(Console.ReadLine());
                            b.Age = newAge;
                            db.SaveChanges();
                            Console.WriteLine($"\nAge changed. New age is {newAge}\n");
                            intFlag = false;
                        }
                        catch
                        {
                            Console.WriteLine("Bad imput. Age must be a number");
                        }
                    }

                }

                if (choose == 5)
                {
                    Console.WriteLine("Please write a new town: ");
                    string newTown = Console.ReadLine();
                    b.Address.Town = newTown;
                    db.SaveChanges();
                    Console.WriteLine($"\nTown changed. New town is {newTown}\n");
                }

                if (choose == 6)
                {
                    Console.WriteLine("Please write a new street name ");
                    string newStreetName = Console.ReadLine();
                    b.Address.StreetName = newStreetName;
                    db.SaveChanges();
                    Console.WriteLine($"\nStreet name changed. New street name is {newStreetName}\n");
                }

                if (choose == 7)
                {
                    Console.WriteLine("Please write a new house number ");
                    string newHouseNumber = Console.ReadLine();
                    b.Address.HouseNumber = newHouseNumber;
                    db.SaveChanges();
                    Console.WriteLine($"\nStreet name changed. New street name is {newHouseNumber}\n");
                }


                if (choose == 8)
                {
                    flag = false;
                }
            }
        }
    }
}
