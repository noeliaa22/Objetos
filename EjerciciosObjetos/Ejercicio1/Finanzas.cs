using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Finanzas
    {
        private double cambio;


        public Finanzas()
        {
            cambio = 0.92;
        }
        public Finanzas(double cambio)
        {
            this.cambio = cambio;
        }

        public double DolaresToEuros(double dolares)
        {
            return dolares*cambio;
        }

        public double EurosToDolares(double euros)
        {
            return euros/cambio;
        }



    }

   
}
