using System;

namespace Ciclos_5_Casa_vida2turnos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randm = new Random();
            int dado1, dado2, total = 0, vidas = 3, turnoDado = 0, turnoVida = 0;
            string seguir = "s";

            while ((total < 100) && (seguir == "s"))
            {
                //turnos
                turnoDado += 1;
                turnoVida += 1;
                //dos dados si turno 3 y vida más uno si dobles
                if (turnoDado == 3)
                {
                    turnoDado = 0;

                    dado1 = 3;
                    dado2 = 3;
                    Console.WriteLine("\nDado 1: " + dado1);
                    Console.WriteLine("Dado 2: " + dado2);
                    total += dado1 + dado2;
                    if (dado1 == dado2)
                    {
                        vidas += 1;
                        Console.WriteLine("\nSe te ha sumado 1 vida!");
                        Console.WriteLine("Te quedan " + vidas + " vidas!");
                    }
                }
                else
                {
                    dado1 = randm.Next(1, 7);
                    Console.WriteLine("\nDado: " + dado1);
                    total += dado1;
                }
                //perder vida
                if (turnoVida == 2)
                {
                    turnoVida = 0;
                    vidas -= 1;
                    Console.WriteLine("\nSe te ha quitado 1 vida!");
                    Console.WriteLine("Te quedan " + vidas + " vidas!");
                    if (vidas == 0)
                    {
                        Console.WriteLine("\nHaz perdido!");
                        break;
                    }
                }
                //total
                Console.WriteLine("\nTotal: " + total);
                //ganar
                if (total > 99)
                {
                    Console.WriteLine("\nHaz ganado!");
                    break;
                }
                //continuar jugando
                else
                {
                    Console.WriteLine("\nDesea continuar? (s/n)");
                    seguir = Console.ReadLine();
                    if (seguir == "n") break; 
                }
            }
            Console.WriteLine("\nSu total fue: " + total);
            Console.WriteLine("Gracias por jugar!");
        }
    }
}
