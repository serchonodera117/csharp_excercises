using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Herencia
{
    class Mamiferos
    {
        private string nombreSerVivo;

       public Mamiferos(string nombre)   //este constructor, heredará esa variable a las demás clases.
        {
            nombreSerVivo = nombre;
        }

        public virtual void Razonar() { Console.WriteLine("Soy capaz de razonar y pensar de forma instintiva"); } //la palabra virtual sirve para hacer de ese metodo modificable
                                                                                                                  //esto por el polimorfismo, para recibir esa modificacion      
        public void Respirar() { Console.WriteLine("Spy capaz de respirar"); }                                    //el metodo de la sublase recibe la palabra override, despues del 
                                                                                                                  //modificador de acceso y antes del tipo de funcion "public override void" 
        public void CuidarCrias() { Console.WriteLine("Cuido a mis crías hasta que estas se valgan por si mismas"); }

        //Getter
        public void getNombre() { Console.WriteLine($"El nombre del ser vivo es [{nombreSerVivo}]"); }
    }

    
    class Caballos : Mamiferos         //esa es la forma en la que se herencia los contenidos de una clase, en este caso, super clase.
    {
        public Caballos(string caballo) : base(caballo) { } //cuando se trabaja con constructores, se deben poner de igual forma en las 
                                                            //subclases, de lo contrario dará error. 
        public void Galopar() { Console.WriteLine("Soy capaz de galopar"); }
    }

    
    class Humano : Mamiferos
    {
       public  Humano(string nombre) : base(nombre) { }

        public override void Razonar() { Console.WriteLine( "Soy capaz de razonar y pensar ¿?");} //cuando se hereda un metodo, y este se encuentra en la subclase
    }                                                                                    //Oculta el metodo heredado. para evitarlo se puede utilizar la        
                                                                                         //sobrecarga, o si se quiere hacer, se agrega la palabra reservada new  


  class Gorila : Mamiferos
    {

       public  Gorila(string nombre) : base(nombre) { }

        public override void Razonar() { Console.WriteLine("Pensamiento instintivo avanzado"); } //este metodo recibe de herencia el metodo, pero le modifica.
        public void Trepar() { Console.WriteLine("soy capaz de trepar"); }
    }
}
