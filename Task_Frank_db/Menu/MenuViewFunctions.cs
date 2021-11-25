using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Frank_db.Models;

namespace Task_Frank_db
{
    public class MenuViewFunctions
    {
        public static void GetAll()
        {
            DatabaseContext db = new DatabaseContext();
            var a = db.Persons.Include("Address");
            Console.WriteLine();
            foreach (var i in a)
            {
                Console.Write(Convert.ToString(i.Id) + " ");
                Console.Write(i.FirstName + " ");
                Console.Write(i.LastName + " ");
                Console.Write(i.Gender + " ");
                Console.Write(Convert.ToString(i.Age) + " ");
                Console.Write(i.Address.Town + " ");
                Console.Write(i.Address.StreetName + " ");
                Console.Write(i.Address.HouseNumber + " \n");
            }
            Console.WriteLine();


        }

        public static void GetLastName(string lastname)
        {
            DatabaseContext db = new DatabaseContext();
            var b = db.Persons.Include("Address")
                .Where(s => s.LastName == lastname)
                        .Include("Address")
                        .FirstOrDefault();

            if (b != null)
            {
                Console.WriteLine("\nPerson with this lastname is in the database");

                Console.Write(Convert.ToString(b.Id) + " ");
                Console.Write(b.FirstName + " ");
                Console.Write(b.LastName + " ");
                Console.Write(b.Gender + " ");
                Console.Write(Convert.ToString(b.Age) + " ");
                Console.Write(b.Address.Town + " ");
                Console.Write(b.Address.StreetName + " ");
                Console.Write(b.Address.HouseNumber + " \n\n");
            }
            else
            {
                Console.WriteLine("\nPerson with this lastname isn't in the database\n");
            }
        }

        public static void GetTown(string town)
        {
            DatabaseContext db = new DatabaseContext();
            var b = db.Persons.Include("Address")
                .Where(s => s.Address.Town == town)
                        .Include("Address")
                        .FirstOrDefault();

            if (b != null)
            {
                Console.WriteLine("\nThere is a person in the database who lives in this town");

                Console.Write(Convert.ToString(b.Id) + " ");
                Console.Write(b.FirstName + " ");
                Console.Write(b.LastName + " ");
                Console.Write(b.Gender + " ");
                Console.Write(Convert.ToString(b.Age) + " ");
                Console.Write(b.Address.Town + " ");
                Console.Write(b.Address.StreetName + " ");
                Console.Write(b.Address.HouseNumber + " \n\n");
            }
            else
            {
                Console.WriteLine("\nThere isn't a person in the database who lives in this town\n");
            }
        }
       
        
    }
}
