using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeseaContinuar
{
    public class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            if(respuesta == "s")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
