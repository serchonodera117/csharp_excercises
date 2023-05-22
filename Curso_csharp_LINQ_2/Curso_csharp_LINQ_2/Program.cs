using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso_csharp_LINQ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados cEE = new ControlEmpresasEmpleados();
            cEE.getCeo();

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
        public void  getCeo()
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados where empleado.Cargo == "CEO" select empleado;
            
            foreach (Empleado empleado1 in ceos) empleado1.getDatosEmpleado();
            
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
