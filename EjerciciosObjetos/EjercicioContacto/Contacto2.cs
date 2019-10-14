using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioContacto
{
    class Contacto2
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoContacto { get; set; } //Familia,Amigos,Trabajo,Estudios
       

        //Constructor para instanciar un contacto con todos los datos
        public Contacto2(string nombre, int telefono, string fechaNacimiento, string tipoContacto)
        {
            Nombre = nombre;
            Telefono = telefono;
            FechaNacimiento = Convert.ToDateTime(fechaNacimiento);
            switch (tipoContacto.ToLower())
            {
                case "familia":
                    TipoContacto = "Familia";
                    break;
                case "amigos":
                    TipoContacto = "Amigos";
                    break;
                case "trabajo":
                    TipoContacto = "Trabajo";
                    break;
                case "estudios":
                    TipoContacto = "Estudios";
                    break;
                default:
                    Console.WriteLine("El tipo introducido no es correcto, se le asignará a la categoria amigos.");
                    TipoContacto = "Amigos";
                    break;
            }           
        }

        //Constructor para instanciar un contacto con nombre y 
        //fecha de nacimiento(si la fecha no es correcta, pon la fecha actual).
        public Contacto2(string nombre, string fechaNacimiento, string tipoContacto)
        {
            Nombre = nombre;
            DateTime fecha;

            if (DateTime.TryParse(fechaNacimiento, out fecha))
            {
                FechaNacimiento = fecha;
            }
            else
            {
                FechaNacimiento = DateTime.Today;
            }
            switch (tipoContacto.ToLower())
            {
                case "familia":
                    TipoContacto = "Familia";
                    break;
                case "amigos":
                    TipoContacto = "Amigos";
                    break;
                case "trabajo":
                    TipoContacto = "Trabajo";
                    break;
                case "estudios":
                    TipoContacto = "Estudios";
                    break;
                default:
                    Console.WriteLine("El tipo introducido no es correcto, se le asignará a la categoria amigos.");
                    TipoContacto = "Amigos";
                    break;
            }

            }

        //Constructor para instanciar un contacto con nombre y teléfono
        //(La fecha de nacimiento se inicializa con la actual).
        public Contacto2(string nombre, int telefono, string tipoContacto)
        {
            Nombre = nombre;
            Telefono = telefono;
            FechaNacimiento = DateTime.Now;
            TipoContacto = "Amigos";
            switch (tipoContacto.ToLower())
            {
                case "familia":
                    TipoContacto = "Familia";
                    break;
                case "amigos":
                    TipoContacto = "Amigos";
                    break;
                case "trabajo":
                    TipoContacto = "Trabajo";
                    break;
                case "estudios":
                    TipoContacto = "Estudios";
                    break;
                default:
                    Console.WriteLine("El tipo introducido no es correcto, se le asignará a la categoria amigos.");
                    TipoContacto = "Amigos";
                    break;
            }
            }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            if (Telefono == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Teléfono: {Telefono}");
            }
            Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento}");
            //Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento}");
            Console.WriteLine($"Tipo contacto: {TipoContacto}");
        }
    }
}
