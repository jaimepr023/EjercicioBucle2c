using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBucle2.Servicios
{
    /// <summary>
    /// interfaz donde se encuentra el metodo para pedir el numero 
    /// <author>jpr-241023</author>
    /// </summary>
    internal interface pedirNumInterfaz
    {
        /// <summary>
        /// metodo que pide el numero por pantalla
        /// <author>jpr-241023</author>
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public double numero(int k);
    }
}
