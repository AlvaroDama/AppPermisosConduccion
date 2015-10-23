using AppPermisosConduccion.Exceptions;

namespace AppPermisosConduccion.Clases
{

    public enum Permisos {A=1, B, C, D, E}

    public class Alumno
    {
        public string Nombre { get; set; }
        private int _edad;
        public int PermisoActual { get; set; }

        private static int _maxPermisos = 5;

        public static int PermisoMaximo
        {
            get { return _maxPermisos; }
            set
            {
                if (value <=0)
                    throw new NegativeOrZeroException();
                    
                _maxPermisos = value;
            }
        }

        public int Edad
        {
            get
            {
                return _edad;
            }

            set
            {
                if (value<18)
                    throw new MenorDeEdadException();
                _edad = value;
            }
        }

        public Alumno(string nombre, int edad)
        {
            Edad = edad;
            Nombre = nombre;
            PermisoActual = 0;
        }


        public void ObtenerPermiso(int permiso)
        {
            if (permiso<1 || permiso>(int) PermisoActual )
                throw new FueraDeRangoException(permiso);

            if ((permiso != (int) (PermisoActual+1)))
                throw new FaltaPermisoException(this.PermisoActual, permiso);

            PermisoActual = permiso;

        }

        public string Detalles()
        {
            var msg = Nombre +" (" +Edad +")" +" con permiso: "+ PermisoActual;
            return msg;
        }

    }
}
