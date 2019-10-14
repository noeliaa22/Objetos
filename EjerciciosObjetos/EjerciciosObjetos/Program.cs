using System;

namespace EjerciciosObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //instaciar una clase
            Coche_cs coche = new Coche_cs("Renault","Laguna","Negro",120,5);
            Coche_cs coche2 = new Coche_cs();

            coche2.SetMarca("Ferrari");
            Console.WriteLine(coche2.GetMarca());
            coche2.Arrancar();
        }
    }
}
