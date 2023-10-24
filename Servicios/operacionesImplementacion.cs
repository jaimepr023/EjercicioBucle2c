using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBucle2.Servicios
{
    internal class operacionesImplementacion : operacionesInterfaz
    {
        public void operacion(int n1, double n2)
        {
            double sumM = 1;
            for (int i=1;i<=n1;i++)
            {
                sumM *= n2;
            }
            
            Console.WriteLine("El resultado de la operacion es:"+sumM);
        }
    }
}
