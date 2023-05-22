using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Genericos
{
    class Imprimir
    {
        public static void EjemploDeGenericosConHerencia()
        {
            AlmacenObjetos archivos = new AlmacenObjetos(4);

            //archivos.IntroducirObjetos("SerchOnodera");
            //archivos.IntroducirObjetos("Shaco");
            //archivos.IntroducirObjetos("ElRabosOMG");
            //archivos.IntroducirObjetos("AuronClavo");

            archivos.IntroducirObjetos(new Empleado(4559));
            archivos.IntroducirObjetos(new Empleado(3559));
            archivos.IntroducirObjetos(new Empleado(5559));
            archivos.IntroducirObjetos(new Empleado(3000));

            Empleado salario = (Empleado)archivos.GetObjeto(3); //casting en caso de que se haga con herencia, esto puede
                                                                //llegar a ser mul calcino.
            Console.WriteLine($"operacióin por metodo no recomendado de herencia es : {salario.getSalario()}" );

        }

        public static void EjemploGenericos()
        {
           generica<Empleado> archivos = new generica<Empleado>(4); //si se quiere cambiar el tipo de objeto que se maneja
                                                                    //simple y sencillamente se debe poner el tipo de dato/objeto
                                                                    //que se desea manejar, dentro de las flechas 
                                                                    //Ej: ClaseInstanciada <Tipo de dato/ojeto> NOMBRE = new ClaseInstanciada <Tipo de dato/objeto>();
            archivos.IntroducirObjetos(new Empleado(4559));
            archivos.IntroducirObjetos(new Empleado(3559));
            archivos.IntroducirObjetos(new Empleado(5559));
            archivos.IntroducirObjetos(new Empleado(3000));

            Empleado salario = archivos.GetObjeto(3); //instanciando la clase generica, nos ahorramos el casting 

            Console.WriteLine($"operacióin por metodo no recomendado de herencia es : {salario.getSalario()}");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<GENERICO CON RESTRICCIONES>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        public static void GenericosConRestricciones()
        {
            AlmacenEmpleados<Director> directores = new AlmacenEmpleados<Director>(3);

            directores.AlmacenarEmpleados(new Director(10000));      //como se puede observar, estas instancias son del
            directores.AlmacenarEmpleados(new Director(15000));      //tipo permitido ya que reciben el metodo de get - 
            directores.AlmacenarEmpleados(new Director(20000));      //-salario Implementado ateriormente en la interfaz
                                                                         

            Console.Write("Escriba un numero del 0 al 2 (ya que inicia del 0) para escoger el salario");
            int posicion = int.Parse(Console.ReadLine());
                Director Salario = directores.GetEmpleados(posicion);

            Console.Write($"Operación por programación generica con restricciones: \n EL salario del emppleado [{posicion}] es de: {Salario.GetSalario()}]");

           //AlmacenEmpleados<Estudihambre> estudiante = new AlmacenEmpleados<Estudihambre>(3);

           // estudiante.AlmacenarEmpleados(new Estudihambre(10));      
           // estudiante.AlmacenarEmpleados(new Estudihambre(15));     
           // estudiante.AlmacenarEmpleados(new Estudihambre(20));
           
            /* Como se pudo observar, este codigo se encuentra comentado por el simple hecho de que presentó un error
               Dicho error es que no herencia ni hereda/emplea la interfaz de saario, en sí, el codigo funciona, puesto
               que la clase generica AlmacenEmpleados, solo puede instanciar clases y objetos que implementen la interfaz*/
        }
    }
}
