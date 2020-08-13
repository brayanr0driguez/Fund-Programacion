using System;

namespace Ciclos_7__Blackjack_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randm = new Random();
            int carta, total = 0, jugadores, contador = 1, max = 0;
            string seguir = "s", nombre = " ", nombreMax = " ";

            Console.WriteLine("Ingrese el número de jugadores: (minimo 2, maximo 5)");
            jugadores = int.Parse(Console.ReadLine());
            //VALIDACION NUMERO DE JUGADORES
            while (jugadores < 2 || 5 < jugadores) {
                Console.WriteLine("Número de jugadores incorrecto, intente de nuevo: ");
                jugadores = int.Parse(Console.ReadLine());
            }
            //INICIO JUEGO
            while (contador <= jugadores) {
                Console.WriteLine("\nJUGADOR {0}", contador);
                Console.WriteLine("Ingrese su nombre: ");
                nombre = (Console.ReadLine()).ToUpper();
                carta = randm.Next(1, 11);
                total += carta;
                Console.WriteLine("\nCarta: {0}", carta);
                //WHILE DE CADA JUGADOR
                while (total < 22 && seguir == "s") {
                    carta = randm.Next(1, 11);
                    total += carta;
                    Console.Write("Carta: {0}", carta);
                    Console.Write("  |  Total: {0}", total);
                                     
                    if (total > 21) {
                        Console.Write("\nHaz sido eliminado!");
                        Console.Write("  Su total fue: {0}", total);
                        total = 0;
                        break;
                    }
                    else {
                        Console.Write("  |  Desea seguir jugando? (s/n)");
                        if (total < 22 && (max < total)){
                            max = total;
                            nombreMax = nombre;
                        }
                        if (Console.ReadLine() != "s"){
                            total = 0;
                            break;
                        }
                    }
                }
                contador++;
            }
            Console.WriteLine("\nEL GANADOR ES {0}!! GRACIAS POR JUGAR!!", nombreMax);
        }
    }
}
