﻿using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realiza una clase Finanzas que convierta dólares a euros y viceversa. 
            //Codifica los métodos dolaresToEuros y eurosToDolares.-Realiza
            //      Prueba que dicha clase funciona correctamente haciendo conversiones entre euros y dólares.
            //            La clase tiene que tener:
            //                Un constructor Finanzas() por defecto, el cual establecerá el cambio Dólar - Euro en 0.92.
            //                Un constructor Finanzas(double), el cual permitirá configurar el cambio dólar - euro.

            Finanzas finanzas = new Finanzas();
            Finanzas finanzas2 = new Finanzas(0.8);
            Console.WriteLine($"5 euros son: {finanzas.EurosToDolares(5)} dólares");
            Console.WriteLine($"8 dolares son: {finanzas2.DolaresToEuros(8)} euros");


        }
    }
}
