using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Delegados_Predicados_Lamdas_2
{
    class Class1
    {
       
       public static void PredicadoNumPares()
        {
            int i = 0;
            List<int> listaNumereos = new List<int>();

            listaNumereos.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });  //esta es la forma en la que este metodo le pasa valores 
                                                                                  //a la lista mediante un array.

            //Declaracón del predicado

            Predicate<int> delegadoPredicado = new Predicate<int>(DevolverPares); //dentro del parentesis del predicado va la función/metodo 
                                                                                  //al que esté apuntando

            List<int> pares = listaNumereos.FindAll(delegadoPredicado); //el metodo FindAll de la clase de las listas 
                                                                        //funciona buscando dentro de un predicado

            foreach (int par in pares)
            {
                i++;
                Console.WriteLine($"El numero [{i}] es: {par}");
            }
        }


        static bool DevolverPares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }

    }
}
