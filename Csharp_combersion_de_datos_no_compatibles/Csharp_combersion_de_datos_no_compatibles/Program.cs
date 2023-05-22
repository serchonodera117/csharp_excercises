using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_combersion_de_datos_no_compatibles
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversion de tipos de datos no compatibles, se utiliza int.Parse(variable) o float.pasre(variable);
            Console.WriteLine("escribe el valor numerico");

            float num1 = float.Parse( Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");

            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado es {num1 + num2}");

            Console.ReadLine();
        }
    }
}
