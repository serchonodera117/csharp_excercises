using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Variables_y_Metodos_Static
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

            Punto destino = new Punto(x, y);

            Punto tres = new Punto();
            Punto cuatro = new Punto();

            double disancia = origen.distanciaPuntos(destino);

            Console.WriteLine($"punto de origen (X,Y) : {origen.getPuntosOrigen()} ");
            Console.WriteLine($"La distancia entre dos puntos es de : [{disancia}]");
            Console.ReadLine();

            Console.WriteLine($"Numero de objetos creados: [{Punto.ContadorObjetos()}]");

        }

        public static void ClasesAnonimas()
        {
            var miVariable = new { Nombre = "Serch", Nombre2 = "Onodera" };
            Console.Write($"Holamor {miVariable.Nombre} {miVariable.Nombre2}");

            /*
            para hacer una clase anonima, se declara una variable de tipo var, y se instancia [new {}]
            esto porque no tiene nombre, dentro de los parentesis SOLO se pueden declarar variables
            que estén iniciadas, las
            cuales no llevan el tipo de dato, y son publicas. 
            
            si se quiere declarar otra cariable que instancie la misma clase, se deben poner los mismos
            atributos, en el mismo orden, y tipo de datos que en la clase anterior.
             */
        
        }

    }
}
