using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Herencia
{
    class Objetos_Instancias
    {
        public static void Herencia1()
        {
            Caballos Perdigon = new Caballos("Tiro al blanco");

            Humano Serch = new Humano("Serch Onodera");

            Gorila Arambe = new Gorila("Arambe Jimbei");


            Serch.getNombre();
            Serch.Razonar();

            Perdigon.getNombre();
            Perdigon.Galopar();

            Arambe.getNombre();
            Arambe.Trepar();
        }

        public static void PrincipioDeSustitucion()
        {

            Caballos Perdigon = new Caballos("Tiro al blanco");

            Humano Serch = new Humano("Serch Onodera");

            Gorila Arambe = new Gorila("Arambe Jimbei");


            //Primer forma de sustirución
            Mamiferos Rubius = new Gorila("Ruben Doblas");  //No tendrá los metodos de la cnew class, por el simple hecho de 
                                                            //que ese metodo no se encuentra en la clase padre.

            //segunda forma/manera de sustituir.
            Mamiferos miMamifero = new Mamiferos("Rozinante");
            Caballos Rozcinante = new Caballos("Rozinante");

            miMamifero = Rozcinante;                       //De esta froma si que se tienen los metodos de la new class, porque
                                                           //Se instamcia a un segundo objeto de esa clase, para posteriormente     
           //tercer forma.                                 //pasarle la información a la clase padre, por ende, le pasa los metodos.       
           
            object persona = new Humano("Aschcrow");       //Sin embargo, esta forma solo permite metodos de tipo object.

            //todo esto sirve para muchas cosas, si quieres almacenar los objetos en un array, tiene que ser de la super clase, para
            //que pueda alacenar todo, pporque, si no, solo almacenaría los objetos de su propio tipo.

            Mamiferos[] almacenarMamiferos = new Mamiferos[] {Perdigon,Serch,Arambe,Rubius};

            for (int i = 0; i < almacenarMamiferos.Length; i++)
            {

                almacenarMamiferos[i].getNombre();
                almacenarMamiferos[i].Razonar();

            }
            
        }

        public static void ejercicio()
        {
            Avion Jet = new Avion();
            Auto vocho = new Auto();
            char menu,interaccion;

            do
            {
                Console.Clear();
                Console.Write("Escoja el vehículo que desee:\nEscribe [0] para volver al menu principal  \n1.- Vocho[1] \n2.- Jet[2] \nEscribir respuesta: ");
                menu = Console.ReadKey().KeyChar;
                switch (menu)
                {
                    case '1': 
                        Console.WriteLine("Has escogido el vocho;");
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("escribe [1] para encender, [3]para salir del vocho");
                            interaccion = Console.ReadKey().KeyChar;

                            if (interaccion == '1')
                            {
                                vocho.ArancarMotor();

                                Console.WriteLine("has encendido el vehículo, presiona [2] para conducir [0] para apagar el motor]");
                                interaccion = Console.ReadKey().KeyChar;

                                if (interaccion == '2') { vocho.Conducir(); Console.ReadLine(); }
                                else if (interaccion == '0') { vocho.ApagarMotor(); }
                                else if (interaccion == '3') { Console.WriteLine("Has seleccionado salir del vocho, ha terminado el ciclo"); }
                                else { Console.WriteLine("opción invalida, prueba de nuevo"); }

                            }

                            else if (interaccion == '3') { Console.WriteLine("Has seleccionado salir del vocho, ha terminado el ciclo"); }
                            else { Console.WriteLine("opción invalida, prueba de nuevo"); }


                        } while (interaccion != '3');
                        break;



                    case '2':
                        
                        Console.WriteLine("Has escogido el jet;");
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("escribe [1] para encender, [3]para salir del jet");
                            interaccion = Console.ReadKey().KeyChar;

                            if (interaccion == '1') 
                            { 
                                Jet.ArancarMotor();

                                Console.WriteLine("has encendido el vehículo, presiona [2] para conducir [0] para apagar el motor");
                                interaccion = Console.ReadKey().KeyChar;

                                if (interaccion == '2') { Jet.Conducir(); Console.ReadLine(); }
                                else if (interaccion == '0') { Jet.ApagarMotor(); }
                                else if (interaccion == '3') { Console.WriteLine("Has seleccionado salir del vocho, ha terminado el ciclo"); }
                                else { Console.WriteLine("opción invalida, prueba de nuevo");}
                            }

                            else if (interaccion == '3') { Console.WriteLine("Has seleccionado salir del jet, ha terminado el ciclo"); }
                            else { Console.WriteLine("opción invalida, prueba de nuevo"); }
                        } while (interaccion != '3');
                        break;





                    case '0': Console.Clear();
                        Console.WriteLine("has seleccionado volver al menú principal");
                        break;

                    default: Console.Clear();
                        Console.WriteLine("Opción invlida, solo escriba los numeros que aparecen en los corchetes, no sea puto pendejo");
                        break;
                }


            } while (menu != '0');


        }

    }
}
