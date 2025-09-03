using ecom.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ecom.Service
{
    internal class CustomerService
    {
        List<Customer> customers = new List<Customer>();


        public void startShoping(ProductService pros, OrderService ords)
        {
            while (true)
            {
                Console.WriteLine("Welcome To Prime Shop\n");
                Console.WriteLine("Are you new Customer(y/n)\n");
                Customer cust;
                char ok = char.Parse(Console.ReadLine());
                if (ok == 'n')
                {
                    Console.WriteLine("Whats your ID Number !\n");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Whats your Name !\n");
                    string name = Console.ReadLine();

                    cust = customers.FirstOrDefault(x => x.Id == id);
                    if (cust != null && cust.name.ToLower() == name.ToLower())
                    {
                        Console.WriteLine($"Welcome Mr.{name} You are now in our System !\n");
                    }
                    else
                    {
                        Console.WriteLine("something with your data is Wrong please try again !!\n");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Okay Whats Your Name !\n");
                    string name = Console.ReadLine();
                    cust = new Customer();
                    cust.name = name;
                    Console.WriteLine($"Your Id is {cust.Id} and your name is {cust.name}\n");
                }



                bool done = false;  
                while (true)
                {
                    Console.WriteLine("Choose one\n");
                    Console.WriteLine("1.find Product With Name \n");
                    Console.WriteLine("2.find Product With maximum price \n");
                    Console.WriteLine("3.find Product With mimimum price \n");
                    Console.WriteLine("4.find All the product \n");
                    Console.WriteLine("5.Place Order \n");
                    Console.WriteLine("6.Exit\n");
                    int choosenValue = int.Parse(Console.ReadLine());
                    List<Product> proList;
                    switch (choosenValue)
                    {
                        case 1:
                            Console.WriteLine("please Enter the name of the Product\n");
                            string value = Console.ReadLine();
                            proList = pros.getProducts(n => n.Name.Contains(value));
                            printProducts(proList);
                            break;
                        case 2:
                            Console.WriteLine("please Enter the maximum price of the Product\n");
                            int maxPrice = int.Parse(Console.ReadLine());
                            proList = pros.getProducts(n => n.price <= maxPrice);
                            printProducts(proList);
                            break;
                        case 3:
                            Console.WriteLine("please Enter the minimum price of the Product\n");
                            int minPrice = int.Parse(Console.ReadLine());
                            proList = pros.getProducts(n => n.price >= minPrice);
                            printProducts(proList);
                            break;
                        case 4:
                            proList = pros.getProducts(n => true);
                            printProducts(proList);
                            break;
                        case 5:
                            Console.WriteLine("please enter the number of products you want to buy\n");
                            int numofproduct = int.Parse(Console.ReadLine());
                            List<Product> lop = new List<Product>();
                            Console.WriteLine("Please Enter Products Id one by one \n");
                            while (numofproduct-- > 0)
                            {
                                int id = int.Parse(Console.ReadLine());
                                var pro = pros.getProductsById(id);
                                if (pro == null) Console.WriteLine($"Product with id Dose Not Exist\n ");
                                else
                                {
                                  lop.Add(pro);
                                    Console.WriteLine($"You add Product with Name {pro.Name}\n");
                                }

                            }
                            var o = ords.PlaceOrder(cust, lop, pros);
                            Console.WriteLine($"Your bill :");
                            o.GetBill();
                            break;

                        case 6:
                            done = true;
                            break;
                        default:
                            Console.WriteLine("please Enter A Valid Number");
                            break;

                    }
                    if (done) break;

                }

            }

        }
        public static void printProducts(List<Product> proList)
        {
            int i = 0;
            foreach (var x in proList)
            {
                Console.WriteLine($"{++i}.{x.Name} with id {x.Id} with price {x.price}");
            }
        }
    }
}
