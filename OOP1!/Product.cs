using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1_
{
    class Product  //Ürünlerin özelliklerini tanımlama
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }
}
