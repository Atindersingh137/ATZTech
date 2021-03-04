using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATZTech.Models
{
    public class Product
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        // [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }


        public ICollection<Order> Orders { get; set; }
    }
}
