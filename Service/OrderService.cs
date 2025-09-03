using ecom.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ecom.Service
{
    internal class OrderService
    {
        static int IDnow = 1;

        List<Order> orders = new List<Order>();
        public Order PlaceOrder(Customer customer, List<Product>listOfProduct, ProductService productService) 
        { 
            Order o = new Order();
            o.Id = (IDnow*33336)%5553;
            IDnow+=22;
            o.CreatedDate = DateTime.Now;
            o.UpdatedDate = DateTime.Now;
            o.customer = customer;
            o.products = listOfProduct;
            Console.WriteLine(o.products.Count);
            orders.Add(o);
            customer.orders.Add(o);
            foreach(Product product in listOfProduct)
            {
                product.quantity--;
            }
            return o;

        }

        public List<Order> getOrders(Func<Order, bool> fillter)
        { 
          return orders.Where(fillter).ToList();
        }
        // single Responsiblility prnciple !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public double getDiscount(CustomerType customerType)
        {
           return discount.Discount(customerType);
        }
    }
}
