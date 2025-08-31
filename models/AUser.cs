using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ecom.models
{
    public enum Rule { customer ,employee , manegar}
    internal abstract class AUser
    {
        int Id { set; get; }
        string name { set; get; }

        Date DateOfbirth { set; get; }

        string address { set; get; }

        // Liskov Substitution Principle !!!!!!!!!!!!!!!!!!!!!!!! 
        public string Position; 
        public abstract Rule access();
    }
}
