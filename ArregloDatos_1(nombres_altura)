using System;
using System.Globalization;

namespace ArregloDatos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Tanjiro", "Nezuko", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] altura = { 165, 153, 164.5, 164, 180, 156, 176 };
            double total = altura[0] + altura[1] + altura[2] + altura[3] + altura[4] + altura[5] + altura[6];
            double promedio = total / 7;
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("");
            //Distancia
            double[] distancia = new double[7];
            for (int i = 0; i < altura.Length; i++) {
                distancia[i] = Math.Abs(altura[i] - promedio);
                Console.WriteLine("Distancia de {0} es: {1}", nombres[i], distancia[i]);
            }
            //Ordenamiento de datos
            for (int j = 0; j < altura.Length; j++) {
                for (int k = 0; k < altura.Length - 1; k++) {
                    if (altura[k] > altura[k + 1]) {
                        //alturas
                        double tmp = altura[k];
                        altura[k] = altura[k + 1];
                        altura[k + 1] = tmp;
                        //nombres
                        string temp = nombres[k];
                        nombres[k] = nombres[k + 1];
                        nombres[k + 1] = temp; 
                    }
                }
            }
            Console.WriteLine("");
            for (int x = 0; x < nombres.Length; x++) {
                Console.WriteLine("{0}: {1}", nombres[x], altura[x]);
            }
        }
    }
}
