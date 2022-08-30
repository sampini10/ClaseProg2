using System;

namespace CreoQueNecesitoUnPrestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Nicolas", 30000);
            Cuenta cuenta2 = new Cuenta("Gerardo", 100000);

            cuenta1.Mostrar();
            cuenta2.Mostrar();

            cuenta1.Ingresar(50000);
            cuenta1.Ingresar(-400000000);
            cuenta1.Ingresar(20000);
            cuenta1.Retirar(90000);
            cuenta1.Retirar(100000);
        }
    }
}
