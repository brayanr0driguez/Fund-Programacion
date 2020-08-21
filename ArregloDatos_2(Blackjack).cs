using System;

namespace ArregloDatos_2_Blackjack_
{
    class Program
    {
        static void Main(string[] args) {
            Random random = new Random();
            int carta, total = 0, j;
            string seguir = "s";
            Console.WriteLine("Ingrese número de jugadores: (2 a 5)");
            j = int.Parse(Console.ReadLine());
            //VALIDACION
            while (j < 2 || 5 < j){
                Console.WriteLine("Número de jugadores incorrecto, intente de nuevo: ");
                j = int.Parse(Console.ReadLine());
            }
            string[] name = new string[j];
            int[] puntaje = new int [j];
            //INICIO JUEGO           
            for (int i = 0; i < j; i++) {
                Console.WriteLine("\nJUGADOR " + (i + 1));
                Console.WriteLine("Ingrese su nombre: ");
                name[i] = Console.ReadLine().ToUpper();
                carta = random.Next(1, 11);
                total += carta;
                Console.Write("Carta: {0}  |  ", carta);
                //PEDIR MÁS CARTAS
                while (total < 22 && seguir == "s") {
                    carta = random.Next(1, 11);
                    total += carta;
                    Console.Write("Carta: {0}  |  Total: {1}", carta, total);
                    if (21 < total) { 
                        Console.WriteLine("\nHaz sido eliminado!  |  Su total fue: " + total);
                        puntaje[i] = 0; //ASI SI PIERDEN SE BORRA EL PUNTAJE GUARDADO
                        break;
                    }
                    else {
                        puntaje[i] = total;
                        Console.Write("  |  Desea continuar? (s/n)");
                        if (Console.ReadLine() != "s") {
                            total = 0;
                            break;
                        }
                    }
                }
            } 
            //ORDENAMIENTO DATOS
            for (int k = 0; k < puntaje.Length; k++) {
                for (int l = 0; l < puntaje.Length - 1; l++) {
                    if (puntaje[l] < puntaje[l + 1]) {       
                        int tmp1 = puntaje[l]; 
                        //PUNTAJE
                        puntaje[l] = puntaje[l + 1];
                        puntaje[l + 1] = tmp1;    
                        string tmp2 = name[l]; 
                        //NOMBRES
                        name[l] = name[l + 1];
                        name[l + 1] = tmp2;
                    }
                }
            } 
            //SE TOMAN LOS ULTIMOS DOS VALORES DEL ARREGLO YA QUE SIEMPRE SERAN LOS MAYORES
            Console.WriteLine("\nEL PRIMER LUGAR ES {0} CON {1} PUNTOS!!", name[0], puntaje[0]);
            Console.WriteLine("\nEL SEGUNDO LUGAR ES {0} CON {1} PUNTOS!", name[1], puntaje[1]);
            Console.WriteLine("\nGRACIAS POR JUGAR!");

            //SI SE QUIERE UNA TABLA DE TODOS
            Console.WriteLine("");
            Console.WriteLine("PUNTAJES!");
            for (int m = 0; m < j; m++) {
                Console.WriteLine("{0}: {1}", name[m], puntaje[m]);
            }
        }
    }
}

