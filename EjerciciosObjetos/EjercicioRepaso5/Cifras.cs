using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioRepaso5
{
    class Cifras
    {
        public int Numero { get; set; }

        public Cifras(int numero)
        {
            Numero = numero;
        }
        public bool EsPar()
        {
            bool esPar = false;
            if (Numero%2==0)
            {
                esPar = true;
                Console.WriteLine($"El número {Numero} es par");
            }
            else
            {
                Console.WriteLine($"El número {Numero} es impar");
            }
            return esPar;
        }
        public string Dividores()
        {
            string divisores = "";
            for (int i = 1; i <= Numero; i++)
            {
                if (Numero%i==0)
                {
                    divisores += i.ToString()+ ",";
                }
            }
            return divisores;
        }
        public int SumaDigitos()
        {
            int suma=0;
            string digitos = Numero.ToString();
            for (int i = 0; i < digitos.Length; i++)
            {
                int numero = Convert.ToInt32(digitos.Substring(i,1));
                suma += numero;
            }
            return suma;
        }

    }
}
