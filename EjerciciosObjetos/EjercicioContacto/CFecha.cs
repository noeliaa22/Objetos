using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioContacto
{
    class CFecha
    {
        public DateTime Fecha { get; set; }

        public CFecha(DateTime fecha)
        {
            Fecha = fecha;
        }

        public int DevolverDia()
        {
            return Fecha.Day;
            //string fecha= Convert.ToString(FechaNacimiento);
            //int dia= Convert.ToInt32(fecha.Substring(0,2));
            //return dia;
        }
        public int DevolverMes()
        {
            return Fecha.Month;
            //string fecha = Convert.ToString(FechaNacimiento);
            //int mes = Convert.ToInt32(fecha.Substring(3, 2));
            //return mes;
        }
        public int DevolverYear()
        {
            return Fecha.Year;
            //string fecha = Convert.ToString(FechaNacimiento);
            //int year = Convert.ToInt32(fecha.Substring(6,4));
            //return year;
        }
        public int ObtenerEdad()
        {
            TimeSpan timeSpan = DateTime.Now - Fecha;
            return timeSpan.Days / 365;
        }
        public void MostrarFecha()
        {
            Console.WriteLine($"{Fecha}: \nAño: {DevolverYear()}\nMes: {DevolverMes()}\nDia:{DevolverDia()}");
        }
        public void Felicitar()
        {
            Console.WriteLine($"Felicidades hoy cumples {ObtenerEdad()} años!!!");
        }


    }


}
