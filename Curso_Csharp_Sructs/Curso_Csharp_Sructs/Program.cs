using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Sructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200,250);


            empleado1.CambiaSalario(empleado1,100 );


            Console.WriteLine(empleado1);

            Console.ReadKey();

        }
    }


    public class Empleado
    {
        public double salarioBase, comision;

        public Empleado(double salarioBase, double comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }
        
        public override string ToString()
        {
            return string.Format("EL salario y comisión del empleado es ({0},{1})",this.salarioBase ,this.comision );
        }

       public void CambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;

            comision += incremento;

        }

    }
}
