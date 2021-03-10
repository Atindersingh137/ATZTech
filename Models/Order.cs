using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ATZTech.Models  // Models 
{
    public class Order // order class in the model folder 
    {
        public int ID { get; set; }    // order id 
      //  [ForeignKey("User")]
        public int UserID { get; set; }    // user id as a forignkey from user table 
        public User User { get; set; }    // link user class with order 

        


       // [ForeignKey("Product")]
        public int ProductID { get; set; }   // product is as a forign key from product table 
        public Product Product { get; set; } // link product class  with products
    }
}
