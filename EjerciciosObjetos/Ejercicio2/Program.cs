using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Realiza una clase número que almacene un número entero y tenga las siguientes características:

            //Constructor por defecto que inicializa a 0 el número interno.
            //Constructor que inicializa el número interno(pasado por parámetro).

            //Método Aniade que permite sumarle un número al valor interno(++).
            //Método Resta que resta un número al valor interno(--).
            //Método GetValor. Devuelve el valor interno.
            //Método GetDoble. Devuelve el doble del valor interno.
            //Método GetTriple. Devuelve el triple del valor interno.
            //Método SetNumero. Inicializa de nuevo el valor interno.

            Numero numeroEntero = new Numero();
            Numero numeroEntero2 = new Numero(5);

            numeroEntero.Anidade();
            Console.WriteLine(numeroEntero.GetValor());

            //numeroEntero2.GetTriple(); no establece el valor
            numeroEntero2.SetNumero(numeroEntero2.GetTriple()); // asi lo establece
            numeroEntero2.SetNumero(numeroEntero2.GetDoble());
            Console.WriteLine(numeroEntero2.GetValor());



        }
    }
}
