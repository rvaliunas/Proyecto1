using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Alumno unAlumno = new Alumno();
            unAlumno.Numero = 123456;

            Console.WriteLine(
                string.Format("Se creó el alumno con numero {0}", unAlumno.Numero)
                );

            //si no ponemos esta lìnea, la consola se abre y cierra muy rápido.
            Console.ReadLine();
        }
    }
}
