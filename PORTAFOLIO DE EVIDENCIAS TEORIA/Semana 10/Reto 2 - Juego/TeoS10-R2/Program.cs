using System;
using Internal;

namespace Reto2_Grupo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int numAleatorio = r.Next(1, 101);
            int dato;

            do
            {
                Console.WriteLine("Ingrese un número:  ");
                dato = Convert.ToInt32(Console.ReadLine());

                if (dato > numAleatorio)
                {
                    Console.WriteLine("El numero que ingreso es mayor a " + dato);
                }
                if (dato < numAleatorio)
                {
                    Console.WriteLine("El numero que ingreso es menor a  " + dato);
                }

            }
            while (dato != numAleatorio);

            if (dato == numAleatorio)
            {
                Console.WriteLine("Felicidades, adivinaste el numero");
            }
            Console.ReadKey();
        }
    }
}