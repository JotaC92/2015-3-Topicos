using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfResolverEcuacionCuadratica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ResolverEcuacionCuadratica : IResolverEcuacionCuadratica
    {
        public void ResolverLaEcuacionCuadratica(double primerNumero, double segundoNumero, double tercerNumero, ref double primeraRaiz, ref double segundaRaiz)
        {
            //instanciar la clase que resuelve la ecuacion
            ResolverEcuacionCuadratica resolverEcuacion = new ResolverEcuacionCuadratica();
            //invoque el metodo que resuelve la ecuacion
            resolverEcuacion.ResolverLaEcuacionCuadratica(primerNumero, segundoNumero, tercerNumero, ref primeraRaiz, ref segundaRaiz);
            //* tarea moral
            //cambie los nombres de los namespaces para que a la hora de llamar al metodo en este procedimiento NO se invoque a si mismo, sino al metodo que corresponde
        
        }
    }
}
