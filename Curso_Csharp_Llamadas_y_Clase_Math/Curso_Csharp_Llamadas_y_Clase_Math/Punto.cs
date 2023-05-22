using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Llamadas_y_Clase_Math
{
    class Punto
    {
        private double x, y;


        public Punto(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }

        public string getPuntosOrigen() { return $"Punto x = [{x}] \nPunto y = [{y}]"; }


        public double distanciaPuntos(Punto otroPunto)
        {
            double  diferenciaX = this.x - otroPunto.x;
             double diferenciaY = this.y - otroPunto.y;

            double diferenciaPuntos = Math.Sqrt(Math.Pow(diferenciaX,2) + Math.Pow(diferenciaY,2));


            return diferenciaPuntos ;
        }
    }
}
