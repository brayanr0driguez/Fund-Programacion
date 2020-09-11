using System;

namespace Matrices_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = 10;
            int m = 15;

            //SE CREA EL TABLERO
            string[,] tablero = new string[n, m];
            for (int i = 0; i < tablero.GetLength(0); i++) {
                for (int j = 0; j < tablero.GetLength(1); j++) {
                    tablero[i, j] = "-";
                }
            }
            //SE REPITE UNA Y OTRA VEZ REEMPLAZAR LOS GUIONES
            while (true) {
                Console.WriteLine("TABLERO: ");
                for (int i = 0; i < tablero.GetLength(0); i++) {
                    for (int j = 0; j < tablero.GetLength(1); j++) {
                        Console.Write("|" + tablero[i, j]);
                    }
                    Console.Write("|\n");
                }
                Console.WriteLine("Introducir X en las coordenadas: ");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                while (true) {
                    if (tablero[x, y] != "-") {
                        Console.WriteLine("Esa celda ya está ocupada, intente otra");
                        Console.WriteLine("Introducir X en las coordenadas: ");
                        x = int.Parse(Console.ReadLine());
                        y = int.Parse(Console.ReadLine());
                    }
                    else break;
                }
                tablero[x, y] = "X";
            }
        }
    }
}
