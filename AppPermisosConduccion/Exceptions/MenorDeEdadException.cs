using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPermisosConduccion.Exceptions
{
    class MenorDeEdadException : Exception
    {
        public MenorDeEdadException() : base("El alumno no puede ser menor de edad."){}
    }
}
