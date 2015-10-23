using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using AppPermisosConduccion.Clases;
using AppPermisosConduccion.Exceptions;

namespace AppPermisosConduccion
{
    class Program
    {
        static Collection<Alumno> alumnos = new Collection<Alumno>();

        static void Main(string[] args)
        {

            string op;
            var continua = true;

            do
            {
                
                do
                {
                    Console.Write("1) Alta alumno.\n" +
                                  "2) Listar alumnos.\n" +
                                  "3) Dar permiso.\n");

                    op = Console.ReadLine();

                    if (op != "1" | op != "2" | op != "3")
                        break;

                } while (true);

                Console.Clear();

                switch (op)
                {
                    
                    case "1":
                    {
                            do
                            {
                                try
                                {
                                    alumnos.Add(CreaAlumno());
                                    continua = false;
                                }
                                catch (MenorDeEdadException e)
                                {
                                    Console.WriteLine(e.Message + "\n");
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message + "\n");
                                }

                            } while (continua);
                    }
                        break;

                    case "2":
                    {
                        MuestraAlumnos();
                        break;
                    }

                    case "3":
                    {
                        MuestraAlumnos();
                        string selec;
                        int index;
                        

                        do
                        {
                            try
                            {
                                    selec = Console.ReadLine();
                                    Console.Clear();

                                    if (Int32.TryParse(selec, out index))
                                        Modificar(index-1);

                            }
                            catch (Exception e)
                            {
                                
                                Console.WriteLine(e.Message);
                            }
                            

                        } while (continua);
                        

                        break;
                    }

                }

            } while (Console.ReadLine().ToUpper()!="EXIT");



        }

        public static void Modificar(int index)
        {
            int perm;
            string inp;

            Console.WriteLine(alumnos[index].Detalles());
            Console.Write("¿Permiso?: ");
            inp= Console.ReadLine();
            if (Int32.TryParse(inp, out perm))
            {
                alumnos[index].ObtenerPermiso(perm);
            }
            
        }

        public static Alumno CreaAlumno()
        {
            Console.Write("Nombre: ");
            var nom = Console.ReadLine();
            Console.Write("Edad: ");
            var edad = Int32.Parse(Console.ReadLine());

            return new Alumno(nom, edad);
        }

        public static void MuestraAlumnos()
        {
            foreach (var al in alumnos)
            {
                Console.WriteLine((alumnos.IndexOf(al)+1) + ") " + al.Detalles());
            }
        }

    }
}
