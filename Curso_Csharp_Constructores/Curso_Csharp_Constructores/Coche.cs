using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Constructores
{
    class Coche
    {
        public Coche() //el constructor es una funcion que no debuelve nada y tampoco es de tipo void, esta gerneralmente es del mismo tipo que la clase.
        {
            ruedas = 4;

            largo = 2.5;

            ancho = 0.800;
        }
        public Coche(double anchocoche, double largocoche) // se puede utilizar la sobrecarga para poder utilizar el mismo destructor con distintos parametos varias veces.
        {
            ruedas = 4;
            largo = largocoche;
            ancho = anchocoche;
        
        }

        public string InfoCoche() { return $"información del coche: \n [{ruedas} ruedas], \n[{largo}]M de largo], \n[{ancho}M de ancho]"; }


        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private string tapete;

    }


    class Helado
    {

        public Helado()
        {
            sabor = "Vainilla";
            temperatura = -4.7f;
            baseCono = "Vaso, Cono, Barquillo";

        }

        public Helado(string saborCliente, string conoCliente)
        {
            temperatura = -4.7f;
            sabor = saborCliente;
            baseCono = conoCliente;
        }

        string sabor;

        float temperatura;

        string baseCono;

        public string  HeladoMuestra(){ return $"sabor [{sabor}] \nTemperatura [{temperatura}°C]\nBase [{baseCono}]\n\n"; }

    }


    class Sueldos
    {
        private double [] sueldo;

       public  Sueldos()
        {
            sueldo = new double[5];
              for (int i = 0; i < 5; i++)
              {
                Console.WriteLine($"Escribe el salario [{i + 1}] : ");
                string info = Console.ReadLine();
                sueldo[i] = double.Parse(info);
              } 
        }
        
        public void Imprimimr()
        {
            Console.WriteLine("Los sueldos que usted ha ingresado son: ");
            for (int i = 0; i < sueldo.Length; i++) 
            {
                Console.WriteLine($"Suedo [{i + 1}] es: [{sueldo[i]}]");

            }
        }

    }
}
