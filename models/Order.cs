using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.models
{
    internal class Order
    {
        public int Id { get; set; }

        public Customer customer { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        List<Product> products { get; set; }



    }
}
