using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;

            do
            {
                Console.WriteLine("{0}", numero);
                numero++;
            } while (numero != 11);
            Console.ReadKey();
        }
    }
}
