using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIATIMESPAN_EJR32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de dos fechas al usuario y determine el intervalo en días, meses y años.

            do
            {
                Console.WriteLine("Ingrese una fecha: ");
                string ingreso1 = Console.ReadLine();
                Console.WriteLine("Ingrese otra fecha: ");
                string ingreso2 = Console.ReadLine();
                if (!DateTime.TryParse(ingreso1, out DateTime salida1))
                {
                    Console.WriteLine("No ingreso una fecha correcta.");
                    continue;
                }

                if (!DateTime.TryParse(ingreso2, out DateTime salida2))
                {
                    Console.WriteLine("No ingreso una fecha correcta.");
                    continue;
                }
                else
                {

                    Console.WriteLine($"Ingreso 1 --> Día: {salida1.Day} - Mes: {salida1.Month} - Año {salida1.Year}");
                    Console.WriteLine($"Ingreso 2 --> Día: {salida2.Day} - Mes: {salida2.Month} - Año {salida2.Year}");

                    if (salida1 > salida2)
                    {
                        var diferenciadias = salida1.Day - salida2.Day;
                        var diferenciameses = salida1.Month - salida2.Month;
                        var diferenciaños = salida1.Year - salida2.Year;

                        Console.WriteLine($"Intervalo: {diferenciadias} | {diferenciameses} | {diferenciaños}");
                    }
                    else
                    {
                        var diferenciadias = salida2.Day - salida1.Day;
                        var diferenciameses = salida2.Month - salida1.Month;
                        var diferenciaños = salida2.Year - salida1.Year;

                        Console.WriteLine($"Intervalo: {diferenciadias} | {diferenciameses} | {diferenciaños}");
                    }           
               
                    break; 
                }

            } while (true);
            Console.ReadKey();
        }
    }
}
