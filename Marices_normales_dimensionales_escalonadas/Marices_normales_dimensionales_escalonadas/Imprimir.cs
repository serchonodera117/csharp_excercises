using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marices_normales_dimensionales_escalonadas
{
    class Imprimir
    {
        public static void arrayNormal()
        {
            Matriz_unidimensional unaDimension = new Matriz_unidimensional();
            Console.Write("Escriba el tamaño del array : ");
            int t = int.Parse(Console.ReadLine());
            unaDimension.matrizUnidimensional(t);
        }   

        public static void MatrizM()
        {
            Matriz_multidimensional cola = new Matriz_multidimensional();
            Console.Write("Escriba el tamaño de la matriz : ");
            int t = int.Parse(Console.ReadLine());

            cola.Matriz(t);

        } 
    }
}
