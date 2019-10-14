using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioRepaso2
{
    class Monedero
    {
        public double CantidadDinero { get; set; }

        public Monedero(double cantidadDinero)
        {
            CantidadDinero = cantidadDinero;
        }

        public Monedero()
        {
        }
        public void MeterDinero(double ingreso)
        {
            if (ingreso>0)
            {
            CantidadDinero += ingreso;
            }
            else
            {
                Console.WriteLine("La cantidad no puede ser negativa o 0");
            }
        }
        public void SacarDinero(double retiro)
        {
            if (retiro<0)
            {
            if (CantidadDinero>=retiro)
            {
                CantidadDinero -= retiro;
            }
            else
            {
                Console.WriteLine("No tiene suficiente dinero para retirar");
            }
            }
            else
            {
                Console.WriteLine("La cantidad no puede ser positiva ni 0");
            }
        }
        public void Consulta()
        {
            Console.WriteLine($"Su monedero contiene {CantidadDinero} euros actualmente.");
        }
    }
}
