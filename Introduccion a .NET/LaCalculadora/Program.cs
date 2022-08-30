using System;

namespace LaCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroString;
            string numeroString2;
            double numero1;
            double numero2;
            string operacion;
            double result;
            string respuesta;

            do
            {
                Console.WriteLine("Ingrese el primer numero");
                numeroString = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo numero");
                numeroString2 = Console.ReadLine();
                Console.WriteLine("Ingrese la operacion a realizar (+,-,/,*)");
                operacion = Console.ReadLine();

                if (double.TryParse(numeroString, out numero1) && double.TryParse(numeroString2, out numero2))
                {
                    result = Calculadora.Calcular(numero1, numero2, operacion);
                    Console.WriteLine($"El resultado es:{result}");
                    Console.WriteLine("Desea continuar?");
                    respuesta = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("Ingreso un numero no valido");
                    respuesta = "s";
                }

            } while (respuesta == "s");

        }
    }
}
