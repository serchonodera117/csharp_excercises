using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cueso_Csharp_Metodos_con_return
{
    class Program
    {
        static void Main(string[] args)
        {
            char detenerse;
            int num1, num2;

            do
            {
                Console.Clear();
                Console.Write("Presiona [s] para salir \n\n 1.- suma de dos numeros \n2.- división de dos numeros \n\n\nEscribe el numero :");
                detenerse = Console.ReadKey().KeyChar;

                switch (detenerse) {

                    case '1':
                        Console.Clear();
                        Console.WriteLine("primer metodo con return: Suma de dos Numeros");

                        Console.Write("escribe el numero 1: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("escribe el numero 2: ");
                        num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"La suma de los numeros [{num1}] y [{num2}] es: {sumaNumeros(num1, num2)}");

                        break;

                    case '2': Console.Clear();
                        Console.WriteLine("Segundo Metodo con retun, División de dos números");

                        Console.Write("escribe el numero: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("escribe el divisor: ");
                        num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"el resultado de la división [{num1}/{num2}] es: {divisiónNUmeros(num1, num2)}");
                        break;



                    case 's':
                        Console.Clear();
                        Console.WriteLine("Haz Seleccionado Salir");
                        break;

                  

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción invalida");
                        break;

                }


                Console.ReadKey();

            } while (detenerse != 's' );


        }




        static int sumaNumeros(int uno, int dos)
        {
            return uno + dos;
        }

        static double divisiónNUmeros(double uno, double dos)=> uno / dos;
        
    
    }
}
