using System;
using System.Transactions;

namespace ej_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 02-01 conozco y, z
            Console.WriteLine("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese z: ");
            double z = double.Parse(Console.ReadLine());

            //para calcular "a" a partir de la tangente del angulo
            double aRad = Math.Atan(y / z);
            double aDregress = aRad * 180 / Math.PI;
            Console.WriteLine("a: " + aDregress);

            //lo de arriba pero con "c"
            double cRad = Math.Atan(z / y);
            double cDegress = cRad * 180 / Math.PI;
            Console.WriteLine("c: " + cDegress);

            //calcular hipotenusa
            double ySq = y * y;
            double zSq = z * z;
            double hipo = Math.Sqrt(ySq + zSq);
            Console.WriteLine("t: " + hipo);

            Console.WriteLine("-------------------------------------------------------");

            //ejercicio 02-02 conozco t, a
            Console.WriteLine("Ingrese t: ");
            double t2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese a: ");
            double a2 = double.Parse(Console.ReadLine());

            double a2Rad = a2 * Math.PI / 180;

            //encontrar z, y, a partir del seno y coseno de "a"
            double y2 = Math.Sin(a2Rad) * t2;
            Console.WriteLine("y: " + y2);

            double z2 = Math.Cos(a2Rad) * t2;
            Console.WriteLine("z:" + z2);

            //encontrar c en grados
            double cRad2 = Math.Asin(z2 / t2);
            double c2 = cRad2 * 180 / Math.PI;
            Console.WriteLine("c: " + c2);

            Console.WriteLine("-------------------------------------------------------6");

            //ejercicio 02-03
            //pedir datos c,z
            Console.WriteLine("Ingrese c: ");
            double cDegress3 = double.Parse(Console.ReadLine());
            double c3 = cDegress3 * Math.PI / 180;

            Console.WriteLine("Ingrese z: ");
            double z3 = double.Parse(Console.ReadLine());

            //encontrar los otros datos
            double t3 = Math.Sin(Math.PI / 2) * z3 / Math.Sin(c3);
            double y3 = Math.Cos(c3) * t3;
            double a3 = Math.Asin(y3 / t3);
            double a3Degress = a3 * 180 / Math.PI;

            //print
            Console.WriteLine("t: " + t3);
            Console.WriteLine("y: " + y3);
            Console.WriteLine("a: " + a3Degress);
        }
    }
}
