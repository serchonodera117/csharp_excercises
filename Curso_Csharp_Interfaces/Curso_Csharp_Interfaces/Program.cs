using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            char menu;

            do
            {
                Console.Clear();
                Console.Write("Inicio \n(Tema) \n\n1.- Opcion [1] \n2.- Opcion [2] \n3.- Opcion [3] \nPresiona [s] para salir \n\n\nEscribe la opción: ");
                menu = Console.ReadKey().KeyChar;

                switch (menu)
                {
                    case '1':
                        Console.Clear(); //interfaces
                        Console.WriteLine(" Opción 1: ");
                        imprimir.Imprimir();
                        Console.ReadLine();
                        break;


                    case '2':
                        Console.Clear();
                        Console.WriteLine(" Opción 2: ");
                        imprimir.Multas();
                        Console.ReadLine();
                        break;


                    case '3':
                        Console.Clear();
                        Console.WriteLine(" Opción 3: ");

                        Console.ReadLine();
                        break;


                    case 's':
                        Console.Clear();
                        Console.WriteLine(" Has seleccionado salir (U ,w, U ) ");

                        Console.ReadLine();
                        break;

                    case 'S':
                        Console.Clear();
                        if (menu == 'S')
                        {
                            menu = 's';
                            Console.WriteLine(" Has seleccionado salir (U ,w, U ) ");
                        }

                        Console.ReadLine();
                        break;

                    default:
                        Console.Clear(); Console.WriteLine("La opción que has pueasto no existe =(");
                        break;
                }
                Console.ReadKey();
            } while (menu != 's');

        }
    }

    interface IMamiferoTerrestre //lo que hace la interfaz es poner metodos exclusivos que no todas las clases pueden heredar.
    {                            //Se declara el metodo sin odificadores ni llaves.
        int NumPatas();

        string Deporte();

        Boolean Olimpico();
    }

    interface ISaltoPatas 
    {
        int NumPatas();
    }


    class Mamifero
    {
        private string nombreSerVivo;

        public Mamifero(string nombre)
        {
            nombreSerVivo = nombre;
        }

        public virtual void Razonar() { Console.WriteLine("Soy capaz de razonar y pensar de forma instintiva"); }

        public void Respirar() { Console.WriteLine("Soy capaz de respirar"); }

        public void CuidaCrias() { Console.WriteLine("Soy capaz de cuidar crías hasta que estas se valgan por si mismas"); }

        public void getNombre() { Console.WriteLine($"[{nombreSerVivo}]"); }
    }



    class Caballo : Mamifero, IMamiferoTerrestre,ISaltoPatas    //se hereda de la misma forma que una clase, sin embargo, los separa una coma, a su vez, la clase 
    {                                               //siempre va primero. 
        public Caballo(string caballo) : base(caballo) { }

        public void Galopar() { Console.WriteLine($"soy capaz de galopar"); }

         int IMamiferoTerrestre.NumPatas() { return 4; }    //se presentó una ambigüedad en IMamiferos e Isaltos, puesto que ambos utilizan el mismo metodo.
                                                            //Lo que se hace en este caso, es eliminar el tipo de acceso y poner a continucaición del tipo de dato
        public string Deporte() { return "Carreras de Caballos"; } //el nombre de la interfaz, (Tipo de dato) NombreInterfaz.Nombre del metodo(){}

        public Boolean Olimpico() { return false; }

        int ISaltoPatas.NumPatas() { return 2; }

    }

    class Humano : Mamifero
    {
        public Humano(string nombreHUmano) : base(nombreHUmano) { }

        public override void Razonar() { Console.WriteLine("Soy capaz de pensar y razonar de forma lógica ¿?"); }
    }

    class Gorila : Mamifero
    {
        public Gorila(string nombreGorila) : base(nombreGorila) { }

        public override void Razonar() { Console.WriteLine("hago monadas.exe"); }

        public void Trepar() { Console.WriteLine("Mira como trepo.jpg"); }
    }

    class Ballena : Mamifero
    {
        public Ballena(string nombreBallena) : base(nombreBallena) { }

        public void Nadar() { Console.WriteLine("Mira como nado"); }
    }
}
