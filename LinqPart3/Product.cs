using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPart3
{
    public class Product
    {
        public string Name;
        public int Quantity;
        public Product(string Name, int Quantity)
        {
            this.Name = Name;
            this.Quantity = Quantity;
        }
    }
}
