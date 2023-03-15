using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_proyecto
{
    internal class Alumno
    {
        private int numero;
        private string nombres;
        private string apellidos;
        private DateTime fechaNacimiento;
        
        //properties en C#

    public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public int GetNumero()
        {
            return this.numero;
        }
        
        public void SetNumero(int n)
        {
            this.numero = n;
        }
    }
}
