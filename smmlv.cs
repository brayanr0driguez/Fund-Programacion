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
            }
            else if (2 <= smmvl && smmvl < 4)
            {
                Console.WriteLine("Su tarifa es la B");
            }
            else
            {
                Console.WriteLine("Su tarifa es la C");
            }
        }
    }
}
