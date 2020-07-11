using System;

namespace ej_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un número binario con 5 digitos");
            int b4 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b0 = int.Parse(Console.ReadLine());

            int b4x = b4 * 16;
            int b3x = b3 * 8;
            int b2x = b2 * 4;
            int b1x = b1 * 2;
            int b0x = b0 * 1;

            int dNumber = b4x + b3x + b2x + b1x + b0x;

            Console.WriteLine("número decimal: " + dNumber); 

        }
    }
}
