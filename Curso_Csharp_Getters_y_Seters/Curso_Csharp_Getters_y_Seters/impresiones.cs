using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Getters_y_Seters
{
    class imprimir
    {
        public static void EjemploAutos()
        {
            Auto auto1 = new Auto();
            Console.WriteLine($"Info del Auto {auto1.InfoCoche()}");
            Console.ReadLine();

            Auto auto2 = new Auto(3,2);
            Console.WriteLine($"Info del coche dos {auto2.InfoCoche()}");
            
            auto2.SetInfoExtra(true, "cuero");
            
            Console.WriteLine( "EXTRAS: \n" + auto2.GetExtras());
            Console.ReadLine();
          

        }
    }
}
