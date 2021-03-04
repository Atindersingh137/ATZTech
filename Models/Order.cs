using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ATZTech.Models
{
    public class Order
    {
        public int ID { get; set; }
      //  [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

        


       // [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
