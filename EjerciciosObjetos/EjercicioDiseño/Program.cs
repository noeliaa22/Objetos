using System;
using EjercicioRepaso1;

namespace EjercicioDiseño
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar una clase llamada Rectángulo que contenga :
            Dos atributos privados de tipo entero:  largo y ancho
            Y los siguientes métodos públicos
            Un constructor que permita declarar objetos sin argumentos
            Un constructor que permita declarar objetos con dos argumentos ( largo y ancho)
            Métodos selectores (get) y modificadores (set)
            
            Un método llamado Area que devuelve el área del rectángulo
            Un método llamado diagonal que devuelve el valor de la diagonal ( con decimales)
            Desde el método main() de la clase principal probar su funcionamiento*/

            Rectangulo rectangulo = new Rectangulo(19,17);

            Console.WriteLine($"El área del rectángulo es de: {rectangulo.Area()}");
            Console.WriteLine($"La diagonal del rectángulo es igual a: {rectangulo.Diagonal()}");
            
            
            


        }
    }
}
