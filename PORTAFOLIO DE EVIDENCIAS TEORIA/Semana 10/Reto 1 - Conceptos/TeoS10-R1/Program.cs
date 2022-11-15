using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETO_1_Darnnel Gonzalez
{
    internal class Program
    {
        String mifuncion(int dato1, int dato2, int dato3)
        {
            if ((dato1 > 0) && (dato2 > 0) && (dato3 > 0))
            {
                double promedio, suma, multiplicatoria, elevado, mediageometrica;
                suma = (dato1 + dato2 + dato3);
                multiplicatoria = dato1 * dato2 * dato3;
                elevado = Math.Pow(dato1, dato2);
                promedio = suma / 3;
                mediageometrica = Math.Pow(multiplicatoria, 1 / 3);
                Console.WriteLine("La suma es " + suma.ToString());
                Console.WriteLine("La media es " + promedio.ToString());
                Console.WriteLine("La multiplicatoria es " + multiplicatoria.ToString());
                Console.WriteLine("La media geometrica es " + mediageometrica.ToString());
                Console.WriteLine(dato1.ToString() + " ^ " + dato2.ToString() + " = " + elevado.ToString());
                return "Se hicieron todos los cálculos correctamente";
            }
            else
                return "Debe ingresar valores mayores a 0";

        }
        static void Main(string[] args)
        {
            Console.WriteLine(mifuncion(2, 4, 6));
            Console.ReadKey();
        }
    }
}