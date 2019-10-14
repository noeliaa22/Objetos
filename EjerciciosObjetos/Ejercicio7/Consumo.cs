using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    class Consumo
    {
        public double Kms { get; set; } //Kilómetros recorridos por el coche.
        public double Litros { get; set; } //Litros de combustible consumido.
        public double Vmed { get; set; } //Velocidad media. (KM/h)
        public string TipoCombustible { get; set; } //tipo de combustible

        public double Gasolina95 { get; set; }
        public double Gasolina98 { get; set; }
        public double Diesel { get; set; }

        public Consumo(double kms, double litros, double vmed, string tipoCombustible, double gasolina95, double gasolina98, double diesel)
        {
            Kms = kms;
            Litros = litros;
            Vmed = vmed;
            TipoCombustible = tipoCombustible;
            Gasolina95 = 1.14;
            Gasolina98 = 1.25;
            Diesel = 1.04;
        }

        public Consumo(double kms, double litros, double vmed, string tipoCombustible)
        {
            Kms = kms;
            Litros = litros;
            Vmed = vmed;
            TipoCombustible = tipoCombustible;
        }

        public string GetTiempo()
        {
            double horas = Kms / Vmed;
            int segundos = Convert.ToInt32(horas * 3600);
            int h = segundos / 3600;
            int m = (segundos % 3600) / 60;
            int s = (segundos % 3600) % 60;
            return $"{h} h {m} m {s} s";

        }
        public double ConsumoMedio()
        {
            return (Litros * 100) / Kms;
        }
        public double ConsumoEuros(string tipoCombustible) //EJ: 8
        {
            this.TipoCombustible = tipoCombustible;
            switch (tipoCombustible.ToLower())
            {
                case "gasolina95":
                    return ConsumoMedio()*Gasolina95;
                case "gasolina98":
                    return ConsumoMedio()*Gasolina98;
                case "diesel":
                    return ConsumoMedio()*Diesel;
                default:
                    return -1;
            }

        }
        public void MostrarDatos() //EJ: 8
        {
            Console.WriteLine($"Un coche con combustible {TipoCombustible} ha recorrido {Kms} kilometros \na una velocidad media de {Vmed} km/h," +
                $"consumiendo en total {Litros} litros.");
            Console.WriteLine($"\n\nEl viaje ha durado {GetTiempo()} horas,\nha consumido una media de" +
                $" {ConsumoMedio()} litros a los 100\n suponiendo un coste medio de {ConsumoEuros(TipoCombustible)} euros por cada 100 litros.");
        }

}
}
