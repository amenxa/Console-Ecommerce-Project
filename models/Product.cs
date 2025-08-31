using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.models
{
    internal class Product
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
        public int quantity { get; set; }
        public string Description { get; set; }

         
    }
}
