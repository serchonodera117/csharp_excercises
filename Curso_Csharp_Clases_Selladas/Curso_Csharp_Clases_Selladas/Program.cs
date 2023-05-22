using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Clases_Selladas
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }



    class Primate
    {
        public virtual void pensar() { Console.WriteLine("pienso como mono"); } 
    }

    /* sealed*/
    class Gorilla:Primate    //La palabra sealed cierra las clases, y por ende, estas no pueden heredar  
    {
        string nombre;
        public Gorilla() : base() { }
        public Gorilla(string gorila) { nombre = gorila; }
        public void GetNombre() { Console.WriteLine($"El nombre del primate es: {nombre}"); }
        public sealed override  void pensar() { Console.WriteLine("pienso como mono"); } //se puede utilizar entre el indicador de acceso y el tipo de función para hacer que esta sea 
        public void Respirar() { Console.WriteLine("Respirando.jpg"); }        //absoluta, lo cual quiere decir que no se podrá sobre escribir, solo se puede cuando el metodo es heredado
        public void Trepar() { Console.WriteLine("trepando.jpg"); }           //y no se quiere que este herede a otra clase hija
    }

    class Mono : Gorilla
    {
        public Mono(string nombreMono) : base(nombreMono) { }
        
    }
}
