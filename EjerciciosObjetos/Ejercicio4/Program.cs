using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea la clase peso, la cual tendrá las siguientes características:
            /*Deberá tener un atributo donde se almacene el peso de un objeto en kilogramos.
            En el constructor se le pasará el peso y la medida en la que se ha tomado(‘Lb’ para libras, ‘Li’ para lingotes,‘Oz’ para onzas, ‘P’ para peniques, ‘K’ para kilos, ‘G’ para gramos y ‘Q’ para quintales).
                Deberá de tener los siguientes métodos:
                
                GetLibras.Devuelve el peso en libras.
                GetLingotes.Devuelve el peso en lingotes.
                GetPeso.Devuelve el peso en la medida que se pase como parámetro
                (‘Lb’ para libras, ‘Li’ para lingotes,‘Oz’ para onzas, ‘P’ para peniques,
                ‘K’ para kilos, ‘G’ para gramos y ‘Q’ para quintales).


                Para la realización del ejercicio toma como referencia los siguientes datos:
                 1 Libra = 16 onzas = 453 gramos.
                1 Lingote = 32,17 libras = 14,59 kg.
                1 Onza = 0,0625 libras = 28,35 gramos.
                1 Penique = 0,05 onzas = 1,55 gramos.
                1 Quintal = 100 libras = 43,3 kg.
                Crea además un método main para testear y verificar los métodos de esta clase.*/


            Peso peso1 = new Peso(20, "li");
            Peso peso2 = new Peso(12, "q");
            Peso peso3 = new Peso(120, "g");
      
            Console.WriteLine($"{peso1.GetKilogramos()} kg son: {peso1.GetLibras()} libras");
            Console.WriteLine($"{peso2.GetKilogramos()} kg son: {peso2.GetLingotes()} lingotes");
            Console.WriteLine($"{peso3.GetKilogramos()} kg son: {peso3.GetPeso("oz")} onzas");
            Console.WriteLine(peso1.GetLingotes());

            //Console.WriteLine("Introduce tu peso en KG");
            //double pesoKg = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Introduce la medida a la que la quieras convertir \n" +
            //    "Lb: Libras \n Li: lingotes \n Oz: onzas \n P:peniques \n K: Kilos \n G: gramos \n Q: quintales");
            //string medida = Console.ReadLine().ToLower();

            //Peso peso = new Peso(pesoKg,medida);
            //peso.GetPeso(medida);

            //Console.WriteLine($"{pesoKg} Kg son {peso.GetPeso(medida)} {medida}");


        }
    }
}
