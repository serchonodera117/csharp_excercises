using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Clases_Abstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lagartija Mem = new Lagartija("Mime");
            Conejo Bugs = new Conejo("Bugs Bunny");
            Reptiles iguanaJuana = new Reptiles("Juana la iguana");
            Mem.GetNombre();
            Bugs.GetNombre();
            iguanaJuana.GetNombre();
            Console.ReadKey();
        }
    }



    abstract class Animales
    {
     

        public void Respirar() { Console.WriteLine(" estoy Respirando"); }

        public abstract void GetNombre(); 
    }

    class Mamiferos : Animales
    {
        string nombreMamifero;

        public Mamiferos() { }
        public Mamiferos(string nombreMamifero)
        {
            this.nombreMamifero = nombreMamifero;
        }

        public override void GetNombre() { Console.WriteLine("El nombre del mamifero es: " + " " + nombreMamifero); }
        public void AmamantarCrias() { Console.WriteLine("amamanto a mis crías"); }
    }

    class Reptiles : Animales
    {
        private string nombreReptil;

        public Reptiles() { }
        public Reptiles(string nombreReptil) { this.nombreReptil = nombreReptil; }

        public override void GetNombre() { Console.WriteLine($"El nombre del raptil es: {nombreReptil}"); }
        public void TomarSol() { Console.WriteLine("Tomo sol porque soy de sangre fría"); }
    }


    class Conejo : Mamiferos
    {
        string nombreMamifero;

        public Conejo() { }
        public Conejo(string nombreMamifero) { this.nombreMamifero = nombreMamifero; }
        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del mamifero es: {nombreMamifero}");
        }
        public void Saltar() { Console.WriteLine("Wacha como salto.jpg"); } 
    }

    class Lagartija : Reptiles
    {
        private string nombreReptil;
        public Lagartija(string nombreReptil) : base(nombreReptil){ }
        public override void GetNombre() { Console.WriteLine($" El nombre del reptil es {nombreReptil}"); }
        public void Reptilear() { Console.WriteLine("Wacha como reptileo.jpg"); }
    }
}
