using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPermisosConduccion.Exceptions
{
    class FaltaPermisoException: Exception
    {
        public override sealed string Message {get;}

        public FaltaPermisoException(int actual, int aConseguir)
        {
            if (actual<aConseguir)
            {
                Message = "No se puede conseguir. Faltan los permisos: ";
                for (var i = actual; i < aConseguir; i++)
                {
                    Message += actual;
                    if (actual!=aConseguir)
                        Message += ", ";    
                }
                Message += ".";

            }
            else
            {
                Message = "Su permiso actual es " + actual + ". No puede conseguir el permiso " + aConseguir;
            }

        }
    }
}
