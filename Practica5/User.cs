using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class User
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        public User(string n, string a, int e, string d)
        {
            Nombre = n;
            Apellido = a;
            Edad = e;
            Direccion = d;
        }
    }
}
