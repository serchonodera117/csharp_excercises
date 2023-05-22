using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Llamadas_y_Clase_Math
{
    class imprimir
    {
      public static void relizarTarea()
        {
            double x, y;
            Punto origen = new Punto();

            Console.Write("escribe la coordenada x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("escribe la coordenada y: ");
            y = double.Parse(Console.ReadLine());

            Punto destino = new Punto(x , y);

            double disancia = origen.distanciaPuntos(destino);

            Console.WriteLine( $"punto de origen : \n {origen.getPuntosOrigen()} ");
            Console.WriteLine($"La distancia entre dos puntos es de : [{disancia}]");


        }
    }
}
