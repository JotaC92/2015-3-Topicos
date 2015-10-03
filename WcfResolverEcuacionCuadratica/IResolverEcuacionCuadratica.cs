using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfResolverEcuacionCuadratica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IResolverEcuacionCuadratica
    {

        [OperationContract]
        void ResolverLaEcuacionCuadratica(double primerNumero, double segundoNumero, double tercerNumero, ref double primeraRaiz, ref double segundaRaiz);

        // TODO: Add your service operations here
    }
}
