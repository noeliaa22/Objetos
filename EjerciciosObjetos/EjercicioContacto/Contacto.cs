using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioContacto
{
    class Contacto
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }


        //Constructor para instanciar un contacto con todos los datos
        public Contacto(string nombre, int telefono, string fechaNacimiento)
        {
            Nombre = nombre;
            Telefono = telefono;
            FechaNacimiento = Convert.ToDateTime(fechaNacimiento);
        }

        //Constructor para instanciar un contacto con nombre y 
        //fecha de nacimiento(si la fecha no es correcta, pon la fecha actual).
        public Contacto(string nombre, string fechaNacimiento)
        {
            Nombre = nombre;
            DateTime fecha;
            

            if (DateTime.TryParse(fechaNacimiento, out fecha) && fecha.Year>1920&& fecha<DateTime.Today)
            {
            FechaNacimiento = fecha;
            }
            else
            {
                FechaNacimiento = DateTime.Today;
            }

        }

        //Constructor para instanciar un contacto con nombre y teléfono
        //(La fecha de nacimiento se inicializa con la actual).
        public Contacto(string nombre, int telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
            FechaNacimiento = DateTime.Now;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            if (Telefono==0)
            {
                Console.Write("");
            }
            else
            {
            Console.WriteLine($"Teléfono: {Telefono}");
            }
            Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento}");
        }
        //public int ObtenerEdad()
        //{
        //    int edad = (((TimeSpan)(DateTime.Now - FechaNacimiento)).Days)/365;
        //    return edad;
        //}
        //public void Felicitar()
        //{
        //    Console.WriteLine($"Felicidades {Nombre}, has cumplido {ObtenerEdad()} años!!!");
        //}



    }
}
