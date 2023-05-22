using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Delegados_Predicados_Lamdas_2
{

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<DELEGADOS PREDICADOS>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    class Program
    {
        static void Main(string[] args)
        {
            //Class1.PredicadoNumPares();

            int c = 0;
            List<Persona> Gente = new List<Persona>();


            Persona p1 = new Persona();
            p1.NombrePROPIT = "Serch";
            p1.EdadPROPITY = 19;


            Persona p2 = new Persona();
            p2.NombrePROPIT = "Hanna";
            p2.EdadPROPITY = 18;


            Persona p3 = new Persona();
            p3.NombrePROPIT = "Marceline";
            p3.EdadPROPITY = 15;


            Persona p4 = new Persona();
            p4.NombrePROPIT = "Onodera";
            p4.EdadPROPITY = 7;

            Gente.AddRange(new Persona[] { p1, p2, p3, p4 });
          
            for (int i = 0; i < Gente.Count; i++)
            {
                if (Gente[i].EdadPROPITY > 17) { c++; }
            }
            
            Predicate<Persona> PredicadoPersona = new Predicate<Persona>(Serch);

            bool existe = Gente.Exists(PredicadoPersona);



            if (existe) { Console.WriteLine($"Hay {c} mayores de edad"); }
            else { Console.WriteLine("No hay mayores de edad"); }
            



            Console.ReadKey();
        } 

        static bool Serch(Persona personne)
        {
            if (personne.EdadPROPITY > 17) return true;
            else return false;
        }
    }

    class Persona
    {
        private string Nombre;
        private int Edad; 

        public string NombrePROPIT{ get => Nombre; set => Nombre = value; }
        public int EdadPROPITY { get => Edad; set => Edad = value; }
    }
}
