using System;

namespace Ciclos_4_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randm = new Random();
            int dado = 0, turno = 0, total = 0, vidas = 3, veces1 = 0, veces6 = 2, dadosEspeciales = 2, dadoEsp = 0; 
            string seguir = "s", usarDado = "n";
            
            while ((total < 100) && (seguir == "s"))
            {
                if (dadosEspeciales > 0) {
                    Console.WriteLine("\nTe quedan " + dadosEspeciales + " dados especiales!");
                    Console.WriteLine("Quieres usar un dado especial? (s/n)");
                    usarDado = Console.ReadLine();
                    if (usarDado == "s") dadosEspeciales -= 1;               
                }
                turno += 1;
                //dado especial
                if(usarDado == "s") {
                    dadoEsp = randm.Next(1, 13);
                    Console.WriteLine("Dado Especial: " + dadoEsp);
                    total += dadoEsp;
                    if (dadosEspeciales == 0) usarDado = "n";
                }
                else {
                    dado = randm.Next(1, 7);
                    Console.WriteLine("\nDado: " + dado);
                    total += dado;
                }
                //total
                Console.WriteLine("\nTotal: " + total); 
                //ganar
                if (total > 99) {
                    Console.WriteLine("\nHaz ganado!");
                    break;
                }
                else {
                    //si sale 1 dos veces (no seguidas)
                    if ((dado == 1) || (dadoEsp == 1)) {
                        veces1 += 1;
                        if (veces1 == 2) {
                            vidas -= 1;
                            Console.WriteLine("\nPerdiste una vida!");
                            Console.WriteLine("Te quedan " + vidas + " vidas!");
                            veces1 = 0;
                            total -= 10;
                            Console.WriteLine("\nSe te han restado 10 puntos!");
                            Console.WriteLine("Tu nuevo total es: " + total);
                        }
                    }
                    //si sale 6 dos veces seguidas
                    if ((dado == 6) || (dadoEsp == 6)) {
                        veces6 += 1;
                        if (veces6 == 2) {
                            veces6 = 0;
                            if (vidas > 3) {
                                vidas += 1;
                                Console.WriteLine("\nTienes 1 vida más!");
                                Console.WriteLine("Te quedan " + vidas + " vidas!");
                            }
                        }
                    }
                    else veces6 = 0;                  
                    if (vidas == 0) {
                        Console.WriteLine("\nHaz perdido!");
                        break;
                    }
                    Console.WriteLine("\nQuieres continuar? (s/n)");
                    seguir = Console.ReadLine();
                    if (seguir == "n") break;                 
                }
            }
            Console.WriteLine("\nTu total fue " + total);
            Console.WriteLine("Gracias por jugar!");
        }
    }
}
