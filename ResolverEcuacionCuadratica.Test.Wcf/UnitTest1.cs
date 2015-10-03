using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ResolverEcuacionCuadratica.Test.Wcf
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProbarResolverCorrectoMuyMuyExacto()
        {
            double primerNumero = -1;
            double segundoNumero = 2;
            double tercerNumero = 3;
            double primeraRaizReal = 0;
            double segundaRaizReal = 0;
            double primeraRaizEsperada = 3;
            double segundaRaizEsperada = -1;

            SICuadratica.ResolverEcuacionCuadraticaClient ecuacionCuadratica = new SICuadratica.ResolverEcuacionCuadraticaClient();

            ecuacionCuadratica.ResolverLaEcuacionCuadratica(primerNumero, segundoNumero, tercerNumero, ref primeraRaizReal, ref segundaRaizReal);

            Assert.IsTrue((primeraRaizEsperada == primeraRaizReal) || (primeraRaizEsperada == segundaRaizReal));
            Assert.IsTrue((segundaRaizEsperada == primeraRaizReal) || (segundaRaizEsperada == segundaRaizReal));
        }
    }
}
