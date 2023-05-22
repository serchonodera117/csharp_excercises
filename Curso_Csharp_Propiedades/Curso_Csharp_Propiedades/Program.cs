using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado Lolo = new Empleado("Lolo");

            Console.WriteLine($"cuanto quieres que gane {Lolo.GetNombre()} ?");
            double salario = double.Parse(Console.ReadLine());
            Lolo.SALARIO = salario;

            Console.WriteLine($"El salario de {Lolo.GetNombre()} es de {Lolo.SALARIO}");
            //Lolo.SetSalario(salario);

            //Console.WriteLine($"El salario de {Lolo.GetNombre()} es de : [{Lolo.getSalario()}] pesos");

            Console.ReadKey();
        }
    }

    class Empleado
    {

        private string nombre;
        private double salario;

        public Empleado(string nombre) { this.nombre = nombre; }
        public string GetNombre() { return nombre; }
        //public void SetSalario(double salario)
        //{
        //    if (salario < 0)
        //    {
        //        Console.WriteLine("El salario no puede ser negativo. Se asignará 0");

        //        this.salario = 0;
        //    }
        //    else
        //    {
        //        this.salario = salario;
        //    }
        //}

        //public double getSalario(){ return salario; }


        //CREACIÓN DE PROPIEDAD

        private double EvaluarSalario(double salario)             
        {
            if (salario < 0) return 0;

            else return salario;
        }


        /*

        public double SALARIO
        {
            get { return this.salario; }
            set { this.salario = EvaluarSalario(value); }     //PROPIEDD>>>>>>>>>>>>>>>>>>
        }
        */

        public double SALARIO
        {
            get => this.salario;
            set => this.salario = EvaluarSalario(value);      //PROPIEDAD REDUCIDA: Get lectura, set Escritura.
        }

    }
}
