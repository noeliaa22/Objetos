using System;

namespace EjercicioRepaso3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar una clase llamada Triangulo con tres atributos: 
             * lado1, lado2 y lado3, 
             * un constructor que me permita declarar objetos con tres argumentos y los métodos:
                EsIsosceles que devolverá verdadero si el triángulo es isósceles y falso en caso contrario
                EsEquilatero que devolverá verdadero si el triángulo es equilátero y falso en caso contrario
                EsEscaleno que devolverá verdadero si el triángulo es escaleno y falso en caso contrario
                Perímetro que devolverá el perímetro del triángulo
            Desde el método main() de la clase principal probar su funcionamiento */

            Triangulo triangulo = new Triangulo(1,7,3);

            triangulo.EsIsosceles();
            triangulo.EsEquilatero();
            triangulo.EsEscaleno();
            Console.WriteLine($"El triángulo tiene un perímetro de {triangulo.Perimetro()} centimetros");


        }
    }
}
