using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Ingrese X1: ");
			double x1 = double.Parse(Console.ReadLine());

			Console.Write("Ingrese Y1: ");
			double y1 = double.Parse(Console.ReadLine());

			Console.Write("Ingrese X2: ");
			double x2 = double.Parse(Console.ReadLine());

			Console.Write("Ingrese Y2: ");
			double y2 = double.Parse(Console.ReadLine());

			double x3 = x2 - x1;
			double y3 = y2 - y1;

			double m = y3 / x3;
			Console.WriteLine("Pendiente: " + m);

			double b = y1 - (m * x1);
			Console.WriteLine("Intercepto: " + b);

			double xx = x3 * x3;
			double yy = y3 * y3;

			double d = Math.Sqrt(xx + yy);
			Console.WriteLine("Distancia: " + d);
		}
	}
}
