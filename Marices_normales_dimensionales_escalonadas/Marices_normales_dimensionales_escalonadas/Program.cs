using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marices_normales_dimensionales_escalonadas
{
    class Program
    {
        static void Main(string[] args)
        {
            char menu;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu de matrices: \n\n1.- Matriz unidimencional \n2.- Matriz multidimensional\n3.- Matriz escalonada \n\n\nPara salir presione [s]");
                menu = Console.ReadKey().KeyChar;
                switch (menu) 
                {
                    case '1': Console.Clear();
                        Console.WriteLine("Matriz unidimensional:");
                        Imprimir.arrayNormal();
                        break;

                    case '2':
                        Console.Clear();
                        Console.WriteLine("Matriz multidimensional:");
                        Imprimir.MatrizM();
                        break;

                    case '3':
                        Console.Clear();
                        Console.WriteLine("Matriz escalonada:");

                        break;

                    case 's':
                        Console.Clear();
                        Console.WriteLine("has seleccionado salir");

                        break;

                    default: Console.Clear();
                        Console.WriteLine("Opción invalida");
                        break;
                }

                Console.ReadKey();

            } while (menu != 's');
        }
    }
}
