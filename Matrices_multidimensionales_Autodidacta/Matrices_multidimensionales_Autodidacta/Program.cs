using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_multidimensionales_Autodidacta
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Matrices intento1 = new Matrices();
            //    intento1.llenarMatrizA();
            //    intento1.imprimirMatrizA();

            //Matrices suma = new Matrices();
            //suma.llenarMatrizA();
            //suma.llenarMatrizB();
            //suma.SumaMatrices();
            //suma.imprimirResultadoSumaMatrces();


            //MatrizBinaria binarioequide = new MatrizBinaria();
            //Console.Write("Numero de columnas : ");
            //int columnas = int.Parse(Console.ReadLine());

            //Console.Write("Numero de Filas : ");
            //int filas = int.Parse(Console.ReadLine());

            //binarioequide.generar(columnas, filas);
            //binarioequide.imprimirBinario(columnas, filas);

            //personas tresPersonas = new personas();
            //tresPersonas.generarMtriz();
            //tresPersonas.imprimir();

            //Console.ReadKey();

            tres aver = new tres();
            aver.iniciar();
            aver.verComoSeVE();

            Console.ReadKey();
        }
    }
    class Matrices
    {
        private int[,] matrizA;
        private int[,] matrizB;
        private int[,] resultadoSuma;
        
        public void llenarMatrizA()
        {
            matrizA = new int[3,3];

            for (int columna=0; columna <3; columna++) //el primer array son las columnas y el segundo las filas
            { for(int fila=0; fila<3; fila++)
                {
                    Console.WriteLine($"ingresa la posición [{columna}][{fila}] de la matriz A");
                    matrizA[columna, fila] = int.Parse(Console.ReadLine());
                }          
            }
        }


        public void llenarMatrizB()
        {
            matrizB = new int[3, 3];

            for (int columna = 0; columna < 3; columna++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    Console.WriteLine($"ingresa la posición [{columna}][{fila}] de la matriz B");
                    matrizB[columna, fila] =int.Parse(Console.ReadLine());
                    
                }
            }
        }

        public void SumaMatrices()
        {
            resultadoSuma = new int[3, 3];
            for(int c = 0; c < 3; c++)
            {for(int f=0; f < 3; f++)
                {
                    resultadoSuma[c,f] = matrizA[c,f] + matrizB[c,f];
                }

            }
        }

        public void imprimirMatrizA()
        {
            for(int c=0; c < 3; c++)
            {for(int f = 0; f < 3; f++)
                {
                    Console.Write($"[{matrizA[c,f]}]");
                }
                Console.WriteLine();
            }
        }

        public void imprimirResultadoSumaMatrces()
        {
            for(int i = 0; i < 3; i++)
            {for(int j =0; j < 3; j++)
                {
                    Console.Write($"[{resultadoSuma[i,j]}]");
                }
                Console.WriteLine();
            }
        }
    }


    class MatrizBinaria
    {
        private  int [,] matrizBinaria;
        
        public void generar(int columna, int fila) 
        {
            matrizBinaria = new int[columna,fila];

            for (int i = 0; i<columna;i++)
            {for (int j = 0; j < fila; j++)
                {
                  
                    if (j % 2 == 0) { matrizBinaria[i, j] = 0; }

                    else { matrizBinaria[i, j] = 1; }

                    
                }

            }
        }

        public void imprimirBinario(int a,int b)
        {
            for(int i = 0; i < a; i++)
            {for (int j = 0; j < b; j++)
                {
                    Console.Write($"[{matrizBinaria[i,j]}]");
                }
                Console.WriteLine();

            }
        }

    }
    class personas
    {
        private string[,] matriz;
        private string saludo = "Hola, mi nombre es";

        public void generarMtriz()
        {
            matriz = new string[3,2];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0) { Console.Write($"usuario [{i + 1}]ingresa tu nombre : ");  }
                    else if (j == 1) { Console.Write($"usuario [{i+1}] ingresa tu edad : "); }

                    matriz[i, j] = Console.ReadLine();
                }

        }

        public void imprimir()
        {
            for (int i = 0; i < 3; i++)
            { for (int j=0; j < 2; j++)
                {
                    Console.Write($"[{saludo} {matriz[i,j]}]");
                }
                Console.WriteLine();
            }

        }
    }

    class tres
    {
     
        private int[,,,] CuatroDimensiones;

        public void iniciar()
        {
            CuatroDimensiones = new int[3, 3, 3, 3];

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        for (int d = 0; d < 3; d++)

                        {
                            CuatroDimensiones[a, b, c, d]++;
                        }
                    }
                }
            }
        }

        public void verComoSeVE()
        {
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        for (int d = 0; d < 3; d++)
                        {

                            Console.Write("[" + CuatroDimensiones[a, b, c, d] + "]");
                        }
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                 }
                Console.WriteLine();
            }
        }
    }
}
