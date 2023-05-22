using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marices_normales_dimensionales_escalonadas
{
    class Matriz_unidimensional
    {
        private int[] array;
        private Random aleatorio = new Random();
        public void matrizUnidimensional(int numeroUsuario)
        {
            array = new int[numeroUsuario];
            for(int i =0; i < array.Length; i++)
            {

                array[i] = aleatorio.Next(0, numeroUsuario) + 1;
                Console.WriteLine($"el numero [{i + 1}] es : {array[i]}");
            }
        }
    }

    class Matriz_multidimensional
    {
        private int[,] matrizDosDimensiones;
        Random Aleatorio = new Random();
        
        public void Matriz(int nLados)
        {
            int kuchau = nLados + 1;
            matrizDosDimensiones = new int[nLados, nLados];

            for (int i = 0; i < nLados; i++)
            {
                for (int j = 0; j < nLados; j++)
                {
                    matrizDosDimensiones[i, j] = Aleatorio.Next(0, kuchau);
                }

            }

            for (int i = 0; i < nLados; i++)
            {
                for (int j = 0; j < nLados; j++)
                {
                    Console.Write($"[{matrizDosDimensiones[i, j]}]");
                }
                Console.WriteLine();
            }
        }
    }
}
