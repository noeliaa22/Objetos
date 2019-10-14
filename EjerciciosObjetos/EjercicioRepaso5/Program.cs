using System;

namespace EjercicioRepaso5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5.- Se pretende crear una clase llamada Cifras que tenga como único atributo privado
             * un número entero y los métodos siguientes:
-          Un constructor que permite inicializar el número con el valor pasado como argumento.
-          Un método llamado esPar que devuelve verdadero si lo es y falso en caso contrario.
-          Un método llamado divisores que escribe todos sus divisores.
-          Un método llamado sumaDigitos que devuelve un entero con la suma de sus dígitos.*/

            Cifras cifras = new Cifras(24);

            cifras.EsPar();
            Console.WriteLine($"Sus divisores son: {cifras.Dividores()}");
            Console.WriteLine($"La suma de sus digitos es = {cifras.SumaDigitos()}");
        }
    }
}
