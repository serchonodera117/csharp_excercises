using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Cshap_Clases_e_Insancias
{
    class Circulo
    {
       const double pi = 3.1416; //Propiedad de la clase circulo. campo de clase

        public double calculoArea(int radio) { return pi * radio * radio; } //Metodo de clase. ¿Qué pueden hacer los objetos de tipo circulo?
    }

    class Esfera
    {
        const double pi = 3.14;

        public double calculoVolumen(int radio) {

            float tresCuartos = 3/4f;

            double calculo = tresCuartos * pi * radio * radio * radio;

            return calculo; 
        }
    }

    class Cuenta
    {
        public string Nombre = "Nombre";
        public int saldo = 5000;

        public float Retiro(float cantidad) { return saldo - cantidad; }

        public float Ingreso(float cantidad) { return saldo + cantidad; }
           
    }

    class Dado
    {
        public int lado;

        public  int  Lanzamiento_1(int cara1) {return cara1 = new Random().Next(1, 7); }
        public int Lanzamiento_2(int cara2)
        {
            cara2 = new Random().Next(0, 4);
            int nueva = new Random().Next(1, 4);
            int aleatorio = nueva + cara2;
            return aleatorio;
        }
        
        
        public int Lanzamiento_3(int cara3)
        {
            int al_1 = new Random().Next(0,3);
            int al_2 = new Random().Next(0, 3);
            cara3 = new Random().Next(1, 3);
            int aleatorio = al_1 + al_2 + cara3;
            return aleatorio;

        }

    }


}
