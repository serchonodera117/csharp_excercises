using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Arrays_For_Y_parametro
{
    class Array
    {
       public static void ArraySimple()
        {
            //int[] edades = new int[4];
            //edades[0] = 14;
            //edades[1] = 16;
            //edades[2] = 18;
            //edades[3] = 19;

            int[] edades = { 14, 19, 15, 80 };  //cuando el array se declara de esta forma, la cuenta de los elementos inicia 
                                                //de derecha a izquierda.   {3,2,1,0}

            Console.WriteLine($"edad [2] = {edades[2]}");  
        }    

        public static void Arraydos()
        {
            //<<<<<<<<<< Array implicito >>>>>>>>>>>>>>>>>>>             NO ESPECIFICAN EL TIPO DE DATOS

            // var datos = new[] {"hola", "ola", 15 }; El ERROR sucedde porque los tipos de datos no son compatibles

            var valores = new[] { 1,2,3,4,3.14}; //aquí no hay error puesto a que siguen siendo dnumeros y por tanto, compatibles son. 
                                                 //Lo pasaría tod al tipo de dato double.

            //<<<<<<<<<< Array de Objetos >>>>>>>>>>>>>>>>

            Empleados[] arrayEmpleados = new Empleados[2];

            Empleados sara = new Empleados("sara", 21);

            arrayEmpleados[0] = new Empleados("Alison", 20);
            arrayEmpleados[1] = sara;


            //<<<<<<<<<<< Arrays anónimos >>>>>>>>>>>>>>>>>

            var edadesEmpleados = new[]
            {                                                                     //Este tipo de array se declara de forma similar
                  new{nombre = "Diana", edad = 19 },                              //a las clases anónimas, con la diferencia que de cada 
                  new{nombre = "Hanna" ,edad = 18 },                              //posición lleva la preposición new{a,n}, poniendo coma 
                  new{nombre = "jessica", edad = 19 }                             //por cada "objeto". se leen de izquierda a derecha o de
            };                                                                    //arriba hacia abajo, dependiendo de como sean estuctuados

            Console.WriteLine(edadesEmpleados[0]);
        }


        public static void ArrayParametros1(int [] datos )
        {
            for(int i = 0; i  <=4; i++)
            {
                datos[i] += 10;
            }
        }

        public static int[] ArrayReturn()
        {
            int respuestaArray, elementos;
          
                Console.WriteLine("¿Cuantos elementos quieres que contenca tu array?");
                elementos = int.Parse(Console.ReadLine());
         

            int[] datos = new int[elementos];

            for( int i = 0; i < elementos; i++)
            {
                try
                {
                    Console.Write($"Escribe el numero de la posición [{i + 1 }]");
                    respuestaArray = int.Parse(Console.ReadLine());

                    datos[i] = respuestaArray;
                }
                catch (Exception e)
                {
                    Console.WriteLine ("["+e.Message+"]"  + "  " + "El valor valdrá 0");
                    respuestaArray = 0;
                }
            }
            return datos; 
        } 








    }

    class Empleados
    {
        private string nombre;
        private int edad;

        public Empleados(string nombre, int edad)
        {


            this.nombre = nombre;
            this.edad = edad;
        }

        public string GetInfoEmpleados(){ return $"Nombre : {nombre} Edad : [{edad}]";}
    }
}
