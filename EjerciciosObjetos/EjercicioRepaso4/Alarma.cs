using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioRepaso4
{
    class Alarma
    {
        public double Temperatura { get; set; }
        public string Timbre { get; set; }

        public Alarma(double temperatura, string timbre)
        {
            Temperatura = temperatura;
            Timbre = "Apagado";
        }

        public Alarma()
        {
            Timbre = "Apagado";
        }
        public void Comprueba()
        {
            if (Temperatura>35 || Temperatura<10)
            {
                Timbre = "Encendido";
                Console.WriteLine("El timbre está encendido: la temperatura no está en entre 10 y 35 grados");
            }
            else
            {                
                Timbre = "Apagado";
                Console.WriteLine("La temperatura es estable y el timbre está apagado");
            }
        }
        public void Normaliza()
        {
            Temperatura = 25;
            Timbre = "Apagado";
            Console.WriteLine("La temperatura se ha estabilizado a 25 grados y el timbre se ha apagado");
        }
    }
}
