using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Colecciones_2
{
    class Program
    {
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<LinkedList>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


        static void Main(string[] args)
        {
            char menu;

            LinkedList<int> numerosEnteros = new LinkedList<int>();

            foreach (int numeros in new int[] { 10, 8, 7, 6, 5, 5, 4, 4 })
            {

                numerosEnteros.AddFirst(numeros);   //lo que hace este metodo es añadr de forma creciente 
            }


            do {
                
                foreach (int numeros in numerosEnteros)
                {
                    Console.WriteLine(numeros);
                }

                Console.Write("\nescriba I para iniciar o [s] para salir : ");
                menu = Console.ReadKey().KeyChar;

                try
                {
                    Console.Write("\n¿que numero desea eliminar? : ");
                    int borrar = int.Parse(Console.ReadLine());
                    Console.WriteLine($"se ha eliminado el numero [{borrar}]");
                    Console.ReadLine();
                    numerosEnteros.Remove(borrar);
                   
                }
                catch (Exception e) { Console.WriteLine(e.Message); }

                Console.Clear();

            } while (menu !='s');


            Console.ReadKey();
        }
    }
}
