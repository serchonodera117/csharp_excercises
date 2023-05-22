using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration; //librería para trabajar los comandos linq y sql


namespace Curso_Csharp_CRUD_LINQ_Y_SQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //datacontext para mapear la base
        DataClasses1DataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();
            //iniciar conexión con la bdd                               Nombre Proyecto                               Nombre CAdena datos        
           string miConexion = ConfigurationManager.ConnectionStrings["Curso_Csharp_CRUD_LINQ_Y_SQL.Properties.Settings.CrudLinqSql"].ConnectionString;

            dataContext = new DataClasses1DataContext(miConexion);

            //InsertaEmpresas();
            //InsertaEmpleados();
            // InsertarCargos();
            //InsertaEmpleadoCargo();


           showItems();

        }

        //agregar Mostrar info tablas (provisional )---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void showItems()
        {
            //Principal.ItemsSource = dataContext.empresa;
            //Principal.ItemsSource = dataContext.empleado;
            Principal.ItemsSource = dataContext.cargoEmpleado;
            //Principal.ItemsSource = dataContext.cargo;
        }

        //agregar empresas---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void InsertaEmpresas() 
        {
           //dataContext.ExecuteCommand("delete from empresa");

            empresa onoderasCompany = new empresa();
            onoderasCompany.Nombre = "Onodera's Company";
            //------usar data context para insertar con el mapeo hecho en DataClasses1
            dataContext.empresa.InsertOnSubmit(onoderasCompany);

            //------actualiza cambios
            dataContext.SubmitChanges();

            //------mostrar en el grid principal la empresa agredada
            //Principal.ItemsSource = dataContext.empresa;

            empresa google = new empresa();
            google.Nombre = "Google";
            dataContext.empresa.InsertOnSubmit(google);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.empresa;

        }

        //agregar empleados---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void InsertaEmpleados()
        {
            //dataContext.ExecuteCommand("delete from empleado");
            empresa onoderasCompany = dataContext.empresa.First(em => em.Nombre.Equals("Onodera's Company"));
            empresa google = dataContext.empresa.First(em => em.Nombre.Equals("Google"));

            List<empleado> listaEmpleados = new List<empleado>();
            listaEmpleados.Add(new empleado { Nombre = "Serch", Apellido_ = "Onodera", EmpresaId = onoderasCompany.Id });
            listaEmpleados.Add(new empleado { Nombre = "Shinji", Apellido_ = "Ikari", EmpresaId = google.Id });

            listaEmpleados.Add(new empleado { Nombre = "Maxine", Apellido_ = "Caulfield", EmpresaId = onoderasCompany.Id });
            listaEmpleados.Add(new empleado { Nombre = "Monka", Apellido_ = "Doki", EmpresaId = google.Id });


            dataContext.empleado.InsertAllOnSubmit(listaEmpleados);
            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.empleado;
        }

        //agregar cargos---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void InsertarCargos()
        {
           // dataContext.ExecuteCommand("delete from cargo");

            dataContext.cargo.InsertOnSubmit(new cargo {NombreCargo_ = "Director/a" });
            dataContext.cargo.InsertOnSubmit(new cargo { NombreCargo_ = "Administrativo/a" });

            dataContext.SubmitChanges();
            Principal.ItemsSource =  dataContext.cargo;
        }


        //agregar cargo de empleado---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void InsertaEmpleadoCargo()
        {
            // dataContext.ExecuteCommand("Delete from cargoEmpleado");

            //empleado onodera = dataContext.empleado.First(emp => emp.Nombre.Equals("Serch"));
            //empleado shinji = dataContext.empleado.First(emp => emp.Nombre.Equals("Shinji"));

            //cargo dire = dataContext.cargo.First(car => car.NombreCargo_.Equals("Director/a"));
            //cargo admin = dataContext.cargo.First(car => car.NombreCargo_.Equals("Administrativo/a"));


            ////cargoEmpleado cargoSerch = new cargoEmpleado();
            ////cargoSerch.empleado = onodera;
            ////cargoSerch.CargoID = dire.Id; //relacion con los id para asignar empleado con cargo

            ////cargoEmpleado cargoShinji = new cargoEmpleado();
            ////cargoShinji.empleado = shinji;
            ////cargoShinji.CargoID = admin.Id;



            ////de manera mas simple  -------------------------------->

            //empleado maxine = dataContext.empleado.First(car => car.Nombre.Equals("Maxine"));

            List<cargoEmpleado> listaCargoEmpleado = new List<cargoEmpleado>();
            //listaCargoEmpleado.Add(new cargoEmpleado {CargoID = 5, EmpleadoId = 7});
            //listaCargoEmpleado.Add(new cargoEmpleado { CargoID = 6, EmpleadoId = 8 });
            //listaCargoEmpleado.Add(new cargoEmpleado { CargoID = 5, EmpleadoId = 10 });

            listaCargoEmpleado.Add(new cargoEmpleado { });

            dataContext.cargoEmpleado.InsertAllOnSubmit(listaCargoEmpleado);
            dataContext.SubmitChanges();



            Principal.ItemsSource = dataContext.cargoEmpleado;
        }
    }
}
