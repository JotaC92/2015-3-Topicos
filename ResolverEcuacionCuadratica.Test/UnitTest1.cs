using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResolverEcuacionCuadratica;

namespace ResolverEcuacionCuadratica.Test
{
    //Declare variables para los parametros reales
    //Declare variables para los valores reales
    //Declare variables para los valores esperados
    //Construya la logica que realiza la prueba
    //Asegurese de que los valores reales son iguales a los esperados
    [TestClass]
    public class PruebasUnitariasEcuacionCuadratica
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

            ResolverEcuacionCuadratica ecuacionCuadratica = new ResolverEcuacionCuadratica();

            ecuacionCuadratica.ResolverLaEcuacionCuadratica(primerNumero, segundoNumero, tercerNumero, ref primeraRaizReal, ref segundaRaizReal);

            Assert.IsTrue((primeraRaizEsperada == primeraRaizReal) || (primeraRaizEsperada == segundaRaizReal));
            Assert.IsTrue((segundaRaizEsperada == primeraRaizReal) || (segundaRaizEsperada == segundaRaizReal));
        }

        /*
        Tarea Moral
        Cree pruebas unitarias para los siguientes casos:
        - Pruebas correctas para resultados reales con muchos decimales de modo.
          que la coincidencia NO sea exacta y se aprueben cuando coincidan al menos en el sexto decimal.
        - Pruebas correctas para cuando el discriminante es negativo.
        - Pruebas para cuando el valor de a (primerNumero) es igual a cero (0).
        */
    }
}
