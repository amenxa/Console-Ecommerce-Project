using ecom.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom
{
    
    internal class Discount
    {
        //Open Closed Principle
        private static readonly Dictionary<CustomerType, double> _map =
        new()
        {
                { CustomerType.Normal,  0.20 },
                { CustomerType.Premium, 0.50 },
        };

        public double GetDiscount(CustomerType customerType) =>
            _map.TryGetValue(customerType, out var d) ? d : 0;
    }
}
