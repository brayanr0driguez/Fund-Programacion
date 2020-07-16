using System;

namespace ej_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la cantidad de salarios minimos mensuales vigentes que gana: ");
            int smmvl = int.Parse(Console.ReadLine());

            if (smmvl < 2)
            {
                Console.WriteLine("Su tarifa es la A");
                Console.WriteLine("El valor a pagar por su consulta es 3.400 pesos colombianos");
            }
            else if (2 <= smmvl && smmvl < 4)
            {
                Console.WriteLine("Su tarifa es la B");
                Console.WriteLine("El valor a pagar por su consulta es 13.500 pesos colombianos");
            }
            else
            {
                Console.WriteLine("Su tarifa es la C");
                Console.WriteLine("El valor a pagar por su consulta es 35.600 pesos colombianos");
            }
        }
    }
}
