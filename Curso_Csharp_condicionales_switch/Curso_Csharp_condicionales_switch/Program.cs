using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_condicionales_switch
{
    class Program
    {
        static void Main(string[] args)
        {

            //solo se puede hacer un switch con los tipos de dato string, int y char, el default se puede sustituir por un reutn o un throw
            //
            char suich;

            do
            {
                Console.Clear();
                Console.Write("INICIO: \nEscriba uno de los caracteres que se encuentran en los recuadros[]: \n\n1.- Opción [1] \n2.- Opción [2] \n3.- Opción [3]\nEscriba [s] para salir \n\n\n Escriba una opción: ");
                suich = Console.ReadKey().KeyChar;

                switch (suich)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("has escogido la opción 1: medios de transporte");
                        Primer_suich();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("has escogido la opción 2: meses del año");
                        Sergundo_suich();
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("has escogido la opción 3: numero random");
                        Tercer_suich();
                        break;
                    case 's':
                        Console.Clear();
                        Console.WriteLine("has seleccionado salir");
                        break;

                    case 'S':
                        Console.Clear();
                        Console.WriteLine("has seleccionado salir");
                        suich = 's';
                        break;

                    default: Console.Clear();
                        Console.WriteLine("Opción inexistente");
                        break;



                }

                Console.ReadKey();

            } while (suich != 's'); 

        }

        static void Primer_suich()
        {
            string medioTransporte;
            do
            {

                Console.Write("escoja su medio de transporte \n\n1.-coche \n2.-avión \n3.-tren \n4.-volver\n\n\nescriba el nombre tal cual se ve en las opciones: ");
                medioTransporte = Console.ReadLine();

                switch (medioTransporte)
                {
                    case "coche": Console.Clear(); Console.WriteLine("velocidad promedio del coche 100km/h"); break;
                    case "avion": Console.Clear(); Console.WriteLine("velocidad promedio del avión 900km/h"); break;
                    case "tren": Console.Clear(); Console.WriteLine("velocidad promedio del tren 150km/h"); break;
                    case "volver": Console.Clear(); Console.WriteLine("has seleccionado volver"); break;
                    default: Console.Clear(); Console.WriteLine("no existe esa opción"); break;

                }
                Console.ReadKey();

            } while (medioTransporte != "volver");
        }

        static void Sergundo_suich()
        {
            int mes;
            do
            {
                Console.Write("Escribe el numero del mes (escribe 13 si deseas volver): ");
                mes = int.Parse(Console.ReadLine());

                switch (mes)
                {
                    case 1: Console.Clear(); Console.WriteLine("Has escogido: Enero"); break;
                    case 2: Console.Clear(); Console.WriteLine("Has escogido: Febrero"); break;
                    case 3: Console.Clear(); Console.WriteLine("Has escogido: Marzo"); break;
                    case 4: Console.Clear(); Console.WriteLine("Has escogido: Abril"); break;
                    case 5: Console.Clear(); Console.WriteLine("Has escogido: Mayo"); break;
                    case 6: Console.Clear(); Console.WriteLine("Has escogido: Junio"); break;
                    case 7: Console.Clear(); Console.WriteLine("Has escogido: Julio"); break;
                    case 8: Console.Clear(); Console.WriteLine("Has escogido: Agosto"); break;
                    case 9: Console.Clear(); Console.WriteLine("Has escogido: Septiembre"); break;
                    case 10: Console.Clear(); Console.WriteLine("Has escogido: Octubre"); break;
                    case 11: Console.Clear(); Console.WriteLine("Has escogido: Noviembre"); break;
                    case 12: Console.Clear(); Console.WriteLine("Has escogido: Diciembre"); break;
                    case 13: Console.Clear(); Console.WriteLine("Has escogido: volver"); break;
                }


                Console.ReadKey();
            } while (mes != 13);


        }

        static void Tercer_suich()
        {
            Console.WriteLine("Se ha generado un numero Aleaorio enre los rangos de 0 a 100");
            int numero = new Random().Next(0, 100);

            int usuario;
            Console.WriteLine("de que numero se trata?");
            usuario = int.Parse(Console.ReadLine());

            int intentos = 0;
            while (numero !=usuario)
            {
                if (numero < usuario) { Console.WriteLine($"El numero random es menor que el numero {usuario}"); }
                else if (numero > usuario) { Console.WriteLine($"El numero random es mayor que el numero {usuario}"); }
                
                
                Console.Write("de que numero se trata?: ");
                usuario = int.Parse(Console.ReadLine());

                intentos++;

                Console.ReadKey();
            }

            Console.Write($"Flicidades, has terminado el bucle, el numero random es [{numero}], te ha tomado [{intentos + 1} intentos] ");

            Console.ReadLine();
        }
    }
}
