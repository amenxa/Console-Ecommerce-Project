using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.models
{
    internal class Employee : AUser
    {
        public decimal Salary { get; set; }

        public override Role Access()
        {
            return Role.employee;
        }
    }
}
