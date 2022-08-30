using System;


namespace ValidarRangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresoStr;
            int numeroIngreso;
            int numeroMaximo = int.MinValue;
            int numeroMinimo = int.MaxValue;
            float valorPromedio = 0;


            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100");
                numeroIngresoStr = Console.ReadLine();
                if(int.TryParse(numeroIngresoStr, out numeroIngreso))
                {
                    if (Validador.Validar(numeroIngreso, -100, 100))
                    {
                        if(numeroIngreso > numeroMaximo)
                        {
                            numeroMaximo = numeroIngreso;
                        }
                        if(numeroIngreso < numeroMinimo)
                        {
                            numeroMinimo = numeroIngreso;
                        }

                        valorPromedio += numeroIngreso;
                    }
                    else
                    {
                        Console.WriteLine("Fuera de rango");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("No es un numero correcto");
                    i--;
                }
            }
            valorPromedio /= 10;

            Console.WriteLine($"El promedio es {valorPromedio}");
            Console.WriteLine($"El maximo es {numeroMaximo}");
            Console.WriteLine($"El minimo es {numeroMinimo}");
        }
    }
}
