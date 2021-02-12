using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeros 10 números pares a partir del producto de (10 x 10)");

            for (int i = 100; i <= 118; i = i + 2)
            {
                Console.WriteLine(i + "\n");
            }
            Console.ReadKey();
        }
    }
}
