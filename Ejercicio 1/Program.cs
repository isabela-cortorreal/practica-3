using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_positivo = 1, contador = 0, suma = 0, numero_almacenado;

            while (numero_positivo > 0)
            {
                contador++;
                Console.Write("Ingrese un numero positivo: ");
                numero_positivo = int.Parse(Console.ReadLine());
                numero_almacenado = numero_positivo;

                if (numero_almacenado > 0)
                {
                    suma = suma + numero_almacenado;
                }
            }
            Console.Write("La suma de los numeros positivos es: " + suma);
            Console.ReadKey();
        }
    }
}
