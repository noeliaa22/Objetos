using System;
using System.Collections.Generic; //IMPORTANTE
using System.Linq; //Para usar el Element At

namespace EjercicioContacto
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //3.
            Contacto2 usuario1 = new Contacto2("Miren",944123456,"04/02/1990","Amigos");
            Contacto2 usuario2 = new Contacto2("Jon",931212123,"Trabajo");
            Contacto2 usuario3 = new Contacto2("Ane","05/05/1995","Trabajo");
            Contacto2 usuario4 = new Contacto2("Julen",944123321,"04/02/1992","Estudios");
            Contacto2 usuario5 = new Contacto2("Jone","06/06/1992","");
            Contacto2 usuario6 = new Contacto2("Mikel","07/07/1997","Familia");
        

            CFecha fecha = new CFecha(DateTime.Today);

            //4, 5, 6.
            usuario1.MostrarDatos();
            fecha.Fecha = usuario1.FechaNacimiento;
            Console.WriteLine($"\n{usuario1.Nombre} tiene {fecha.ObtenerEdad()} años\n");
            if (usuario1.FechaNacimiento.Month==DateTime.Today.Month && usuario1.FechaNacimiento.Day == DateTime.Today.Day)
            {
                fecha.Felicitar();
            }
            else
            {
                Console.WriteLine("Hoy no es tu cumple");
            }
            Console.WriteLine("\n\n");

            usuario2.MostrarDatos();
            fecha.Fecha = usuario2.FechaNacimiento;
            Console.WriteLine($"\n{usuario2.Nombre} tiene {fecha.ObtenerEdad()} años\n");
            if (usuario2.FechaNacimiento.Month == DateTime.Today.Month && usuario2.FechaNacimiento.Day == DateTime.Today.Day)
            {
                fecha.Felicitar();
            }
            else
            {
                Console.WriteLine("Hoy no es tu cumple");
            }
            Console.WriteLine("\n\n");

            usuario3.MostrarDatos();
            fecha.Fecha = usuario3.FechaNacimiento;
            Console.WriteLine($"\n{usuario3.Nombre} tiene {fecha.ObtenerEdad()} años\n");
            if (usuario3.FechaNacimiento.Month == DateTime.Today.Month && usuario3.FechaNacimiento.Day == DateTime.Today.Day)
            {
                fecha.Felicitar();
            }
            else
            {
                Console.WriteLine("Hoy no es tu cumple");
            }
            Console.WriteLine("\n\n");

            usuario4.MostrarDatos();
            fecha.Fecha = usuario4.FechaNacimiento;
            Console.WriteLine($"\n{usuario4.Nombre} tiene {fecha.ObtenerEdad()} años\n");
            if (usuario4.FechaNacimiento.Month == DateTime.Today.Month && usuario4.FechaNacimiento.Day == DateTime.Today.Day)
            {
                fecha.Felicitar();
            }
            else
            {
                Console.WriteLine("Hoy no es tu cumple");
            }
            Console.WriteLine("\n\n");

            usuario5.MostrarDatos();
            fecha.Fecha = usuario5.FechaNacimiento;
            Console.WriteLine($"\n{usuario5.Nombre} tiene {fecha.ObtenerEdad()} años\n");
            if (usuario5.FechaNacimiento.Month == DateTime.Today.Month && usuario5.FechaNacimiento.Day == DateTime.Today.Day)
            {
                fecha.Felicitar();
            }
            else
            {
                Console.WriteLine("Hoy no es tu cumple");
            }
            Console.WriteLine("\n\n");

            usuario6.MostrarDatos();
            fecha.Fecha = usuario1.FechaNacimiento;
            Console.WriteLine($"\n{usuario1.Nombre} tiene {fecha.ObtenerEdad()} años\n");
            if (usuario6.FechaNacimiento.Month == DateTime.Today.Month && usuario6.FechaNacimiento.Day == DateTime.Today.Day)
            {
                fecha.Felicitar();
            }
            else
            {
                Console.WriteLine("Hoy no es tu cumple");
            }
            Console.WriteLine("\n\n");

            //Mostrar clase CFecha
            fecha.MostrarFecha();





            //EJERCICIOS LISTAS
            List<Contacto2> contactos = new List<Contacto2>()
            {
               usuario1,usuario2,usuario3,usuario4,usuario5,usuario6
            };

            Console.WriteLine($"\n\n\nSe han añadido {contactos.Count} contactos a la agenda");


            int sumaAmigos = 0;
            int sumaFamilia = 0;
            int sumaTrabajo = 0;
            int sumaEstudios = 0;


            for (int i = 0; i < contactos.Count; i++)
            {
                string tipoContacto = contactos[i].TipoContacto;
                switch (tipoContacto)
                {
                    case "Amigos":
                        sumaAmigos++;
                        break;
                    case "Familia":
                        sumaFamilia++;
                        break;
                    case "Trabajo":
                        sumaTrabajo++;
                        break;
                    case "Estudios":
                        sumaEstudios++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Se han añadido {sumaAmigos} contactos como amigos");
            Console.WriteLine($"Se han añadido {sumaTrabajo} contactos como trabajo");
            Console.WriteLine($"Se han añadido {sumaFamilia} contactos como familia");
            Console.WriteLine($"Se han añadido {sumaEstudios} contactos como estudios");


            /*OTRA MANERA DE HACERLO
             * 
             * foreach(Contacto2 contact in contactos)
             * {
             * switch(contact.TipoContacto)
             * {
             * case "Familia":
             * sumaFamilia++;
             * break;
             * .
             * .
             * .
             * default:
             * sumaEstudios++;
             * break;
             * 
             *    Desde el bucle llamar al método MostrarDatos
             * MostrarDatos();
             * 
             * 
             * }
             * }
             * 
             * 
             * 
             * 
             * 
             */


        }

    }
}
