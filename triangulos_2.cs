using System;
using System.Security.Cryptography.X509Certificates;

namespace ej_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //punto 1

            Console.WriteLine("ingrese b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese z");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese y");
            double y = double.Parse(Console.ReadLine());
            
            double t = Math.Sqrt(z * z + y * y);

            double aRad = Math.Asin(y * Math.Sin(Math.PI / 2) / t);
            double aDeg = aRad * 180 / Math.PI;

            double c = 180 - aDeg - 90;
            double e = 180 - c;
            double d = 180 - e - b;

            double xRad = t * Math.Sin(b * Math.PI / 180) / Math.Sin(d * Math.PI / 180);

            Console.WriteLine("x es igual a: " + xRad);
            Console.WriteLine("------------------------------------------------------------------------");

            //punto 2

            Console.WriteLine("ingrese d");
            double d2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese b");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese y");
            double y2 = double.Parse(Console.ReadLine());

            double a2 = 180 - b2 - d2 - 90;
            double c2 = 180 - a2 - 90;

            double z2 = y2 * Math.Sin(c2 * Math.PI / 180) / Math.Sin(a2 * Math.PI / 180);
            Console.WriteLine("z es igual a: " + z2);

            //punto 3
            Console.WriteLine("ingrese w");
            double w3 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese d");
            double d3 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese x");
            double x3 = double.Parse(Console.ReadLine());

            double ab = 180 - d3 - 90;
            double xy = w3 * Math.Sin(ab * Math.PI / 180) / Math.Sin(Math.PI / 2);

            double y3 = xy - 2;
            Console.WriteLine("y es igual a: " + y3);


            //punto 4

            Console.WriteLine("ingrese w");
            double w4 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese t");
            double t4 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese c");
            double c4 = double.Parse(Console.ReadLine());

            double e4 = 180 - c4;
            double d4 = (Math.Asin(t4 * Math.Sin(e4 * Math.PI / 180) / w4)) * 180 / Math.PI;

            double b4 = 180 - d4 - e4;

            double x4 = Math.Sin(b4 * Math.PI / 180) * w4 / Math.Sin(e4 * Math.PI / 180); 

            Console.WriteLine("x es igual a: " + x4);
        }
    }
}
