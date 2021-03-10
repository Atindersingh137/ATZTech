using System;
using System.Collections.Generic; // library 
using System.Linq;
using System.Threading.Tasks;

namespace ATZTech.Models
{
    public class Product
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        // [Key]
        public int ID { get; set; }   // primery key of product table 
        public string Name { get; set; } // name of product 
        public string Image { get; set; } // image 
        public int Price { get; set; } // price of product 
        public string Description { get; set; }  // product description 
         

        public ICollection<Order> Orders { get; set; } // navigation key 
    }
}
