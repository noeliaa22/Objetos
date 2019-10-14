using System;

namespace EjercicioRepaso4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4.- Crear una clase llamada Alarma que tiene como atributos (temperatura, timbre) 
             * y los métodos:
                Un constructor que recibe como argumento la temperatura y 
                pone el timbre en posición apagado.
                Un constructor que no tiene argumentos y que pide la temperatura por teclado
                y también pone el timbre a la posición de apagado.
                
            Un método llamado comprueba que pone el timbre a la posición encendido
                si la temperatura pasa de 35 grados o baja de 10 grados.
                
            Un método llamado normaliza que pone la temperatura a 25 grados y apaga el timbre.
            
            Desde el método principal main() declara objetos de tipo Alarma uno con argumentos 
            y otro sin argumentos, llama al método comprueba y si el timbre está encendido que 
            automáticamente llame a normaliza y se controle la situación */

            Alarma alarma = new Alarma();
            Alarma alarma2 = new Alarma(45,"Apagado");

            Console.WriteLine("Introduce una temperatura");
            alarma.Temperatura= Convert.ToDouble(Console.ReadLine());
            alarma.Timbre = "Apagado";

            alarma.Comprueba();
            if (alarma.Timbre=="Encendido")
            {
                alarma.Normaliza();
                Console.WriteLine($"La temperatura introducida no estaba entre 10 y 35 grados por lo que ha habido que normalizar");
            }
            else
            {
                Console.WriteLine("La temperatura está entre 10 y 35 grados por lo que no ha habido que normalizar");
            }

            Console.WriteLine("**************************************");

            alarma2.Comprueba();
            if (alarma2.Timbre == "Encendido")
            {
                alarma2.Normaliza();
                Console.WriteLine($"La temperatura dada no estaba entre 10 y 35 grados por lo que ha habido que normalizar");
            }
            else
            {
                Console.WriteLine("La temperatura está entre 10 y 35 grados por lo que no ha habido que normalizar");
            }



        }
    }
}
