using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cerrar la consola.
            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. 
            De lo contrario, cerrar la consola.*/
            string numeroString;
            int numeroIngresado;
            int contadorPares = 0;
            string respuesta = null;

            do
            {
                Console.WriteLine("Ingrese un numero");
                numeroString = Console.ReadLine();
                if (int.TryParse(numeroString, out numeroIngresado))
                {
                    for (int i = 2; i <= numeroIngresado; i++)
                    {
                        contadorPares = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                contadorPares++;
                            }
                        }
                        if (contadorPares < 3)
                        {
                            Console.WriteLine($"El numero {i} es primo");
                        }
                    }
                    Console.WriteLine("Desea Ingresar otro numero?(Ingresar salir de lo contrario)");
                    respuesta = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido");
                }

            } while (!string.Equals(respuesta, "salir"));




        }
    }
}
