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
            string n;
            float num;
            bool result;
            float max = float.MinValue;
            float min = float.MaxValue;
            float Promedio = 0;

            Console.WriteLine("Ingrese 5 numeros");

            for (int i = 0; i < 5; i++)
            {
                n = Console.ReadLine();
                result = float.TryParse(n, out num);
                if (result)
                {
                    Console.WriteLine("Numero Guardado");
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                    Promedio += num;
                }
                else
                {
                    Console.WriteLine("No se guardo, ingreso incorrectamente");
                }
            }
            Promedio = Promedio / 5;
            Console.WriteLine($"El numero maximo es: {max}");
            Console.WriteLine($"El numero minimo es: {min}");
            Console.WriteLine($"El promedio es: {Promedio}");

            //int[] numeros = new int[5];

            //Console.WriteLine("Ingrese 5 numeros: ");
            //for(int i = 0; i < numeros.Length; i++ )
            //{
            //    string n = Console.ReadLine();
            //    if(int.TryParse(n, out numeros[i]))
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
