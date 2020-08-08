using System;

namespace Ciclo_6__Captcha_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randm = new Random();
            int turno = 0, a, b;
            
            while (turno < 3)
            {
                //numeros random nuevos al inicio de cada turno
                a = randm.Next(1, 11);
                b = randm.Next(1, 11);
                int sumaCorrecta = a + b;

                Console.WriteLine("\nCuanto es " + a + " + " + b + "?");

                //si la suma no es correcta
                if (int.Parse(Console.ReadLine()) != sumaCorrecta)
                {
                    turno += 1;
                    if (turno == 3) Console.WriteLine("\nNo puede intentar más");
                    else Console.WriteLine("Error! Intente de nuevo");
                }
                else Console.WriteLine("\nCorrecto! Puede continuar"); break;
            }
        }
    }
}
