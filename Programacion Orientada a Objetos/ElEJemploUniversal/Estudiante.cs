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
                else
                {
                    this.notaPrimerParcial = 1;
                }
            }
        }
        public int SetNotaSegundoParcial
        {
            set
            {
                if (value > 0 && value <= 10)
                {
                    this.notaSegundoParcial = value;
                }
                else
                {
                    this.notaSegundoParcial = 1;
                }
            }
        }
        private float CalcularPromedio()
        {
            float promedio;

            promedio = (notaPrimerParcial + notaSegundoParcial) / 2;

            return promedio;
        }
        public double CalcularNotalFinal()
        {
            double notaFinal;
            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 10);
            }
            else
            {
                notaFinal = -1;
            }
            return notaFinal;
        }

        public string Mostrar()
        {
            double notaFinal;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El alumno {this.nombre} {this.apellido} Legajo: {this.legajo}");
            sb.AppendLine($"Nota primer parcial {this.notaPrimerParcial} y segundo parcial {this.notaSegundoParcial}");
            sb.AppendLine($"Tiene un promedio de {CalcularPromedio()}");
            notaFinal = CalcularNotalFinal();
            if(notaFinal != -1)
            {
                sb.AppendLine($"Tiene nota final {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno Desaprobado");
            }
            return sb.ToString();
        }

    }
}
