using ecom.models;
using ecom.Service;

namespace ecom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productService = new ProductService();
            productService.addProduct(new Product("item1", 1200,4));
            productService.addProduct(new Product("item2", 1500,5));
            productService.addProduct(new Product("item3", 55,6));
            productService.addProduct(new Product("item4", 333,7));

            OrderService orderService = new OrderService();

            CustomerService customerService = new CustomerService();

            customerService.startShoping(productService, orderService);
        }
    }
}
