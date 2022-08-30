using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
            El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
            El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
            Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.*/
            int numeroIngresado;
            int sumaAntesCentro = 0;
            int numero = 1;
            int sumaDespuesCentro = 1;

            Console.WriteLine("Ingrese numero");
            string numeroString = Console.ReadLine();

            do
            {
                if (Int32.TryParse(numeroString, out numeroIngresado))
                {
                    for (int i = 1; i < numero; i++)
                    {
                        sumaAntesCentro += i;
                    }
                    for (int j = numero + 1; j < numero * 2; j++)
                    {
                        if (sumaAntesCentro == sumaDespuesCentro)
                        {
                            Console.WriteLine($"Centro {numero}");
                            break;
                        }
                        else
                        {
                            sumaDespuesCentro += j;
                        }
                    }
                }
                numero++;
                sumaDespuesCentro = 0;
                sumaAntesCentro = 0;
            } while (numeroIngresado > numero);
        }
    }
}
