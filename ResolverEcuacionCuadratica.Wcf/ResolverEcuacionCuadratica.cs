using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ResolverEcuacionCuadratica.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ResolverEcuacionCuadratica : IResolverEcuacionCuadratica
    {
        public void ResolverLaEcuacionCuadratica(double primerNumero, double segundoNumero, double tercerNumero, ref double primeraRaiz, ref double segundaRaiz)
        {
            //instanciar la clase que resuelve la ecuacion
            ResolverEcuacionCuadratica resolverEcuacion = new ResolverEcuacionCuadratica();
            //invoque el metodo que resuelve la ecuacion
            resolverEcuacion.ResolverLaEcuacionCuadratica(primerNumero, segundoNumero, tercerNumero, ref primeraRaiz, ref segundaRaiz);
        }

    }
}
