using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Dada la clase satelite:

 Modifica la clase satélite y añádele los siguientes métodos:
 
            Método void VariaAltura(double desplazamiento): 
            Este método acepta un parámetro que será positivo o negativo dependiendo de si el satélite 
            tiene que alejarse o acercarse a La Tierra.
 
            Método bool EnOrbita(): Este método devolverá false si el satélite está en tierra, 
            y true en caso contrario.
 
            Método void VariaPosicion(double variap, double variam): 
            Este método permite modificar los atributos de posición (meridiano y paralelo) 
            mediante los parámetros variap y variam. Estos parámetros serán valores positivos o negativos 
            relativos que harán al satélite modificar su posición.*/

            Satelite satelite = new Satelite(2,4,-9);

            if (satelite.EnOrbita()==true)
            {
                Console.WriteLine("El satelite está en la tierra");
            }
            else
            {
                Console.WriteLine("El satelite está en orbita");
            }
           


        }
    }
}
