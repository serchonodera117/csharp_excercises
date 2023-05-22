using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Delegados_Predicados_Lamdas_1
{
    class Program
    {
        
        delegate void ObjetoDelegado(string msj); 

        static void Main(string[] args)
        {
            //creacipon/instanciación del objeto delegado que apunta a una clase y a un metodo en este caso
            ObjetoDelegado delegadoPrueba = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida); //toma como argumentos el apuntador 
                                                                                                    //al que va dirigido   
            //utilizacón del delagado, llamando 
            //al metodo de saludo Bienvenda
            //de la clase MensajeBienvenida
            delegadoPrueba("serch");

            //se puede volver a instanciar de la siguiente manera
            //simplemente se cambian los argumentos
            //de igual forma, se vuelve a llamar como metodo
            //si se quiere ejecutar el nuevo puntero
            delegadoPrueba = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            delegadoPrueba("onodera");



            Console.ReadKey();
        }                                                                                           
    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine("hola, acabo de llegar. que tal " + msj);

        }
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine("Ya me voy. chinga tu madre " + msj);
        }
    }
}
