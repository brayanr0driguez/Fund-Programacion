using System;

namespace ej_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese a, b, c, uno por uno: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double discrm = (b * b) - (4 * a * c);

            if (discrm == 0)
            {
                double rspUnica = (-1 * b) / (2 * a);
                Console.WriteLine("x: " + rspUnica);
            }
            else if (discrm > 0)
            {
                double x1 = ((-1 * b) + Math.Sqrt(discrm)) / (2 * a);
                double x2 = ((-1 * b) - Math.Sqrt(discrm)) / (2 * a);

                Console.WriteLine("x1: " + x1);
                Console.WriteLine("x2: " + x2);
            }
            else
            {
                Console.WriteLine("no es posible solucionar este problema");
            }
        }
    }
}
