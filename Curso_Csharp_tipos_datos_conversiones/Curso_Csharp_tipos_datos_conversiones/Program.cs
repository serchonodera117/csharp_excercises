using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_tipos_datos_conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatura = 24.5;

            int temperaturaMadrid;


            /* Conversión explicita de datos, con esta conversión se pierde información*/
            temperaturaMadrid = (int)temperatura;

            // Console.WriteLine(temperaturaMadrid);



            //conversión implicita, funciona cuando los dos tipos de variables son compatibles, y la conversión se hace sin más
            int población = 100000000;
            long pipulation;
            pipulation = población;

            float peso = 1234.7F;
            double pesoD = peso;

            Console.WriteLine(  $" el peso de {peso} es igual a pesoD {pesoD} ");
            Console.ReadLine();

        }
    }
}
