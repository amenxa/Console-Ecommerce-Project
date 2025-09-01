using ecom.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ecom.Service
{
    internal class ProductService
    {
        List<Product> Products;
        public void AddProduct(Product product)
        {
            if (product.Quantity == 0)
            {
                Console.WriteLine("this Product have no quantity");
                return;
            }
                product.CreatedAt = DateTime.Now;
                product.UpdatedAt = DateTime.Now;

            Products.Add(product);

            
           
        }

        public void RemoveProduct(int productId) 
        {
            Products = Products.Where(x =>x.Id != productId).ToList();
        }
        
        public List<Product> GetProducts(Func<Product,bool> fillter  ) {
            return Products.Where(fillter).ToList();
        }
      


    }
}
