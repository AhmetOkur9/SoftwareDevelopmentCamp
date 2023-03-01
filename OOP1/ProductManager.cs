using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added.");
        }

        public int addition(int number1 ,int number2)
        {
            return number1+number2;
        }

        public void addition2(int number1, int number2)
        {
            Console.WriteLine(number1+number2);
        }
    }
}
