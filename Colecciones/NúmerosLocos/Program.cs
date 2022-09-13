using System;
using System.Collections.Generic;

namespace NúmerosLocos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> listaNumeros = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int numeroRandom = random.Next(-100, 100);
                if (numeroRandom != 0)
                {
                    listaNumeros.Add(numeroRandom);
                }
                else
                {
                    listaNumeros.Add(1);
                }
            }
            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }

            listaNumeros.Sort();
            Console.WriteLine("****Lista positivos*****");

            foreach (int item in listaNumeros)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("****Lista negativos*****");
            foreach (int item in listaNumeros)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }



        }
    }
}
