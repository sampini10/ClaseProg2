﻿using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
                El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.*/
            int rango = 9999;
            for (int i = 1; i < rango; i++)
            {
                int acumulador = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        acumulador += j;

                    }
                }
                if (acumulador == i && i != 1)
                {
                    Console.WriteLine($"El numero perfecto es: {acumulador}");
                }

            }
        }
    }
}
