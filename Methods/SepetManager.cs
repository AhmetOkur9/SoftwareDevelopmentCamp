using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + "Added to Cart");
        }
    }
}
