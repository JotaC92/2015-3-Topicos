using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class CalcularRaices
    {
        public void CalcularLasRaices(double discriminante, double primerNumero, double segundoNumero, double tercerNumero, ref double primeraRaiz, ref double segundaRaiz)
        {
            primeraRaiz = (-primerNumero + Math.Sqrt(discriminante)) / (2 * primerNumero);
            segundaRaiz = (-primerNumero - Math.Sqrt(discriminante)) / (2 * primerNumero);
        }
    }
}
