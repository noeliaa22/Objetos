using System;

namespace EjercicioRepaso2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Define una clase Monedero que permita gestionar la cantidad de dinero de que una 
             * persona dispone en un momento dado. 
             * La clase deberá tener un constructor que permitirá crear un monedero con una cantidad
             * de dinero inicial y 
             * deberá definir un método para meter dinero en el monedero, 
             * otro para sacarlo y finalmente, otro para consultar el disponible; 
             * solo podrá conocerse la cantidad de dinero del monedero a través de 
             * este último método. Por supuesto, no se podrá sacar más dinero del que haya en un momento
             * dado en el monedero. Desde el método main() de la clase principal probar su funcionamiento */

            Monedero monedero = new Monedero(123);
            monedero.MeterDinero(56.9);
            monedero.SacarDinero(30);
            monedero.Consulta();

        }
    }
}
