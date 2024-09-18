using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class User
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }

        public User(string n, string a, float p, float alt)
        {
            Nombre = n;
            Apellido = a;
            Peso = p;
            Altura = alt;
        }
    }
}
