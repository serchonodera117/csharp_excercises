using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Colecciones_4_Stacks
{
    class Program
    {
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< STACKS >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            //El primer elemento en entrar es el ultimo en salir, Cual pila de platos, el primero está hasta abajo
            //mientras que el ultimo está hasta arriba, siendo este el primero en salir.
        static void Main(string[] args)
        {
            Dictionary<string, int> nombresEdades = new Dictionary<string, int>();

            nombresEdades.Add("SerchOnodera", 19);
            nombresEdades.Add("Bongo", 10);                //un diccionario contiene dos parametros, los cuales pueden ser del 
            nombresEdades["Marcelo"] = 20;                 //tipo de dato que el programador quiera, en este caso por ser edades
                                                           // y nombres, se tranaja con strings y numeros Enteros.


                                 //esas son las formas en las que se puede rellenar 

            //<<<<<<<<<<<<<<<Recorrer el diccionario>>>>>>>>>>>>>>>>>>>>>>>>

           foreach(KeyValuePair<string,int> persona in nombresEdades)
            {
                Console.WriteLine($"Nombre : {persona.Key} Edad : [{persona.Value}]" );      //la instruccion KeyValuePair
            }                                                                                //es llamada al momento de imprimr 
                                                                                             //.key para el string y .Value    
            Console.ReadKey();                                                               //para el valor asignado. em este
        }                                                                                    //caso, edad   







        static void StackBasico()
        {
            Stack<int> Numeros = new Stack<int>();

            //relleno o agregado del stack

            foreach (int numero in new int[5] { 2, 4, 6, 8, 0 })
            {
                Numeros.Push(numero);

            }

            Console.WriteLine("Recorriendo el Stack");

            foreach (int numero in Numeros)
            {
                Console.WriteLine(numero);
            }

            //Eliminando Elementos
            Console.WriteLine("\nEliminando elementos");
            Numeros.Pop();           //elimina el ultimo en entrar                               
            foreach (int numero in Numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
