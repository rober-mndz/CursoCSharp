using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            DateTime cum = new DateTime(2002, 09, 30);


            int edad;

            if (cum.Month > fecha.Month)
                edad = fecha.Year - cum.Year;
            else
                edad = fecha.Year - cum.Year - 1;

            Console.WriteLine("La edad es: " + edad);

            Console.ReadKey();


        }
    }
}
