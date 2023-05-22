using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Colecciones
{
    class Imprimir
    {
        public static void ListaDeNumeros()
        {
            List<int> numeros = new List<int>();  //declaración de una coleción de tipo lista.

            //numeros.Add(6); //la forma de llenarse es esa, aunque también se puede llenar con un ciclo

            ;

            int[] numerosxd = new int[] { 1, 2, 3, 4, 5 };


            for(int i = 0; i<5;i++)
            {
                numeros.Add(numerosxd[i]);

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        public static void ListaModificable()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("cuantos helementos quiere en su lista");
            int numElementos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numElementos; i++)
            {
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\n los numeros que ingresó son: \n");

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        public static void ListaconFOREACH()
        {
            Console.WriteLine("Escriba numeros, para salir del ciclo escribir[0]: ");

            List<int> listaOwO = new List<int>();
            int listaContador = 1;
            int i = 0;
            while (listaContador != 0) 
            {
                i++;
                Console.Write($"numero [{i}]: ");
                listaContador = int.Parse(Console.ReadLine());
                listaOwO.Add(listaContador);
            };
            listaOwO.RemoveAt(listaOwO.Count - 1);

            foreach(int numero in listaOwO) 
            {
                Console.WriteLine(numero);
            }
        }
    }
}
