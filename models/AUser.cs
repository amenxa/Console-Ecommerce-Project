using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ecom.models
{
    public enum Role { customer ,employee , manager}
    internal abstract class AUser
    {
        int Id { set; get; }
        string Name { set; get; }

        DateTime DateOfBirth { set; get; }

        string Address { set; get; }

        // Liskov Substitution Principle !!!!!!!!!!!!!!!!!!!!!!!! 
        public string Position; 
        public abstract Role Access();
    }
}
