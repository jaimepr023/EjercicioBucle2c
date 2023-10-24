using EjercicioBucle2.Servicios;

namespace EjercicioBucle2
{
    /// <summary>
    /// clase principal de nuestra programa
    /// <author>jpr-241023</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// metrodo principal de nuestro programa
        /// <author>jpr-241023</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args) 
        {
            pedirNumInterfaz pn = new pedirNumImplementacion();
            operacionesInterfaz op = new operacionesImplementacion();
            double numeroDouble = pn.numero(0);
            int numeroEntero = (int)pn.numero(1);
            op.operacion(numeroEntero,numeroDouble);




        }
    }
}
