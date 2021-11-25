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
        
        public static void Update(string id)
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
                Console.WriteLine("3 - Update age");
                Console.WriteLine("4 - Update gender");
                Console.WriteLine("5 - Update town");
                Console.WriteLine("6 - Update street");
                Console.WriteLine("7 - Update house number");
                Console.WriteLine("8 - Exit");

                try
                {
                    int tempChoose = Convert.ToInt32(Console.ReadLine());
                    if (tempChoose >= 1 && tempChoose <= 7)
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


                if (choose == 8)
                {
                    flag = false;
                }
            }


            db.SaveChanges();
        }
    }
}
