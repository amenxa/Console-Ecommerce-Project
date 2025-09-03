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
        public int Id { set; get; }
        public string name { set; get; }

        public Date DateOfbirth { set; get; }

        public string address { set; get; }

        // Liskov Substitution Principle !!!!!!!!!!!!!!!!!!!!!!!! 
        public string Position; 
        public abstract Role access();
    }
}
