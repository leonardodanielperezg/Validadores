using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Validador
    {

        public Boolean esEntero(string entero)
        {
            int x = Int32.Parse(entero);
            if (x%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public Boolean esDecimal(string deci)
        {
            if (deci.Contains("."))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean esEdad(string edad)
        {
            int x = Int32.Parse(edad);
            if (x < 110)
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
