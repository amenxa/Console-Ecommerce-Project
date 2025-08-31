using ecom.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom
{
    
    internal class discount
    {
        //Open Closed Principle
        public double Discount(CustomerType customerType)
        {
            if (customerType == CustomerType.Normal)
                return 0.20;
            else return 0.50;    
            
        }
    }
}
