using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosObjetos
{
    class Coche_cs
    {
        private string marca;
        private string modelo;
        private string color;
        private int caballos;
        private int puertas;

        public Coche_cs(string marca, string modelo, string color, int caballos, int puertas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.caballos = caballos;
            this.puertas = puertas;

        }

        //Constructor vacio
        //public Coche_cs()
        //{

        //}

        //Constructor, puedes darle todos los parámetros ya o recibir los que quieras
        public Coche_cs()
        {
            marca = "Porche";
            modelo = "Carrera";
            color = "Rojo";
            caballos = 120;
            puertas = 4;
        }

        //Getters y Setters
        public string GetMarca()
        {
            return marca;
        }
        
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }
        public int GetCaballos()
        {
            return caballos;
        }

        public void SetCaballos(int caballos)
        {
            this.caballos = caballos;
        }
        public int GetPuertas()
        {
            return puertas;
        }

        public void SetPuertas(int puertas)
        {
            this.puertas = puertas;
        }

        //Comportamientos
        public void Arrancar()
        {
            Console.WriteLine($"El {marca} {modelo} ha arrancado.");
        }



    }
}
