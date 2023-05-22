using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Curso_Csharp_Meodos_Sobrecarga
    {

        /* 
        La sobrecarga consiste en tener diferentes metodos con el mismo nombre,
        pero el programa se encarga de identificarlos debido al tipo de dato, parametros 
        y cantidad de parametros.
        */
          
         
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(2 , 5,8));

            Console.ReadLine();

        }

        static int Suma(int uno, int dos) => uno + dos;

        static double Suma (int u, double d) => u * d;

        static int Suma(int a, int b, int c) => a + b + c;

    }
}
