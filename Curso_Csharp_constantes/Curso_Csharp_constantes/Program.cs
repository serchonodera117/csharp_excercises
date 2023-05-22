using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_constantes
{
    class Program
    {
        static void Main(string[] args)
        {

            //constantes, en este ejercicio se demostró, para imprimierlas, se necesita del parametro entre las comillas
            //como se aprecia, sigue la misma lógica que los ciclos, empezando en 0, esto numerando las constantes que 
            //hayan sido declaradas.

            /*  const int VALOR = 5;
                const int VALOR2 = 7;
                Console.WriteLine("El valor de la constante es {1}" , VALOR , VALOR2); */



            const double PI = 3.1416;
            Console.WriteLine("Área del circulo");
            Console.Write("escribe el radio: ");
            double radio = double.Parse(Console.ReadLine());
           
            //la función math.pow() funciona para calculos matematicos, en este casso Math.poq(base , exponente)
            double area = Math.Pow(radio,2) * PI;
            Console.WriteLine($"El area del circulo es:  [ {area} ]");

            Console.ReadLine();
        }
    }
}
