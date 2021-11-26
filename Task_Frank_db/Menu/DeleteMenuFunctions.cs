using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Frank_db.Models;

namespace Task_Frank_db.Menu
{
    public class DeleteMenuFunctions
    {
        public static void DeletePerson(int idPeopleToDelete)
        {
            DatabaseContext db = new DatabaseContext();
            var person = new Person()
            {
                Id = idPeopleToDelete
            };
            try
            {
                db.Remove<Person>(person);
                db.SaveChanges();
                Console.WriteLine($"\nPerson with {idPeopleToDelete} is deleted from the database\n");
            }
            catch
            {
                Console.WriteLine("\nRecord with this id doesn't exist in the database.\n");
            }
        }  
    }
    
}
