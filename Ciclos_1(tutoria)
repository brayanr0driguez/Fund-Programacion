using System;

namespace Ciclos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.Write("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 0;
            string nombreMax = "", nombreMin = "";
            
            while(i < n)
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su nombre: ");
                string nombre = Console.ReadLine();

                if(i == 0)
                {
                    max = edad;
                    min = edad;
                    nombreMax = nombre;
                    nombreMin = nombre;
                }
                if (edad > max)
                {
                    max = edad;
                    nombreMax = nombre;
                }
                if (edad < min)
                {
                    min = edad;
                    nombreMin = nombre;
                }
                total += edad;
                i++;
            }
            double promedio = total / n;
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("Mayor: " + max);
            Console.WriteLine("Nombre Mayor: " + nombreMax);
            Console.WriteLine("Menor: " + min);
            Console.WriteLine("Nombre Menor: " + nombreMin);
        }
    }
}
