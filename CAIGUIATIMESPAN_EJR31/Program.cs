using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIATIMESPAN_EJR31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite un ingreso al usuario y determine si puede interpretarse como un intervalo de tiempo.

            do
            {
                Console.Write("Ingrese un intervalo de tiempo: ");
                string ingreso = Console.ReadLine();

                if (!TimeSpan.TryParse(ingreso, out TimeSpan salida))
                {
                    Console.WriteLine("No puede interpretarse como un intervalo de tiempo.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Usted ingreso: | Días: {salida.Days}|" +
                        $" Horas: {salida.Hours}| Minutos: {salida.Minutes}| Segundos: {salida.Seconds}");
                    break;
                }

            } while (true);

            Console.ReadKey();

        }
    }
}
