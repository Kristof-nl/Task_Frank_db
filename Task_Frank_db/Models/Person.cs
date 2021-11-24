using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Frank_db.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="varchar(25)")]
        public string FirstName { get; set; }
        [Column(TypeName ="varchar(25)")]
        public string LastName { get; set; }
        [Column(TypeName ="varchar(3)")]
        public int Age { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Gender { get; set; }
        public Address Address { get; set; }



        //public  Address Address { get; set; }

    }
}
