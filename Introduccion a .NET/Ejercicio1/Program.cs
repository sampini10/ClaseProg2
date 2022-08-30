using System;
using System.Linq;

/*Ingresar 5 números por consola, guardándolos en una variable escalar.
 * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/
namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroString;
            float numeroIngresado;
            bool result;
            float numeroMaximo = float.MinValue;
            float numeroMinimo = float.MaxValue;
            float numerosPromedio = 0;

            Console.WriteLine("Ingrese 5 numeros");

            for (int i = 0; i < 5; i++)
            {
                numeroString = Console.ReadLine();
                result = float.TryParse(numeroString, out numeroIngresado);
                if (result)
                {
                    Console.WriteLine("Numero Guardado");
                    if (numeroIngresado > numeroMaximo)
                    {
                        numeroMaximo = numeroIngresado;
                    }
                    if (numeroIngresado < numeroMinimo)
                    {
                        numeroMinimo = numeroIngresado;
                    }
                    numerosPromedio += numeroIngresado;
                }
                else
                {
                    Console.WriteLine("No se guardo, ingreso incorrectamente");
                }
            }
            numerosPromedio = numerosPromedio / 5;
            Console.WriteLine($"El numero maximo es: {numeroMaximo}");
            Console.WriteLine($"El numero minimo es: {numeroMinimo}");
            Console.WriteLine($"El promedio es: {numerosPromedio}");

            //int[] numeros = new int[5];

            //Console.WriteLine("Ingrese 5 numeros: ");
            //for(int i = 0; i < numeros.Length; i++ )
            //{
            //    string numeroString = Console.ReadLine();
            //    if(int.TryParse(numeroString, out numeros[i]))
            //    {
            //        Console.WriteLine("Guardado");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error de numero");
            //    }
            //}
            //Console.WriteLine($"El numero Maximo es: {numeros.Max()}");
            //Console.WriteLine($"El numero Minimo es: {numeros.Min()}");
            //Console.WriteLine($"El promedio es: {numeros.Average()}");
        }
    }
}
