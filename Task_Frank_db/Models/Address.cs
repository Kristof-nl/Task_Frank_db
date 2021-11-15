using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Frank_db.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string Town { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
    }
}
