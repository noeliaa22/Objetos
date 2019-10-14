using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea una clase con un método MillasAMetros() que toma como parámetro de entrada
            //un valor en millas marinas y las convierte a metros.

            //Una vez tengas este método escribe otro MillasAKilometros() 
            //que realice la misma conversión, pero esta vez exprese el resultado en kilómetros.

            //Nota: 1 milla marina equivale a 1852 metros.

            Millas millas1 = new Millas(234);
            
            Console.WriteLine($" 234 millas son {millas1.MillasAMetros()} metros");
            Console.WriteLine($" 234 millas son {millas1.MillasAKilometros()} kilometros");



        }
    }
}
