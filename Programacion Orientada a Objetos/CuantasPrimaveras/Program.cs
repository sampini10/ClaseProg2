using System;

namespace CuantasPrimaveras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Nicolas", DateTime.Parse("27/06/1991"), 11252362);
            Persona persona2 = new Persona("Eduardo", DateTime.Parse("27/06/1996"), 12365479);
            Persona persona3 = new Persona("Maximo", DateTime.Parse("27/06/2012"), 40564789);
            persona.Mostrar();
            persona2.Mostrar();
            persona3.Mostrar();
        }
    }
}
