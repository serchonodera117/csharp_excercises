using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_bella
{
    class Program
    {
        static void Main(string[] args)
        {
           

            
            Chica Hanna = new Chica();

            Console.ForegroundColor = ConsoleColor.Blue;
            Hanna.arrayBella();

                  Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Hanna.arrayBellaSaltolinea();

                 Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Hanna.arrayBellaxd();

                  Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Hanna.matrizBella();

                  Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Hanna.queBella4d();

                  Console.WriteLine("\n");

            Hanna.Xddd();





            Console.ReadKey();
        }
    }

    class Chica
    {
        string[] bella = new string[50];
        string[,] kBella = new string[3,3];
        string[,,,] kBella2 = new string[3, 3, 3, 3];
        string[,,,,,,,] exajerarEquisde = new string[3, 3, 3, 3,3, 3, 3, 3];



        public void arrayBella()
        {
            for (int i = 0; i < 50; i++)
            {
                bella[i] = "Que bella";
            }
            for (int i = 0; i < 49; i++)
            {
                Console.WriteLine(bella[i]);
            }
        }

        public void arrayBellaSaltolinea()
        {
            for (int i = 0; i < 50; i++)
            {
                bella[i] = "Que bella";
            }
            for (int i = 0; i < 49; i++)
            {
                Console.WriteLine(bella[i]+"\n");
            }
        }

        public void arrayBellaxd()
        {
            for (int i = 0; i < 50; i++)
            {
                bella[i] = "Que bella";
            }
            for (int i = 0; i < 49; i++)
            {
                Console.Write(bella[i]);
            }
        }

        public void matrizBella()
        {
            for (int i = 0; i < 3; i++)
              for (int j = 0; j < 3; j++)
                {
                    kBella[i, j] = "Que bella";
                }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" "+kBella[i,j]+ " ");
                }
                Console.WriteLine("\n");  
            }

        }


        public void queBella4d()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int a = 0; a < 3; a++)
                        for (int b = 0; b < 3; b++)
                        {
                            kBella2[i, j, a, b] = "Que bella";
                        }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int a = 0; a < 3; a++)
                    {
                        for (int b = 0; b < 3; b++)
                        {
                            Console.Write(" " + kBella2[i, j, a, b] + " ");
                        }
                        Console.Write("     ");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }     
                
        }

        public void Xddd()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int a = 0; a < 3; a++)
                        for (int b = 0; b < 3; b++)
                            for (int q = 0; q < 3; q++)
                                for (int w = 0; w < 3; w++)
                                    for (int e = 0; e < 3; e++)
                                        for (int r = 0; r < 3; r++)
                                        {
                                            exajerarEquisde[i, j, a, b, q, w, e, r] = "Que bella";
                                        }



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int a = 0; a < 3; a++)
                    {
                        for (int b = 0; b < 3; b++)
                        {
                            for (int q = 0; q < 3; q++)
                            {
                                for (int w = 0; w < 3; w++)
                                {
                                    for (int e = 0; e < 3; e++)
                                    {
                                        for (int r = 0; r < 3; r++)
                                        {
                                            Console.Write(" " + exajerarEquisde[i, j, a, b, q, w, e, r]+ " ");
                                        }
                                        Console.Write("     ");
                                    }
                                    Console.WriteLine("\n");
                                }
                                Console.WriteLine("\n");
                            }
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }  
        }
    }
}
