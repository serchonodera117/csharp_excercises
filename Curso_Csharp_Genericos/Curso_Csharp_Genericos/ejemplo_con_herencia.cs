using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Genericos
{
    class AlmacenObjetos
    {
        private Object[] DatosElemento;
        private int i =  0;

        public AlmacenObjetos(int z)
        {
            DatosElemento = new Object[z];
        }

        public void IntroducirObjetos(Object Objeto)
        {
            DatosElemento[i] = Objeto;
            i++;
        }

        public Object GetObjeto(int i)
        {
            return DatosElemento[i];
        }
    }

    class Empleado
    {
        private double salario;

       public  Empleado (double salario)
        {
            this.salario = salario;
        }

        public double getSalario() { return salario; }
    }



   // <<<<<<<<<<<<<<<<<<<<<<< Uso de genericos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
  
    
    class generica <T> //esta es la forma de crear a una clase generica, por convención en C# s pone una t, pero es solo eso, convención, no afeacta si pones otra cosa 
    {
        private T[] DatosElemento;                  //se procede a sustituir todos los Objects por el nombre entre las 
        private int i = 0;                          //flechas, en este caso T

        public generica(int z)
        {
            DatosElemento = new T[z];
        }

        public void IntroducirObjetos(T Objeto)
        {
            DatosElemento[i] = Objeto;
            i++;
        }

        public T GetObjeto(int i)
        {
            return DatosElemento[i];
        }
    }

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< programación generica con Restricciones>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        class AlmacenEmpleados <T> where T : IparaSalario //lo que hace esta instruccion es que la clase solo puede hacer referencia a 
    {                                                     //los objetos/clases que implementen la iterfaz que se le haya puesto, en 
        private int i = 0;                                //este caso se implementa la IparaSalario
        private T[] ArrayEmpleados;

        public AlmacenEmpleados(int Z)
        {
            ArrayEmpleados = new T[Z];
        }

        public void AlmacenarEmpleados(T obj)
        {
            ArrayEmpleados[i] = obj;
            i++;
        }

        public T GetEmpleados(int i)
        {
            return ArrayEmpleados[i];
        }


    }


       interface IparaSalario
    {
        double GetSalario();
    }

    class Director:IparaSalario
    {
        private double salario;

        public Director(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }

    }

    class Secretaria:IparaSalario
    {
        private double salario;

        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }

    }

    class Electricista:IparaSalario
    {
        private double salario;

        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }

    }

    class Estudihambre
    {
        private double edad;

       public Estudihambre(double edad)
        {
            this.edad = edad;
        }

        public double GetEdad() { return edad; }
    }
}
