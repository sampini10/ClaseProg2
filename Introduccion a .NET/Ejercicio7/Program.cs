using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
            Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
            hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.*/
            float valorHora;
            int antiguedad;
            int cantHoras;
            string nombre;
            string valorString;
            string antiguedadString;
            string horasString;
            string respuesta = "";
            float totalNeto;
            float totalBruto;

            do
            {
                Console.WriteLine("Ingrese el nombre del empleado");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el valor por hora");
                valorString = Console.ReadLine();
                Console.WriteLine("Ingrese la antiguedad del empleado");
                antiguedadString = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de horas del empleado");
                horasString = Console.ReadLine();

                if (float.TryParse(valorString, out valorHora) && int.TryParse(antiguedadString, out antiguedad)
                    && int.TryParse(horasString, out cantHoras))
                {
                    totalBruto = valorHora * cantHoras + (antiguedad * 150);
                    totalNeto = totalBruto - (totalBruto * 13 / 100);

                    Console.WriteLine($"El empleado: {nombre}");
                    Console.WriteLine($"Con Antiguedad: {antiguedad}");
                    Console.WriteLine($"Tiene valor de hora: {valorHora}");
                    Console.WriteLine($"Cobra un total en bruto: {totalBruto}");
                    Console.WriteLine($"Cobra un total en neto: {totalNeto}");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Desea cargar otro empleado?(Ingrese Si)");
                    respuesta = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Ingreso algun dato incorrectamente");
                    respuesta = "si";
                }

            } while (respuesta == "si");





        }
    }
}
