using System;
using System.Collections.Generic;
using System.Linq;//importar esta librería 
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_LINQ_1
{
    class Program
    {

        // en este ejercicio se puso en practica un nuevo tema "Linq". 
        // sirve para obtener información deseada de un origen de datos
        // en este caso, se trabajó con un array, en el se buscan los numeros
        // pares, de forma tradicional sería con ciclos y condicionales.


        static void Main(string[] args)
        {
            int[] valoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Numeros pares: ");

            //este linq actúa con IWnumerable, obtiene datos de forma similar al 
            //codigo sql
            //lectura técnica: "de numero (es variable) en valoresnumericos, donde la
            //                  la división sintetica  de numero entre dos, es igual a 0
            //                  selecciona numero."

            //sintaxis                          //operación/sentencia/instrucción
            IEnumerable<int> numerosPares = from numero in valoresNumericos where numero % 2 == 0 select numero;

            foreach (int i in numerosPares)
            {
                Console.WriteLine(i);
            }



            Console.ReadKey();
        }
    }
}
