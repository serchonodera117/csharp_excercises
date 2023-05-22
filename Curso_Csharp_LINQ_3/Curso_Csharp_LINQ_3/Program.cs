using System;
using System.Collections.Generic;
using System.Linq;


namespace Curso_Csharp_LINQ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados cEE = new ControlEmpresasEmpleados();
            cEE.getCeo();
            
            Console.WriteLine("\n todos los empleados en orden alfabetico : ");
            
            cEE.getEmpleadosOrdenados();

            Console.Write("\n escribir id de la empresa de la cual usted guste ver los empleados: ");
            try
            {
                int idParametro = Convert.ToInt32(Console.ReadLine());
                if (idParametro < 1 || idParametro > 2) Console.WriteLine("Has introducido un Id inexistente");
                else
                {
                    cEE.getEmpleadosEmpresa(idParametro);
                }
            }
            catch (Exception) { Console.WriteLine("Has introducido un Id inexistente"); }
          

            Console.ReadKey();
        }
    }
    class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });

            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Onodera's company" });


            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Sergey Brin", Cargo = "CEO", EmpresaId = 1, Salario = 150000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Juan Díaz", Cargo = "CEO", EmpresaId = 2, Salario = 1500000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Chuy Gatel", Cargo = "Co-CEO", EmpresaId = 1, Salario = 120000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Larry Page", Cargo = "Co-CEO", EmpresaId = 2, Salario = 130000 });
        }
        public void getCeo()
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados where empleado.Cargo == "CEO" select empleado;

            foreach (Empleado empleado1 in ceos) empleado1.getDatosEmpleado();

        }

        public void getEmpleadosOrdenados() 
        {
            IEnumerable<Empleado> eOrdenado = from orden in listaEmpleados orderby orden.Nombre  select orden;
            foreach (Empleado empleado1 in eOrdenado) empleado1.getDatosEmpleado();
        }

        public void getEmpleadosEmpresa(int id)
        {
            IEnumerable<Empleado> onoderasWorkers = from empleado in listaEmpleados join empresa in listaEmpresas
                                              on empleado.EmpresaId equals empresa.Id
                                              where empresa.Id == id select empleado;

            foreach (Empleado empleado1 in onoderasWorkers) empleado1.getDatosEmpleado();
        }
    }
    class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public void getDatosEmpresa() => Console.WriteLine("Empresa {0} con ID {1}", Nombre, Id);
    }
    class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        //Clave foranea 
        public int EmpresaId { get; set; }

        public void getDatosEmpleado() => Console.WriteLine($"Empleado [{Nombre}] con ID [{Id}], cargo [{Cargo}] " +
                                                            $"con salario [{Salario}] y pertenece a la empresa [{EmpresaId}]");

    }
}
