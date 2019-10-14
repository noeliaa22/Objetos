﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class Satelite
    {
        private double meridiano;
        private double paralelo;
        private double distancia_tierra;

        public Satelite(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }

        public Satelite()
        {
            meridiano = paralelo = distancia_tierra = 0;
        }


        public void SetPosicion(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }
        public void PrintPosicion()
        {
            Console.WriteLine("El satélite se encuentra en el paralelo " + paralelo + "Meridiano "+meridiano+" a una distancia de la tierra de "+distancia_tierra+" Kilómetros");
           
            Console.ReadLine();
        }

        public void VariaAltura(double desplazamiento)
        {
            if (desplazamiento<0)
            {
               this.distancia_tierra += desplazamiento;
            }
            else
            {
                this.distancia_tierra += desplazamiento;
            }
        }

        public bool EnOrbita()
        {
            bool orbita = false;
            if (distancia_tierra<=0)
            {
                orbita = true;
            }
            else
            {
            }

            return orbita;
        }

        public void VariaPosicion(double variap, double variam)
        {
            this.meridiano+= variam;
            this.paralelo+=variap;
        }
    }
}
