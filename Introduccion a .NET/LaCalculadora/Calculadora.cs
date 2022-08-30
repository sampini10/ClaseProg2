using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCalculadora
{
    public class Calculadora
    {
        public static double Calcular(double primerNumero, double segundoNumero, string operacion)
        {
            double result = 0;

            switch (operacion)
            {
                case "+":
                    {
                        result = primerNumero + segundoNumero;
                        break;
                    }
                case "-":
                    {
                        result = primerNumero - segundoNumero;
                        break;
                    }
                case "*":
                    {
                        result = primerNumero * segundoNumero;
                        break;
                    }
                case "/":
                    {
                        if(Validar(segundoNumero))
                        {
                            result = primerNumero + segundoNumero;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero");
                            break;
                        }
                    }
                default:
                        Console.WriteLine("No es valida la operacion");
                        break;
                    
            }
         
            return result;
        }

        private static bool Validar(double segundoNumero)
        {
            if(segundoNumero != 0)
            {
                return true;
            }
            return false;
        }
    }
}
