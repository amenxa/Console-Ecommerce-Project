using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.models
{
    public enum CustomerType { Normal, Premium }
    internal class Customer : AUser
    {
        private static int countId = 5;
        public Customer(CustomerType customerType = CustomerType.Normal)
        {
            countId *=433221;
            countId %= 35555;
            Id = countId;
            CreatDate = DateTime.Now;
            type = customerType;
            orders= new List<Order>();
            
        }
        public string visainfo {  get; set; }

        DateTime CreatDate { get; set; }
        public CustomerType type { get; set; }
        public List<Order> orders { get; set; }
        public override Role access()
        {
            return Role.customer;
        }
    }
}
