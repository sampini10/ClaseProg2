using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número y mostrar el cuadrado y el cubo del mismo.
             * Se debe validar que el número sea mayor que cero, caso contrario, 
             * mostrar el mensaje: "ERROR. ¡Reingresar número!".*/

            Console.WriteLine("Ingrese el numero");
            string n = Console.ReadLine();
            double numero;
            double cubo;
            double cuadrado;
            bool result = double.TryParse(n, out numero);

            while(!result || numero < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                n = Console.ReadLine();
                result = double.TryParse(n, out numero);
            }
            cubo = Math.Pow(numero, 3);
            cuadrado = Math.Pow(numero, 2);
            Console.WriteLine($"El cuadrado de {numero} es {cuadrado}");
            Console.WriteLine($"El cubo de {numero} es {cubo}");
        }
    }
}
