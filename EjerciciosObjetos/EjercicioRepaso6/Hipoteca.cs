using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioRepaso6
{
    class Hipoteca
    {
        public double Capital { get; set; }
        public double Redito { get; set; }
        public double Tiempo { get; set; }

        public Hipoteca(double capital, double redito, double tiempo)
        {
            Capital = capital;
            Redito = redito;
            Tiempo = tiempo;
        }
        public void Cuota()
        {
            double cuota;
            for (int i = 1; i <= Tiempo; i++)
            {
             cuota= Capital * Redito * Tiempo/ 100;
             Console.WriteLine($"\t\t{cuota}");                
                Tiempo--;
            }
            
        }
        public void Mostrar()
        {
            
            Console.WriteLine($"Capital: {Capital} \nRedito: {Redito}\nTiempo: {Tiempo}\n");
        }
    }
}
