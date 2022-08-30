using System;

namespace DeseaContinuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroString;
            int numeroIngresado;
            int sumaNumeros = 0;
            string respuesta = "";

            do
            {
                Console.WriteLine("Ingrese el numero");
                numeroString = Console.ReadLine();

                if (int.TryParse(numeroString, out numeroIngresado))
                {
                    sumaNumeros += numeroIngresado;
                    Console.WriteLine($"La suma es {sumaNumeros}");
                    Console.WriteLine("¿Desea continuar? (S/N)");
                    respuesta = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("Ingreso invalido. Ingrese nuevamente");
                    respuesta = "";
                }

            } while (Validador.ValidarRespuesta(respuesta));
            Console.WriteLine("Saliendo....");
        }
    }
}
