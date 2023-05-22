using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Arrays_For_Y_parametro
{
    class Program
    {
        static void Main(string[] args)
        {
            char menu;

            do
            {
                Console.Clear();
                Console.Write("Inicio \nArrays \n\n1.- Opcion [1] \n2.- Opcion [2] \n3.- Opcion [3] \n4.- Opcion [4] \n5.-Opcion [5] \nPresiona [s] para salir \n\n\nEscribe la opción: ");
                menu = Console.ReadKey().KeyChar;

                switch (menu)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine(" Opción 1: ");
                        imprimir.PrimerCicloFor();
                        Console.ReadLine();
                        break;


                    case '2':
                        Console.Clear();
                        Console.WriteLine(" Opción 2: ");
                        imprimir.imprimirObjetos();
                        Console.ReadLine();
                        break;


                    case '3':
                        Console.Clear();
                        Console.WriteLine(" Opción 3: ");
                        imprimir.Imprimirobjetos_foreach();
                        Console.ReadLine();
                        break;

                    case '4':
                        Console.Clear();
                        Console.WriteLine(" Opción 4: ");
                        imprimir.PrimerArrayParametos();
                        Console.ReadLine();
                        break;

                    case '5':
                        Console.Clear();
                        Console.WriteLine(" Opción 5: ");
                        imprimir.ArrayConReturn();
                        Console.ReadLine();
                        break;


                    case 's':
                        Console.Clear();
                        Console.WriteLine(" Has seleccionado salir (U ,w, U ) ");

                        Console.ReadLine();
                        break;

                    case 'S':
                        Console.Clear();
                        if (menu == 'S')
                        {
                            menu = 's';
                            Console.WriteLine(" Has seleccionado salir (U ,w, U ) ");
                        }

                        Console.ReadLine();
                        break;

                    default:
                        Console.Clear(); Console.WriteLine("La opción que has pueasto no existe =(");
                        break;
                }
                Console.ReadKey();
            } while (menu != 's');

        }
    }
}
