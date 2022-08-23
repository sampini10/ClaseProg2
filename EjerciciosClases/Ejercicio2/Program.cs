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
            string numeroString = Console.ReadLine();
            double numeroIngresado;
            double numeroAlCubo;
            double numeroAlCuadrado;
            bool result = double.TryParse(numeroString, out numeroIngresado);

            while(!result || numeroIngresado < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numeroString = Console.ReadLine();
                result = double.TryParse(numeroString, out numeroIngresado);
            }
            numeroAlCubo = Math.Pow(numeroIngresado, 3);
            numeroAlCuadrado = Math.Pow(numeroIngresado, 2);
            Console.WriteLine($"El cuadrado de {numeroIngresado} es {numeroAlCuadrado}");
            Console.WriteLine($"El cubo de {numeroIngresado} es {numeroAlCubo}");
        }
    }
}
