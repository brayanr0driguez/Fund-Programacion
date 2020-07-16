using System.ComponentModel.DataAnnotations;

using System;

namespace ej_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su peso en kg:");
            double kg = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese su altura en metros:");
            double m = double.Parse(Console.ReadLine());
            double m2 = m * m;

            double imc = kg / m2;
            Console.WriteLine("su indice de masa corporal es: " + imc);

            if (imc <= 18.5) {
                Console.WriteLine("usted está bajo de peso!");
            }
            else if (18.6 <= imc && imc <= 24.9) {
                Console.WriteLine("su peso está normal!");
            }
            else if (25 <= imc && imc <= 29.9) {
                Console.WriteLine("usted tiene sobrepeso!");
            }
            else {
                Console.WriteLine("usted tiene obesidad!!");
            }
        }
    }
}
