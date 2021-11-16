using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Frank_db.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column(TypeName ="varchar(25)")]
        public string FirstName { get; set; }
        [Column(TypeName ="varchar(25)")]
        public string LastName { get; set; }
        [Column(TypeName ="varchar(25)")]
        public int Age { get; set; }
        [Column("varchar(3)")]
        public string Gender { get; set; }

        [ForeignKey("Address")]
        public int AddressID { get; set; }
        public Address Address { get; set; }
    }
}
