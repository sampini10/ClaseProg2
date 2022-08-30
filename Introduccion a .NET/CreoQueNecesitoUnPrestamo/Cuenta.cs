using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreoQueNecesitoUnPrestamo
{
    public class Cuenta
    {
        public string titular;
        public int cantidad;

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return this.titular;
        }
        public int GetCantidad()
        {
            return this.cantidad;
        }
        public void Mostrar()
        {
           Console.WriteLine($"El titular {titular} tiene un saldo de: {cantidad}");
        }
        public void Ingresar(int cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad += cantidad;
                Console.WriteLine($"El titular {this.titular} tiene un saldo actualizado de: {this.cantidad}");
            }
        }
        public void Retirar(int cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad -= cantidad;
                Console.WriteLine($"El titular {this.titular} tiene un saldo actualizado de: {this.cantidad}");
            }
        }

    }
}
