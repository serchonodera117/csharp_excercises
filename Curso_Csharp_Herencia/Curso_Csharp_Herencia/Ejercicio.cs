using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Herencia
{
    class Vehiculo 
    {


        public virtual void ArancarMotor() { Console.WriteLine("Has arrancado el motor del vehículo");}
        public virtual void ApagarMotor() { Console.WriteLine("Has apagado el motor del vehculo");}
        public virtual void Conducir() { Console.WriteLine("Conduciendo el vehículo"); }
    }

    class Avion : Vehiculo
    {
        public override void ArancarMotor()
        {
            Console.WriteLine("Has arrancado el motor del Avión");
        }

        public override void ApagarMotor()
        {
            Console.WriteLine("Has apagado el motor del avión");
        }

        public override void Conducir()
        {
            Console.WriteLine("Estás conduciendo el avión");
        }

    }

    class Auto : Vehiculo
    {
        public override void ArancarMotor()
        {
            
            Console.WriteLine("Has arrancado el motor del Auto");
        }

        public override void ApagarMotor()
        {
          
            Console.WriteLine("Has apagado el motor del Auto");
        }

        public override void Conducir()
        {
            
            Console.WriteLine("Estás conduciendo el Auto");
        }

    }

}
