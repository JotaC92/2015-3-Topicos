﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class ResolverEcuacionCuadratica
    {
        public void ResolverLaEcuacionCuadratica(double primerNumero, double segundoNumero, double tercerNumero, ref double primeraRaiz, ref double segundaRaiz)
        {
            // calcular el discriminante
            CalcularDiscriminante accionCalcularDiscriminante = new CalcularDiscriminante();
            double discriminante = accionCalcularDiscriminante.CalcularElDiscriminante( primerNumero, segundoNumero, tercerNumero);
            // validar el discriminante
            ValidarDiscriminante validarDiscriminante = new ValidarDiscriminante();
            if (validarDiscriminante.ValidarDiscriminanteMayorQueCero(discriminante))
            {
                // calcular las raices
                CalcularRaices calcularRaices = new CalcularRaices();
                calcularRaices.CalcularLasRaices(discriminante, primerNumero, segundoNumero, tercerNumero, ref primeraRaiz, ref segundaRaiz);
            }
            else
            {
                //levante una excepcion
                Exception ex = new Exception(string.Format("Ocurrio un error al calcular las raices, " 
                    + "ya que el discriminante [{0}] es menor que cero.", discriminante.ToString()));
                throw ex;
            }
        }
    }
}
