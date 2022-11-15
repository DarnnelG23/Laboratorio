using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_3_Darnnel Gonzalez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tipo de helado entre: chocolate, vainilla, napolitano, pistacho o fresa.");
            string tipoHelado = Console.ReadLine();
            double precio = 0;
            int topping;

            if (tipoHelado == "chocolate" || tipoHelado == "vainilla" || tipoHelado == "fresa")
            {
                precio = 5;
            }
            else if (tipoHelado == "napolitano" || tipoHelado == "pistacho")
            {
                precio = 7;
            }

            Console.WriteLine("Introduce el topping que desea entre: cobertura de chocolate, cobertura de chocolate con mania, cobertura de chocolate con anicillos.");
            topping = int.Parse(Console.ReadLine());
            switch (topping)
            {

                case 1: // cobertura de chocolate
                    precio = precio + 1;
                    break;
                case 2: // cobertura de chocolate con mania
                    precio = precio + 2;
                    break;
                case 3: // cobertura de chocolate con anicillos
                    precio = precio + 1;
                    break;
            }
            Console.WriteLine("El precio a pagar se de:" + precio);
            Console.ReadKey();
        }
    }
}