using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class CalcularDiscriminante
    {
        public double CalcularElDiscriminante(double primerNumero, double SegundoNumero, double TercerNumero)
        {
            double resultado = 0;
            resultado = (Math.Pow(SegundoNumero, 2) - 4 * primerNumero * TercerNumero);
            return (resultado);
        }
    }
}
