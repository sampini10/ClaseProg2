using System;

namespace EstadisticaDeportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(5, "Bentic");
            Jugador jugador1 = new Jugador(201344,"Nicolas",30,30);
            Jugador jugador2 = new Jugador(201345, "Roberto", 0, 11);
            Jugador jugador3 = new Jugador(201346, "Frank", 3, 30);
            Jugador jugador4 = new Jugador(201347, "Rafael", 3, 3);
            Jugador jugador5 = new Jugador(201348, "Messi", 300, 30);
            Jugador jugador6 = new Jugador(201349, "Claudio",4 , 2);
            Jugador jugador7 = new Jugador(201344, "Claudio", 4, 2);

            if(equipo + jugador1)
            {
                Console.WriteLine(jugador1.MostrarDatos());
            }
            if (equipo + jugador2)
            {
                Console.WriteLine(jugador2.MostrarDatos());
            }
            if (equipo + jugador3)
            {
                Console.WriteLine(jugador3.MostrarDatos());
            }
            if (equipo + jugador4)
            {
                Console.WriteLine(jugador4.MostrarDatos());
            }
            if (equipo + jugador5)
            {
                Console.WriteLine(jugador5.MostrarDatos());
            }
            if (equipo + jugador6)
            {
                Console.WriteLine(jugador6.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar por falta de lugar");
            }
            if (equipo + jugador7)
            {
                Console.WriteLine(jugador7.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar por que existe el jugador");
            }
        

        }
    }
}
