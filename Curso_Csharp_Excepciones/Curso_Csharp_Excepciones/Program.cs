using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
              try{ aqui va la linea de codigo que da o que puede dar un error }
                catch(FormatException ){ aqui la atrapa y se le puede dar una solucion} (cuando es error de formato)
                catch(OverflowException ){codigo a ejecutar } (cuando es error de limite de caracteres)
                catch (Exception) { codigo a jecutar } (salida a un error generico, error cualquiera, pero no te especificará el tipo de error)

            catch ((cualquier formato de excepcion) ex o e) {codigo a ejecutar } (la variable se puede utilizar para enviar un mensaje automatico del tipo de error)



             */
            char inicio;

            do
            {
                Console.Clear();
                Console.Write("INICIO \nExcepciones: \n\n1.- Excepciones 1  \n2.- Excepciones 2 \n3.- Excepciones 3 \n4.- Excepciones 4 \n5.- Excepciones 5 \nEscribe [s] para salir\n\n\n Escribe el numero:");
                inicio = Console.ReadKey().KeyChar;

                switch (inicio)
                {
                    case '1': Console.Clear();
                        Console.WriteLine("excepion 1:  ");
                        Excepcion1();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("excepion 2:  ");
                        excepcion2();
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("Usochecked:  ");
                        Usocheked();
                        break;

                    case '4':
                        Console.Clear();
                        Console.WriteLine("Excepcion 4:  ");
                        Console.Write("Escribe un numero de mes del año");
                     
                        try
                        {
                            int numMes = int.Parse(Console.ReadLine());
                            Console.WriteLine($"el mes es {LanzamientoExcepciones(numMes)}");
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine($"Mensaje de la excepción [{e}]");
                        }
                        Console.ReadLine();
                        break;

                    case '5':
                        Console.Clear();
                        Console.WriteLine("Excepcion 5 (Finall):  ");
                        Finally();

                        Console.ReadLine();
                        break;
                    case 's':
                        Console.Clear();
                        Console.WriteLine(" Has seleccionado salir ");
                        break;
                }

            } while (inicio != 's');
        }


        static void Excepcion1()
        {
            int numeroRandom = new Random().Next(0, 100);
            int numeroUsuario;
            int intentos = 0;
            Console.WriteLine("se ha generado un numero random ");


            do
            {
                intentos++;

                Console.Write("que numero es?: ");


                try
                {
                    numeroUsuario = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {

                    Console.WriteLine("Has intoducido caracteres invalidos, este programa SOLO acepta numeros, se tomará el valor como [0]");
                    numeroUsuario = 0;
                }
                catch (OverflowException) 
                {
                    Console.WriteLine("Has intoducido un valor tan grande, que se sale de los limites, se tomará el valor como [0]");
                    numeroUsuario = 0;
                }

                if (numeroRandom > numeroUsuario) { Console.WriteLine($"El numero random es mas grande que el [{numeroUsuario}]"); }
                else if (numeroRandom < numeroUsuario) { Console.WriteLine($"El numero random es mas pequeño que el [{numeroUsuario}]"); }

            } while (numeroUsuario != numeroRandom);

            Console.WriteLine($"Felicidades, has acertado, el numero random es el [{numeroRandom}], te ha tomado [{intentos } intentos]");
            Console.ReadLine();
        }

        static void excepcion2()
        {
            int numeroRandom = new Random().Next(0, 100);
            int numeroUsuario;
            int intentos = 0;
            Console.WriteLine("se ha generado un numero random ");


            do
            {
                intentos++;

                Console.Write("que numero es?: ");


                try
                {
                    numeroUsuario = Int32.Parse(Console.ReadLine());
                }
                //exception abarca todo, si quieres pulirlo, utiliza primero los exception especificos, y despues el general
                // se puede utilizar la sintaxis when (e.GetType() != typeof(FormatException)), para admitir todas la excepciones dentro, menos la que quieras especificar
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {

                    Console.WriteLine("Has intoducido caracteres invalidos, este programa SOLO acepta numeros, se tomará el valor como [0]");
                    Console.WriteLine(e.Message);
                    numeroUsuario = 0;
                }
                 catch (FormatException)
                {

                    Console.WriteLine("Has intoducido caracteres invalidos, este programa SOLO acepta numeros, se tomará el valor como [0]");
                    numeroUsuario = 0;
                }


                if (numeroRandom > numeroUsuario) { Console.WriteLine($"El numero random es mas grande que el [{numeroUsuario}]"); }
                else if (numeroRandom < numeroUsuario) { Console.WriteLine($"El numero random es mas pequeño que el [{numeroUsuario}]"); }

            } while (numeroUsuario != numeroRandom);

            Console.WriteLine($"Felicidades, has acertado, el numero random es el [{numeroRandom}], te ha tomado [{intentos } intentos]");
            Console.ReadLine();
        }

        static void Usocheked()
        {
            //el unchequed sirve para checar a fondo cada expresion que esté dentro, si da un error que normalmente pasa desapercivido, tira.
            checked
            {
                int alor = int.MaxValue;

                Console.WriteLine($"el valor maximo es {alor + 20 }");
                Console.ReadLine();

            }

        }

        public static string LanzamientoExcepciones(int mes)
        {

            switch (mes) 
            {
                case 1: 
                    return "enero";
                case 2:
                    return "febrero";
                case 3:
                    return "marzo";
                case 4:
                    return "abril";
                case 5:
                    return "mayo";
                case 6:
                    return "junio";
                case 7:
                    return "julio";
                case 8:
                    return "agosto";
                case 9:
                    return "septiembre";
                case 10:
                    return "octubre";
                case 11:
                    return "noviembre";
                case 12:
                    return "dicioembre";
                default:
                    throw new ArgumentOutOfRangeException();

            }
            
        } 


        static void Finally()
        {

            System.IO.StreamReader archivo = null;

            try 
            {
                String linea;

                int contador = 0;

                string path = @"C:\Users\sergio garcia michel\Desktop\tirar.txt";

                archivo = new System.IO.StreamReader(path);

                while ( (linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);

                    contador++;
                }

            }
            catch (Exception e) 
            {
                Console.WriteLine ($"Error : [ {e.Message} ]" );
            }
            finally
            {
                if (archivo != null) { archivo.Close(); }

                Console.WriteLine("Conexión cerrada.");
            }


        }

    }
}
