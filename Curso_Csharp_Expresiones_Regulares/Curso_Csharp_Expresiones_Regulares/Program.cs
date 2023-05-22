using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Expresiones_Regulares
{
    class Program
    {
        static void Main(string[] args)
        {
            char menu;

            do
            {
                Console.Clear();
                Console.Write("Inicio \nExpresiones Regulares \n\n1.- Opcion [1] Regulares 1 \n2.- Opcion [2] Regulares 2 \nPresiona [s] para salir \n\n\nEscribe la opción: ");
                menu = Console.ReadKey().KeyChar;

                switch (menu)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine(" Opción 1: ");
                        Menus.Opción1();
                        Console.ReadLine();
                        break;


                    case '2':
                        Console.Clear();
                        Console.WriteLine(" Opción 2: ");
                        Menus.opcion2();
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


    class Menus
    {
        public static void Opción1()
        {
            char menu;

            do
            {
                Console.Clear();
                Console.Write("Regulares 1: \n\n1.- Opcion [1]  \n2.- Opcion [2] \nPresiona [s] para volver \n\n\nEscribe la opción: ");
                menu = Console.ReadKey().KeyChar;

                switch (menu)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine(" Opción 1: ");
                        Regulares.uno();

                        break;


                    case '2':
                        Console.Clear();
                        Console.WriteLine(" Opción 2: ");

                        Regulares.dos();
                        break;

                    case 's':
                        Console.Clear();
                        Console.WriteLine(" Has seleccionado volver (U ,w, U ) ");

                      
                        break;

                    case 'S':
                        Console.Clear();
                        if (menu == 'S')
                        {
                            menu = 's';
                            Console.WriteLine(" Has seleccionado volver (U ,w, U ) ");
                        }

                       
                        break;

                    default:
                        Console.Clear(); Console.WriteLine("La opción que has pueasto no existe =(");
                        break;
                }
                Console.ReadKey();
            } while (menu != 's');
        }


        public static void opcion2()
        {

            char menu;

            do
            {
                Console.Clear();
                Console.Write("Regulares 2: \n\n1.- Opcion [1]  \n2.- Opcion [2] \nPresiona [s] para volver \n\n\nEscribe la opción: ");
                menu = Console.ReadKey().KeyChar;

                switch (menu)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine(" Opción 1: ");
                        Regulares.unoB();

                        break;


                    case '2':
                        Console.Clear();
                        Console.WriteLine(" Opción 2: ");
                        Regulares.dosB();
                        
                        break;

                    case 's':
                        Console.Clear();
                        Console.WriteLine(" Has seleccionado volver (U ,w, U ) ");


                        break;

                    case 'S':
                        Console.Clear();
                        if (menu == 'S')
                        {
                            menu = 's';
                            Console.WriteLine(" Has seleccionado volver (U ,w, U ) ");
                        }


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
