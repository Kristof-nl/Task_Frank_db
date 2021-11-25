using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Frank_db.Models;

namespace Task_Frank_db
{
    public class MenuFunctions
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
    }
}
