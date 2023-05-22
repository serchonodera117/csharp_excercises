using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Delegados_Predicados_y_Lamdas_3
{
    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<LAMDA>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    class Program
    {
        //Sirve para ahorrarnos codigo de tal forma que no se necesita crear una funcion extra, simple y sencillamente
        //se requiere de crear la sentencia en los parentesis del delegado que se haya instanciado. 
        static void Main(string[] args)
        {
            Personas p1 = new Personas();
            p1.NOMBRE = "Serch";
            p1.EDAD = 19;

            Personas p2 = new Personas();
            p2.NOMBRE = "Alison";
            p2.EDAD = 20;


            ComparaPersonas edad = (persona1, persona2) => persona1 == persona2;
            Console.WriteLine( $"Las edades de {p1.NOMBRE} y {p2.NOMBRE} son iguales? :"+" "+ edad(p1.EDAD,p2.EDAD));



            //Uso del delegado 
                                                    //zona de arametros       trabajo a realizar.

            //esta forma de simplificación de codigo se utiliza a corde al numero de parametros con los que se 
            //haya programado el delegado, en este caso dos, por ser una suma.
            OperacionMatematica cuadrado = new OperacionMatematica((numero1,numero2) => numero1*numero2);

            List<int> numeros = new List<int> {1,2,3,4,5,6,7,8,9,10};
            List<int> numerosPares = numeros.FindAll(i => i %2 == 0); //funcion Lamnda para encontrar numeros pares

            //numerosPares.ForEach(numero => Console.WriteLine(numero)); //si se quiere tener mas codigo
                                                                         //sedeben de añadir llaves despues
                                                                         //del signo Lamda.
                                                                         

            
            
            Console.ReadKey();                                           
        }

        public delegate int OperacionMatematica(int numero1, int numero2);
        public delegate bool ComparaPersonas(int edad1, int edad2);
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string NOMBRE { get => nombre; set => nombre = value; }
        public int EDAD { get => edad; set => edad = value;}
    }
}