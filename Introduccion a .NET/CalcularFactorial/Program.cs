using System;

namespace CalcularFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroString;
            int numeroIngresado;
            bool result;

            Console.WriteLine("Calculo del Factorial");
            do
            {
                Console.WriteLine("Ingrese numero positivo: ");
                numeroString = Console.ReadLine();
                if(int.TryParse(numeroString,out numeroIngresado) && numeroIngresado > 0)
                {
                    Factorial(numeroIngresado);
                    result = true;
                }
                else
                {
                    Console.WriteLine("No es un numero valido, tiene que ser positivo");
                    result = false;
                }
               

            } while (result == false);
   
    
        }
        static void Factorial(int numeroIngresado)
        {
            int fact = 1;
            for (int i = 1; i <= numeroIngresado; i++)
            {
                fact *= i;
            }
            Console.WriteLine("El Factorial de " + numeroIngresado + " es: " + fact);
        }
    }
}
    
