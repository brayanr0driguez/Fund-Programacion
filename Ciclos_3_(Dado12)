using System;

namespace Ciclos_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randm = new Random();
            int dado, total = 0, turno = 0, dadoAnterior;
            string seguir = "s";

            while (total < 100 && seguir == "s")
            {
                dado = randm.Next(1, 13);
                Console.WriteLine("\nDado: " + dado);

                dadoAnterior = dado;

                total += dado;
                Console.WriteLine("\nTotal: " + total);

                turno += 1;

                if ((dado == 1 || dado == 3 || dado == 5 || dado == 7 || dado == 9 || dado == 11) && turno > 3)
                {
                    Console.WriteLine("\nHaz perdido!");
                    seguir = "n";
                }
                else if (total >= 100)
                {
                    Console.WriteLine("\nHaz ganado!!");
                    seguir = "n";
                }
                else if (dadoAnterior == 12 && dado == 10)
                {
                    Console.WriteLine("\nHaz ganado!!");
                    seguir = "n";
                }
                else
                {
                    Console.WriteLine("Desea continuar? (s/n)");
                    seguir = Console.ReadLine();
                }
            }
            Console.WriteLine("\nTu total fue: " + total);
            Console.WriteLine("Gracias por participar!");
        }
    }
}
