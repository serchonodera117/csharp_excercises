using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            char menu;

            do
            {
                Console.Clear();
                Console.Write("Inicio \n(Tema) \n\n1.- Opcion [1] \n2.- Opcion [2] \n3.- Opcion [3] \n4.- Opcion [4] \nPresiona [s] para salir \n\n\nEscribe la opción: ");
                menu = Console.ReadKey().KeyChar;

                switch (menu)
                {
                    case '1': //Herencia con consructores>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        Console.Clear();
                        Console.WriteLine(" Opción 1: ");
                        Objetos_Instancias.Herencia1();
                        Console.ReadLine();
                        break;


                    case '2': //Herencia Principio de sustitución.>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        Console.Clear();
                        Console.WriteLine(" Opción 2: ");
                        Objetos_Instancias.PrincipioDeSustitucion();
                        Console.ReadLine();
                        break;


                    case '3':  //Herencia y polimorfismo >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        Console.Clear();
                        Console.WriteLine(" Opción 3: ");

                        Console.ReadLine();
                        break;

                
                    case '4':  //Ejercicio practico       >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        Console.Clear();
                        Console.WriteLine(" Opción 4: ");
                        Objetos_Instancias.ejercicio();
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
