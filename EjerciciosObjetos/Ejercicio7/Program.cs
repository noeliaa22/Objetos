using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.
            /* Implementa una clase consumo, la cual forma parte de la centralita electrónica 
             * de un coche que almacena la información de un viaje realizado y tiene las siguientes
             * características:
 
               Atributos:
                – kms. Kilómetros recorridos por el coche.
                – litros. Litros de combustible consumido.
                – vmed. Velocidad media. (KM/h)
                – tipo de combustible
                Métodos:
                – GetTiempo. Indicará el tiempo empleado en realizar el viaje.
                – ConsumoMedio. Consumo medio del vehículo (en litros cada 100 kilómetros).
 
             No olvides crear un constructor para la clase que establezca el valor de los atributos.
             Elige el tipo de datos más apropiado para cada atributo.*/

            //Consumo consumo = new Consumo(123,56,90,"Diesel");
            //Console.WriteLine($"El viaje ha durado: {consumo.GetTiempo()} horas");
            //Console.WriteLine($"El coche ha consumido una media de: {consumo.ConsumoMedio()} litros a los 100");


            //8.
            /*Modifica la clase Consumo para  indicar el tipo de combustible, y el precio de cada uno:
                Gasolina 95 :1.14 euros
                Gasolina 98: 1.25 euros
                Diesel: 1.04 euros
                Implementar los siguientes métodos:
                – ConsumoEuros. Consumo medio del vehículo (en euros cada 100 kilómetros).
                --MostrarDatos para que muestre toda la información :
 
        	    Kms realizados, litros consumidos, Velocidad media y tipo de combustible 
                Utiliza los atributos necesarios para definir el precio de los distintos combustibles. 
                Modifica los métodos y constructores de la clase para reflejar estos cambios */

            Consumo consumo = new Consumo(123, 56, 90, "Diesel");
            consumo.MostrarDatos();


        }
    }
}
