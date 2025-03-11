using System;

namespace Product1
{
    class Program
    {
        static void Main()
        {
            Product dorayaki = new Product
            {
                Number = 98,
                Price = 210
            };

            double _taxRate = 0.1;

            Console.WriteLine($"どらやきの消費税額は、{dorayaki.Price * _taxRate}");
        }
    }
}