using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Frank_db.Models
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        [Column(TypeName = "varchar(25)")]
        public string Town { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string StreetName { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string HouseNumber { get; set; }

        public int PersonID { get; set; }
        public Person Person { get; set; }

        /*
        public int Person_Id { get; set; }
        public Person Person { get; set; }
        */

    }
}
