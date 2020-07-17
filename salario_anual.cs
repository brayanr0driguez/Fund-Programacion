using System;

namespace ej_9_eval
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables globales
            double deduccion1, deduccion2, salMen1, salMen2, salAnual1, salAnual2, riesgo;

            Console.WriteLine("ingrese su salario (sin puntos ni comas)");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su condición (escribiendo el número correspondiente)");
            Console.WriteLine("dependiente (1)  ||  independiente (2)");
            int dependencia = int.Parse(Console.ReadLine());

            double sal40 = salario * 0.40;
            int salMin = 877803;

            if (dependencia == 1)
            {
                if (sal40 < salMin)
                {
                    deduccion1 = ((salMin * 0.04) * 2);
                    
                }
                else
                {
                    deduccion1 = ((sal40 * 0.04) * 2);
                }

                Console.WriteLine("deducción mensual: " + deduccion1);
                salMen1 = salario - deduccion1;
                Console.WriteLine("salario real mensual: " + salMen1);
                salAnual1 = (salMen1 * 12) + salario;
                Console.WriteLine("salario anual: " + salAnual1);
            }
            else if (dependencia != 1 && dependencia != 2)
            {
                Console.WriteLine("entrada incorrecta");
            }
            else
            {
                Console.WriteLine("cual es su clase de riesgo? (escriba el número correspondiente)");
                Console.WriteLine("| 1 | 2 | 3 | 4 | 5 |");
                double nRiesgo = double.Parse(Console.ReadLine());
                riesgo = 0;
                if (nRiesgo == 1)
                {
                    riesgo = 0.00522;
                }
                else if (nRiesgo == 2)
                {
                    riesgo = 0.01044;
                }
                else if (nRiesgo == 3)
                {
                    riesgo = 0.02436;
                }
                else if (nRiesgo == 4)
                {
                    riesgo = 0.04350;
                }
                else if (nRiesgo == 5)
                {
                    riesgo = 0.06960;
                }
                else
                {
                    Console.WriteLine("entrada incorrecta");
                }

                if (sal40 < salMin)
                {
                    deduccion2 = (salMin * 0.16) + (salMin * 0.125) + (salMin * riesgo);

                }
                else
                {
                    deduccion2 = (sal40 * 0.16) + (sal40 * 0.125) + (sal40 * riesgo);
                }

                Console.WriteLine("deducción mensual: " + deduccion2);
                salMen2 = salario - deduccion2;
                Console.WriteLine("salario real mensual: " + salMen2);
                salAnual2 = salMen2 * 12;
                Console.WriteLine("salario anual: " + salAnual2);
            }
        }
    }
}
