using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Escrinba el primer número");
            //int valor1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Escrinba el segundo número");
            //int valor2 = int.Parse(Console.ReadLine());


            //suma( valor1,valor2);

            Console.WriteLine("Escrinba el primer número");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escrinba el segundo número");
            int valor2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"El resultado de la suma es: [{funcionRegresar(valor1, valor2)}]");

            Console.ReadLine();
        }



        static int funcionRegresar(int uno, int dos) => uno + dos;
           



        static void suma(int num1, int num2) 
        {

            Console.WriteLine($"El resultado de la suma es : [{num1 +num2}]");
            Console.ReadLine();
        }

    }
}
