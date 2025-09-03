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

        public List<Product> products { get; set; }

        public void GetBill()
        {
            Console.WriteLine($"You Have Buy {products.Count} Product");
            int i = 0 ,sum =0;
            foreach (var item in products) 
            {
                Console.WriteLine($"{++i}. {item.Name} with price {item.price} .");
                sum += item.price;
            }
            Console.WriteLine($"the Total sum is {sum}");
            Console.WriteLine($"Your discount is {discount.Discount(customer.type)}\n");
            Console.WriteLine($"the final amount to pay {sum - sum *discount.Discount(customer.type)}\n");
        }

    }
}
