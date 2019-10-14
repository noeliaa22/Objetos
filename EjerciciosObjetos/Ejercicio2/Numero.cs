using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    class Numero
    {
        private int numero;

        //Constructores (Tiene que tener el mismo nombre que la clase)
        public Numero()
        {
           //Un constructor vacio inicia el número a 0
           //Sino poner: numero=0
        }
        public Numero(int numero)
        {
            this.numero = numero;
        }

        //Getters
        //Método GetValor. Devuelve el valor interno. 
        public int GetValor()
        {
            return numero;
        }

        //Setters
        //Método SetNumero. Inicializa de nuevo el valor interno.
        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        //Métodos
        public void Anidade()
        {
            numero++;
        }
        public void Resta()
        {
            numero--;
        }

        
        //Método GetDoble. Devuelve el doble del valor interno.
        public int GetDoble()
        {
            return numero*2; //no establece el valor, solo lo devuelve
        }

        //Método GetTriple. Devuelve el triple del valor interno.
        public int GetTriple()
        {
            return numero*3;
        }

        



    }
}
