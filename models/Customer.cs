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
        public string VisaInfo {  get; set; }

        CustomerType Type { get; set; }
        List<Order> Orders { get; set; }
        public override Role Access()
        {
            return Role.customer;
        }
    }
}
