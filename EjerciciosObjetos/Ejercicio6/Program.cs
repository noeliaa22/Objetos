using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea la clase coche con dos constructores. Uno no toma parámetros y el otro sí. 
             * Los dos constructores inicializarán los atributos marca y modelo de la clase.
             * 
             * Implementa métodos para obtener y establecer el valor de los atributos, 
             * así como un método para mostrar toda la información.
             * 
             * Crea dos objetos (cada objeto llama a un constructor distinto) 
             * y verifica que todo funciona correctamente. */
            // d1.Millas == d1.GetMillas()
            //Para utilizar el set: d1.Millas=5000 y te cambia el valor del atributo millas

            Coche coche1 = new Coche();
            Coche coche2 = new Coche("Seat","Ibiza");

            coche1.Marca="Ford"; // coche1.SetMarca()
            coche1.Modelo = "Fiesta";

            coche1.Mostrar();
            coche2.Mostrar();

            



        }
    }
}
