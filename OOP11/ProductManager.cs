using System;
using System.Collections.Generic;
using System.Text;

namespace OOP11
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "  Eklendi.");
        }
        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + "  Güncellendi.");
        }
    }
}
