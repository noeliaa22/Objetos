using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class Peso
    {
        private double kilogramos;
​
        public Peso(double peso, string medida)
        {
            switch (medida.ToLower())
            {
                case "lb":
                    kilogramos = peso * 0.453;
                    break;
                case "li":
                    kilogramos = peso * 14.59;
                    break;
                case "oz":
                    kilogramos = peso * 0.02835;
                    break;
                case "p":
                    kilogramos = peso * 0.00155;
                    break;
                case "k":
                    kilogramos = peso;
                    break;
                case "g":
                    kilogramos = (peso / 1000);
                    break;
                case "q":
                    kilogramos = peso * 43.3;
                    break;
                default:
                    Console.WriteLine("Medida incorrecta");
                    break;
            }​
       }
        public double GetKilogramos()
        {
            return kilogramos;
        }
        public void SetKilogramos(double kilogramos)
        {
            this.kilogramos = kilogramos;
        }
​
        public double GetLibras()
        {
            return kilogramos / 0.453;
        }​
        public double GetLingotes()
        {
            return kilogramos / 14.59;
        }
        public double GetPeso(string medida)
        {
            switch (medida.ToLower())
            {
                case "lb":
                    return kilogramos / 0.453;
                case "li":
                    return kilogramos / 14.59;
                case "oz":
                    return kilogramos / 0.02835;
                case "p":
                    return kilogramos / 0.00155;
                case "k":
                    return kilogramos;
                case "g":
                    return kilogramos * 1000;
                case "q":
                    return kilogramos / 43.3;
                default:
                    Console.WriteLine("Medida incorrecta");
                    return -1;
            }
        }

    }
}
