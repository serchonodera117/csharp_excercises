using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Colecciones_3_Colas
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> Numeros = new Queue<int>();

            //relleno o agregado de la cola

            foreach(int numero in new int[5] { 2, 4, 6, 8, 0 })
            {
                Numeros.Enqueue(numero);
                    //Queue quita o devuelve el valor del ojeto. mientras que Enqueue añadade un objetp al final de Queue<t>
            }

            Console.WriteLine("Recorriendo el Queue");

            foreach(int numero in Numeros)
            {
                Console.WriteLine(numero);
            }

            //Eliminando Elementos
            Console.WriteLine("\nEliminando elementos");                //El primer dato que se elimina con eta instrucción
            Numeros.Dequeue();                                          //Es el primer dato en entrar, por ejemplo, el primer  
            foreach (int numero in Numeros)                             //Dato guardado em el array del primer foreach
            {
                Console.WriteLine(numero);
            }


            Console.ReadKey();
        }
    }
}
