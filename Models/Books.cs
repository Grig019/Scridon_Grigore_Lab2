using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace Scridon_Grigore_Lab2.Models

{
    
    public class Books
    { 
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
