using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Frank_db.Models
{
    [Table("Addresses")]
    public class Address
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column(TypeName ="varchar(25)")]
        public string Town { get; set; }
        [Column(TypeName ="varchar(25)")]
        public string StreetName { get; set; }
        [Column(TypeName ="varchar(25)")]
        public string HouseNumber { get; set; }
    }
}
