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
        List<Product> products;
        public ProductService()
        {
            products = new List<Product>();
        }
        public void addProduct(Product product)
        {
            if (product.quantity == 0)
            {
                Console.WriteLine("this Product have no quantity");
                return;
            }
                product.CreatedDate = DateTime.Now;
                product.UpdatedDate = DateTime.Now;

                products.Add(product);
        }

        public void removeProduct(int productId) 
        {
            products = products.Where(x =>x.Id != productId).ToList();
        }
        
        public List<Product> getProducts(Func<Product,bool> fillter  ) {
            return products.Where(fillter).ToList();
        }

        public Product getProductsById (int productId)
        {
            return products.FirstOrDefault(n => n.Id == productId);
        }




    }
}
