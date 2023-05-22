using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Condicionales_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //el signo de admiracion significa que niega la variable, o contradice un igual, por ejemplo el diferente que !=
            ////bool haceFrio;

            ////haceFrio = false;

            ////Console.WriteLine( !haceFrio );
            ////Console.ReadLine();

            int edad;
            string carnet = "no";

            Console.WriteLine("Evaluar si puedes conducir");

            Console.WriteLine("Que edad tiebes?");
            edad = int.Parse(Console.ReadLine());


            if (edad >= 18)
            {
                    Console.WriteLine("Tienes carnet de conducir?");
                    carnet = Console.ReadLine();
            }

            if (edad >= 18 && carnet == "si" || carnet == "Si") { Console.WriteLine("Felicidades march, puedes manejar"); }

            else { Console.WriteLine("Putamadre March, No puedes Manejar"); }

            Console.ReadKey();

        }
    }
}
