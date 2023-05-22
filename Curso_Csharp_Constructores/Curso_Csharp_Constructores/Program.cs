using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            char menu;
            do
            {
                Console.Clear();
                Console.Write("Inicio: \n constructores \nOpción [1] \nOpción [2] \nOpción [3] \nSalir [s] \n\n\n escribir opción seleccionada: ");
                menu = Console.ReadKey().KeyChar;

                switch (menu)
                {
                    case '1': Console.Clear();
                        Console.WriteLine("Opción [1]");
                        funciones.PrimerConstructor();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Opción [2]");
                        funciones.SegundoConstructor();
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("Opción [3]");
                        funciones.TercerConstructor();
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