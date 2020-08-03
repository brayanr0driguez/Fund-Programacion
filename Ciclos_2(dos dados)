using System;

namespace Ciclos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randm = new Random();
            int dado1, dado2, total = 0, totalDobles = 0, dados6, turnoMas6 = 0, turno = 0;
            double porcentajeMas6;
            string seguir = "s";

            while (total < 100 && seguir == "s")
            {
                dado1 = randm.Next(1, 7);
                dado2 = randm.Next(1, 7);
                Console.WriteLine("dado 1: " + dado1);
                Console.WriteLine("dado 2: " + dado2);
                turno += 1;
                total += dado2 + dado1;
                Console.WriteLine("\nSu total es: " + total);

                if (dado1 == 1 && dado2 == 1) {
                    Console.WriteLine("\nHaz sido eliminado!");
                    seguir = "n";
                }
                else if (total >= 100 || totalDobles == 3) {
                    Console.WriteLine("\nHaz ganado!");
                    seguir = "n";
                }
                else
                {
                    dados6 = dado1 + dado2;
                    if (dados6 > 6) turnoMas6 += 1;
                    if (dado1 == dado2) totalDobles += 1;
                    else totalDobles = 0;

                    if (totalDobles == 3) {
                        Console.WriteLine("\nHaz ganado!");
                        seguir = "n";
                    }
                    else {
                        Console.WriteLine("Desea continuar? (s/n)");
                        seguir = Console.ReadLine();
                    }                                 
                }           
            }
            porcentajeMas6 = ((double)turnoMas6 / turno) * 100;
            
            Console.WriteLine("\nPorcentaje de turnos +6: " + porcentajeMas6 + "%");
            Console.WriteLine("\nGracias por participar!");
        }
    }
}
