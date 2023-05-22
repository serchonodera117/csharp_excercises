using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Arrays_For_Y_parametro
{
    class imprimir
    {
        public static void PrimerCicloFor()
        {
            var valores = new[] { 1, 2, 3, 4, 3.14 };

            
            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Valor [{i+1 }] = [{valores[i]}]");
                    
            }
        }


        public static void imprimirObjetos()
        {
            Empleados[] arrayEmpleados = new Empleados[3];

            Empleados sara = new Empleados("sara", 21);

            arrayEmpleados[0] = new Empleados("Alison", 20);
            arrayEmpleados[1] = sara;
            arrayEmpleados[2] = new Empleados("Hanna",18);


            for (int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].GetInfoEmpleados());
            }
        }

        public static void Imprimirobjetos_foreach() 
        {
            //Empleados[] arrayEmpleados = new Empleados[3];

            //Empleados sara = new Empleados("sara", 21);

            //arrayEmpleados[0] = new Empleados("Alison", 20);
            //arrayEmpleados[1] = sara;
            //arrayEmpleados[2] = new Empleados("Hanna", 18);

            var edadesEmpleados = new[]
          {                                                                 
                  new{nombre = "Diana", edad = 19 },                             
                  new{nombre = "Hanna" ,edad = 18 },                               
                  new{nombre = "jessica", edad = 19 }                             
            };                                                                    

            foreach (var variable in edadesEmpleados )
            {
                Console.WriteLine(variable);
            }
        }

        public static void PrimerArrayParametos()
        {
            int[] numeros = new int [] { 12,34,54,221,13};

            Array.ArrayParametros1(numeros);

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }        
        }


        public static void ArrayConReturn()
        {
            int[] recibirArray = Array.ArrayReturn();

            for (int i = 0; i < recibirArray.Length; i++) { Console.WriteLine($"la posicion [{i + 1 }] guarda el nuumero:  [{recibirArray[i]}] "); }
        }
    }
}
