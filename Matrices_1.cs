using System;

namespace Matrices_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "X", "O" };
            int n = 10;
            int m = 15;
            //variables para el ejercicio 2
            int x = 0, o = 0, guion = 0, total = 0;
            double xPercent, oPercent, guionPercent;

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];
            for(int i = 0; i < tablero.GetLength(0); i++) { 
                for(int j = 0; j < tablero.GetLength(1); j++) {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }

            Console.WriteLine("ENTRADA: ");
            for(int i = 0; i < tablero.GetLength(0); i++) { 
                for(int j = 0; j < tablero.GetLength(1); j++) {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.Write("|\n");
            }
            ///////////////////////////////////////////////////////
            //PORCENTAJES
            for(int i = 0; i < tablero.GetLength(0); i++) {
                for (int j = 0; j < tablero.GetLength(1); j++) {
                    if (tablero[i, j] == "X") x++;
                    if (tablero[i, j] == "O") o++;
                    if (tablero[i, j] == "-") guion++;
                }
            }
            total = guion + x + o;
            xPercent = x * 100 / total;
            oPercent = o * 100 / total;
            guionPercent = guion * 100 / total;
            Console.WriteLine("\nPorcentaje de X: {0}% \nPorcentaje de O: {1}% \nPorcentaje de -: {2}%", xPercent, oPercent, guionPercent);
            ///////////////////////////////////////////////////////
            //FILAS
            for (int i = 0; i < tablero.GetLength(0); i++) { 
                for(int j = 0; j < tablero.GetLength(1) - 2; j++) {
                    bool A1 = tablero[i, j] == tablero[i, j + 1];
                    bool A2 = tablero[i, j] == tablero[i, j + 2];
                    if (tablero[i, j] == "X") {
                       if(A1 && A2) {
                            salida[i, j] = "1";
                            salida[i, j + 1] = "1";
                            salida[i, j + 2] = "1";
                        }
                    }
                    if (tablero[i, j] == "O") {
                        if (A1 && A2) {
                            salida[i, j] = "2";
                            salida[i, j + 1] = "2";
                            salida[i, j + 2] = "2";
                        }
                    }
                }
            }
            //COLUMNAS
            for (int i = 0; i < tablero.GetLength(0) - 2; i++) {
                for (int j = 0; j < tablero.GetLength(1); j++) {
                    bool A1 = tablero[i, j] == tablero[i + 1, j];
                    bool A2 = tablero[i, j] == tablero[i + 2, j];
                    if (tablero[i, j] == "X") {
                        if (A1 && A2) {
                            salida[i, j] = "1";
                            salida[i + 1, j] = "1";
                            salida[i + 2, j] = "1";
                        }
                    }
                    if (tablero[i, j] == "O") {
                        if (A1 && A2) {
                            salida[i, j] = "2";
                            salida[i + 1, j] = "2";
                            salida[i + 2, j] = "2";
                        }
                    }
                }
            }

            ///////////////////////////////////////////////////////
            Console.WriteLine("\nSALIDA: ");
            for (int i = 0; i < tablero.GetLength(0); i++) {
                for (int j = 0; j < tablero.GetLength(1); j++) {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }
            Console.Write("\n");
        }
    }
}
