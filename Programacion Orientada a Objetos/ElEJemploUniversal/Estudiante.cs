using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElEJemploUniversal
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        static Estudiante()
        {
            random = new Random();
        }

        public int SetNotaPrimerParcial
        {
            set
            {
                if (value > 0 && value <= 10)
                {
                    this.notaPrimerParcial = value;
                }
            }
        }
    }
}
