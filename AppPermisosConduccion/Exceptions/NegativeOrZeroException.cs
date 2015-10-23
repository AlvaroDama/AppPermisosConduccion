using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPermisosConduccion.Exceptions
{
    class NegativeOrZeroException:Exception
    {
        public NegativeOrZeroException():base("No se pudo establecer el Permiso Máximo. El número es negativo o cero.") { }
    }
}
