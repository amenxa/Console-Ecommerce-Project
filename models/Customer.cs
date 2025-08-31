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
        public string visainfo {  get; set; }

        CustomerType type { get; set; }
        List<Order> orders { get; set; }
        public override Rule access()
        {
            return Rule.customer;
        }
    }
}
