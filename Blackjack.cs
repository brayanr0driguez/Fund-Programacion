using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randm = new Random();
            int cartas, total = 0;
            string seguir = "s";

            cartas = randm.Next(1, 10);
            total += cartas;
            Console.WriteLine("Valor de carta: " + cartas);

            while (total < 22 && seguir == "s"){
                cartas = randm.Next(1, 10);
                total += cartas;
                Console.WriteLine("Valor de carta: " + cartas);
                Console.WriteLine("Total: " + total);

                if(total > 21){
                    Console.WriteLine("Haz sido eliminado!");
                }

                else{
                    Console.WriteLine("Desea continuar? (s/n)");
                    seguir = Console.ReadLine();
                }
            }
            Console.WriteLine("Su total es: " + total);
            Console.WriteLine("Gracias por participar!");
        }
    }
}
