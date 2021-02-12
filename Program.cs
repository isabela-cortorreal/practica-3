using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 4
            
            char abc;

            for (abc = 'Z'; abc >= 'A'; abc--)
            {
                Console.WriteLine("{0}", abc);
            }
            Console.ReadKey();
        }
    }
}
