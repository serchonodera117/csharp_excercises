using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Interfaces
{
    class imprimir
    {
        public static void Imprimir() 
        {
            Caballo myPerdigon = new Caballo("Perdigón");
            IMamiferoTerrestre IPerdigon = myPerdigon;

            Console.WriteLine($"patas de perdigon: {IPerdigon.NumPatas()}");                //se utiliza el principio de sustitucion para trabajar con objetos
            ISaltoPatas ISaltoPerdigón = myPerdigon;                                        //puesto que los metodos estan en la interfaz, se sustituye ppor el principio 
            Console.WriteLine($"perdigon es capaz de saltar con: {ISaltoPerdigón.NumPatas()} patas");  // "Es un" lo cual hace las caracteristicas del objeto caballo pasen al objeto
            Ballena myWilly = new Ballena("Willy");                                         //interfaz.
            myWilly.getNombre();
            Console.Write("es capaz de:");
            myWilly.Nadar();


            Console.ReadKey();
        }

        public static void Multas() 
        {
            AvisosTrafico general = new AvisosTrafico();
            AvisosTrafico personalizado = new AvisosTrafico("peñin", "multa por exceso de velocidad  300$","08-07-2020");
            general.MostrarAviso();

            personalizado.MostrarAviso();
        }
    }
}
