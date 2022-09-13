using System;

namespace ElEJemploUniversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Nicolas", "Sampini", "10233");
            Estudiante estudiante2 = new Estudiante("Jorge", "Garcia", "10356");
            Estudiante estudiante3 = new Estudiante("Ramiro", "Perez", "541232");

            estudiante1.SetNotaPrimerParcial = 4;
            estudiante1.SetNotaSegundoParcial = 4;
            estudiante2.SetNotaPrimerParcial = 8;
            estudiante2.SetNotaSegundoParcial = 10;
            estudiante3.SetNotaPrimerParcial = 3;
            estudiante3.SetNotaSegundoParcial = 2;

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}
