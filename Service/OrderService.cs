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
        public Order PlaceOrder(Customer customer) 
        { 
            Order o = new Order();
            o.Id = (IDnow*33336)%5553;
            IDnow+=22;
            o.CreatedDate = DateTime.Now;
            o.UpdatedDate = DateTime.Now;
            o.customer = customer;
            return o;

        }
        // single Responsiblility prnciple !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public double Discount(CustomerType customerType)
        {
            if (customerType == CustomerType.Normal)
                return 0.20;
            else return 0.50;

        }
    }
}
