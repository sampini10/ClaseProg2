using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que determine si un año es bisiesto.
            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
            Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.*/
            int numeroIngresoInicio;
            int numeroIngresoFin;
            string numeroStringInicio;
            string numeroStringFin;
            bool esNumero;

            do
            {
                Console.WriteLine("Ingrese año de inicio y de fin");
                numeroStringInicio = Console.ReadLine();
                numeroStringFin = Console.ReadLine();

                if (int.TryParse(numeroStringInicio, out numeroIngresoInicio)
                    && int.TryParse(numeroStringFin, out numeroIngresoFin) && numeroIngresoInicio < numeroIngresoFin)
                {
                    esNumero = true;
                    for(int i = numeroIngresoInicio; i < numeroIngresoFin; i++)
                    {
                        if(i % 400 == 0 || i % 4 == 0 && i % 100 != 0)
                        {
                            Console.WriteLine($"Es bisiesto: {i}");
                        }
                        else
                        {
                            Console.WriteLine($"No es bisiesto: {i}");
                        }
                    }
                }
                else
                {
                    esNumero = false;
                    Console.WriteLine("Comprobar que sean numeros y que el inicio sea menor al fin");
                }

            } while (esNumero == false);

        }
    }
}
