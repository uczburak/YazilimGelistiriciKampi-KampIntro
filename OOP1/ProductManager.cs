using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Product Added : " + product.ProductName);
        }
        
        public void Update(Product product)
        {
            Console.WriteLine("Product Updated : " + product.ProductName);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Product Deleted : " + product.ProductName);
        }
    }
}
