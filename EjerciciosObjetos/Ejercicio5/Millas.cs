using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    class Millas
    {
        private double millas { get; set; }
        public Millas(double millas)
        {
            this.millas = millas;
        }
        public double MillasAMetros()
        {
            return millas * 1852;
        }
        public double MillasAKilometros()
        {
            return millas * 1.852;
            //return MillasAMetros()/1000;
        }
    }

}
