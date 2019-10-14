using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    class Coche
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }

        //prop  tab+tab y te sale


        //Atajo Constructores
        public Coche(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public Coche()
        {

        }
        public void Mostrar()
        {
            Console.WriteLine($"El coche es un {Marca} {Modelo} ");
            
        }
    }
}
