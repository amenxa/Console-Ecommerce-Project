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
        private readonly Discount _discount = new();

        List<Order> orders = new List<Order>();
        public Order PlaceOrder(Customer customer) 
        { 
            Order o = new Order();
            o.Id = (IDnow*33336)%5553;
            IDnow+=22;
            o.CreatedAt = DateTime.Now;
            o.UpdatedAt = DateTime.Now;
            o.Customer = customer;
            o.Products = new();
            orders.Add(o);
            return o;

        }
        // single Responsiblility prnciple !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public double GetDiscount(CustomerType customerType)
        {
            return _discount.GetDiscount(customerType);
        }
    }
}
