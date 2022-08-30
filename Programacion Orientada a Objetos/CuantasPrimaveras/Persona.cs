using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuantasPrimaveras
{
    public class Persona
    {
        public string nombre;
        public DateTime fechaDeNacimiento;
        public int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetFecha(DateTime fecha)
        {
            this.fechaDeNacimiento = fecha;
        }
        public void SetDni(int dni)
        {
            this.dni = dni;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public DateTime GetFecha()
        {
            return this.fechaDeNacimiento;
        }
        public int GetDni()
        {
            return this.dni;
        }
        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - this.GetFecha().Year;
            Console.WriteLine($"La edad de {this.GetNombre()} es {edad}");
            return edad;
           
        }
        public void Mostrar()
        {
            Console.WriteLine($"La persona {this.GetNombre()}, nacido el {this.GetFecha()} con DNI {this.GetDni()} tiene {this.CalcularEdad()} años");
            Console.WriteLine($"{this.EsMayorDeEdad()}");
        }

        public string EsMayorDeEdad()
        {
            string respuesta;
            int edad = CalcularEdad();

            if(edad < 18)
            {
                respuesta = "Es menor";
            }
            else
            {
                respuesta = "Es Mayor";
            }

            return respuesta;
        }
       
    }
}
