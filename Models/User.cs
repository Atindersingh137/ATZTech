using System;
using System.Collections.Generic;  // library 
using System.Linq;
using System.Threading.Tasks;

namespace ATZTech.Models
{
    public class User // user class 
    {
        
        public int ID { get; set; }  // promery key for user table 
       
        public string FirstName { get; set; } // user name 
        public string LastName { get; set; } 
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public int Mobile { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
