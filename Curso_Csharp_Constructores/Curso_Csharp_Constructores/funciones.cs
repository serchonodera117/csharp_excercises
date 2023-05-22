using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Constructores
{
    class funciones
    {
        public static void PrimerConstructor()
        {

            Coche coche1 = new Coche(); //crear un objeto/instanciacia detipo Coche.
                                        //dar un estado inicial a nuestro coche.

            Console.WriteLine($"[{coche1.InfoCoche()}");
            Console.ReadLine();

            Coche coche2 = new Coche(1.8, 4);

            Console.WriteLine($"[coche 2 : \n {coche2.InfoCoche()}");
            Console.ReadLine();

        }

        public static void SegundoConstructor()
        {
            string saborCliente, baseCliente;

            Helado heladoMuestra = new Helado();
            Console.Write(" El helado estandar es: \n" + heladoMuestra.HeladoMuestra());
            Console.ReadLine();

            Console.Write("Sabor de su helado:");
            saborCliente = Console.ReadLine();

            Console.Write("Base de su helado de su helado:");
            baseCliente = Console.ReadLine();

            Helado heladoUsuario = new Helado(saborCliente, baseCliente);

            Console.WriteLine($"Las caracteristicas de su helado son {heladoUsuario.HeladoMuestra()}");
            Console.ReadLine();
        }

        public static void TercerConstructor() 
        {
            Sueldos sueldos = new Sueldos();
           sueldos.Imprimimr();
        } 



    }



}
