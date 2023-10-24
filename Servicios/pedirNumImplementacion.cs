using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBucle2.Servicios
{
    internal class pedirNumImplementacion : pedirNumInterfaz
    {
        public double numero(int k)
        {
            double numeroDouble;
            if (k == 0)
            {
                Console.WriteLine("Escribe el numero double:");
            }
            else
            {                           
                    Console.WriteLine("Escribe el numero entero:");                   
            }
            numeroDouble= double.Parse(Console.ReadLine());
            return numeroDouble;
        }

    }
}
