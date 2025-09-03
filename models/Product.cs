using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.models
{
    internal class Product
    {
        public static int idCount = 0;
        public Product(string Name , int price , int quantity)
        {
            this.Name = Name;
            this.price = price;
            this.quantity = quantity;
            Id = idCount++;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int price { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
        public int quantity { get; set; }
        public string Description { get; set; }

         
    }
}
