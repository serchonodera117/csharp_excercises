using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Encapsulacion__y_conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //para vida de que no de error al tomar los atribbutos en los metodos, estos no deben llevar el ermino static. 
            //el elcapsulamiento, para vida de acceder desde afuera de una lcase al atributo/metodo, se le pone public antes,
            //y si no, se le pone private, para acceder si es que tiene private, se puede crear un metodo public eque puede 
            //ser accesible desde fuera, para cambiar e valor en una funcion del atribbuto.
            ConversorEuroDolar obj = new ConversorEuroDolar();
            obj.Cambio(2);


            Console.WriteLine($" {obj.Convercion(50)}");
            Console.ReadLine();
        }
    }

    class ConversorEuroDolar
    {
       private  double Euro = 1.253;

        public double Convercion(double cantidad) { return cantidad * Euro; }

        public void Cambio( double nuevoValor) 
        {
           
            if (nuevoValor < 0) { Euro = 1.253; }
            else  { Euro = nuevoValor; }
        }
    }
}
