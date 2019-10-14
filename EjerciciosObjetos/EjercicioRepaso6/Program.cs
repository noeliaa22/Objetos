using System;

namespace EjercicioRepaso6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6.- Diseñar una clase llamada Hipoteca con los siguientes atributos (capital, rédito, tiempo) y los métodos:
-          Un constructor que inicializa los atributos con los valores pasados como argumentos
-          Un método llamado cuota que devuelve la cuota a pagar ( i=c*r*t/100)
-          Un método que muestre todos los atributos.
            Desde el método principal main() crear un programa que nos permita ver una tabla con 
            las diferentes cuotas a pagar por interés por ejemplo: si tenemos una hipoteca de 6000 €  
            a un rédito del 3.5% y lo pagamos a 10,11,..,., hasta 20 años.
           Escribirá:                      
                                            CAPITAL :6000 	REDITO: 3.5%
                                           	TIEMPO  	CUOTA
                                           	10             	2100
                                           	11             	2310
                                           	….            	……...
                                           	20             	4200 */

            Hipoteca hipoteca = new Hipoteca(6000,3.5,20);

            Console.WriteLine($"CAPITAL: {hipoteca.Capital}\tREDITO: {hipoteca.Redito}%");
            Console.WriteLine($"TIEMPO\t\tCUOTA");
            for (int i =10; i <= hipoteca.Tiempo; i++)
            {
                Console.WriteLine(i);
                hipoteca.Cuota();
            }


        }
    }
}
