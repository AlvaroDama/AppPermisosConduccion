using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPermisosConduccion.Clases;

namespace AppPermisosConduccion.Exceptions
{
    class FueraDeRangoException : Exception
    {
        public FueraDeRangoException(int permiso):base("El permiso "+permiso+" está fuera del rango. Permiso máximo impartido: " + Alumno.PermisoMaximo) { }
    }
}
