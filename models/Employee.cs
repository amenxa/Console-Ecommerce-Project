using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.models
{
    internal class Employee : AUser
    {
        public int salary { get; set; }

        public override Role access()
        {
            return Role.employee;
        }
    }
}
