using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Variables_y_Metodos_Static
{
    partial class Punto           //<<<<<<<<<<<<<<<< Variables y constructores >>>>>>>>>>>>>>>>>
    {
        private double x, y;
        private static int contadorObjetos = 0;

        public Punto(double x, double y)
        {
            this.x = x;
            this.y = y;
            contadorObjetos++;
        }

        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorObjetos++;
        }

    }

    partial class Punto      //<<<<<<<<<<<<<<<<<<<< Metodos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    { 

        public string getPuntosOrigen() { return $"[{x},{y}]"; }


        public double distanciaPuntos(Punto otroPunto)
        {
                      double diferenciaX = this.x - otroPunto.x;
                      double diferenciaY = this.y - otroPunto.y;
                      double diferenciaPuntos = Math.Sqrt(Math.Pow(diferenciaX, 2) + Math.Pow(diferenciaY, 2));
            
            return diferenciaPuntos;
        }

        public static int ContadorObjetos() { return contadorObjetos; }
    }
}
         /* Los metodos y variables de tipo static funcionan como constantes, son hehcos de tal forma
            en la que estos no se pueden modificar, ni utilizarse en un objeto, solo pueden ser llamados
            como un metodo/funcion normal, anteponiendo el nombre de la clase 
            ejemplo : Clase.Metodo();*/