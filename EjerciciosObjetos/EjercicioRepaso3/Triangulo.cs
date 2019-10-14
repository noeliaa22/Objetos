using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioRepaso3
{
    class Triangulo
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }
        public int Lado3 { get; set; }

        public Triangulo(int lado1, int lado2, int lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }
        public bool EsIsosceles()
        {
            if (!EsEquilatero() && !EsEscaleno())
            {
                return true;
            }
            else
            {
                return false;
            }

            //if (Lado1 == Lado2 || Lado2 == Lado3 || Lado1==Lado3 && !(Lado1 == Lado2 && Lado2 == Lado3))
            //{
            //    esIsosceles = true;
            //    Console.WriteLine("El triángulo es isosceles");

            //}
            //else
            //{
            //    Console.WriteLine("El triángulo no es isosceles");
            //}

            //return esIsosceles;

        }

        public bool EsEquilatero()
        {
            bool esEquilatero = false;
            if (Lado1==Lado2 && Lado2==Lado3)
            {
                esEquilatero = true;
                Console.WriteLine("El triángulo es equilatero");
            }
            else
            {
                Console.WriteLine("El triángulo no es equilatero");
            }
            return esEquilatero;
        }
        public bool EsEscaleno()
        {
            bool esEscaleno = false;
            if (Lado1 != Lado2 && Lado2 != Lado3 && Lado1!=Lado3)
            {
                esEscaleno = true;
                Console.WriteLine("El triángulo es escaleno");

            }
            else
            {
                Console.WriteLine("El triángulo no es escaleno");
            }
            return esEscaleno;
        }
        public int Perimetro()
        {
            int perimetro = Lado1 + Lado2 + Lado3;
            return perimetro;
        }

    }
}
