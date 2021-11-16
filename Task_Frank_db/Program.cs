using Microsoft.EntityFrameworkCore;
using System;
using Task_Frank_db.Models;

namespace Task_Frank_db
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Press any key to continue.");
            //Console.ReadKey();

            // Person
            int age;
            string firstName;
            string lastName;
            string gender;

            // Address
            string streetName;
            string town;
            string houseNumber;

            // Todo gather Address information

            //Console.WriteLine("Enter your first name: ");
            //firstName = Console.ReadLine();

            //Console.WriteLine("Enter your last name: ");
            //lastName = Console.ReadLine();

            //Console.WriteLine("Enter your gender: ");
            //gender = Console.ReadLine();

            //Console.WriteLine("Enter your age: ");

            // Todo check the input data
            // Converted string to int
            //age = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Enter your streetname: ");
            //streetName = Console.ReadLine();

            //Console.WriteLine("Enter your town: ");
            //town = Console.ReadLine();

            //Console.WriteLine("Enter your houseNumber: ");
            //houseNumber = Console.ReadLine();

            /*var newPerson = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Gender = gender
            };

            var newAddress = new Address
            {
                StreetName = streetName,
                HouseNumber = houseNumber,
                Town = town
            };
            */
            /*
            var options = new DbContextOptionsBuilder<PersonAddressDBContext>()
                .UseSqlite("Filename=../../../MyLocalDB.db")
                .Options;

            using var db = new PersonAddressDBContext(options);

            db.Database.EnsureCreated();
            */
        }
    }
}
