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
using System.Configuration;   //se necesita de esta referencia/librería para crear una cadena de conexión a la Database
using System.Data.SqlClient;  // se necesita para enlazar con el origen de datos 
using System.Data;

namespace Curso_Csharp_BaseDeDatos_Pedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;
        public MainWindow()
        {
            InitializeComponent();
            //se crea una cadena de conexión para poder conectar el proyecto con una base de datos
            //se usa para conectar la aplicación con el origen de datos.

            string miConexion = ConfigurationManager.ConnectionStrings["Curso_Csharp_BaseDeDatos_Pedidos.Properties.Settings.miPrimerDataBaseConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);
            MuestaClientes();
            MuestraTodosPedidos();
        }

        //metodo para extraer información de la tabla cliente.>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        private void MuestaClientes()
        {
            try
            {
                string consulta = "SELECT * FROM CLIENTE";

                SqlDataAdapter miAdaptadorSQL = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSQL)
                {
                    DataTable clientesTabla = new DataTable();
                    //rellenar información del DataTable (se utiliza el metodo fill).
                    miAdaptadorSQL.Fill(clientesTabla);

                    listaClientes.DisplayMemberPath = "nombre";            //especificar que columna se quiere mostrar (en este caso el nombre de los clientes).
                    listaClientes.SelectedValuePath = "Id";                //especificar la selección de id
                    listaClientes.ItemsSource = clientesTabla.DefaultView; //especificar de donde viene la información
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //Mostrar pedidos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        private void MuestraPedidos()
        {

            try
            {

                //creacion de objeto pedido (p)                       
                string consulta2 = " SELECT* FROM PEDIDOS P INNER JOIN CLIENTE C ON C.ID = P.cCliente WHERE C.ID = @ClienteId";
                //Nombre del parametro.

                //Permite operar una operación aql con parametro 
                SqlCommand sqlComando = new SqlCommand(consulta2, miConexionSql);

                //recibir los registros que se encuentren en una consulta parametrica.
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

                using (miAdaptadorSql)
                {
                    sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);

                    DataTable pedidoTabla = new DataTable();
                    //rellenar información del DataTable (se utiliza el metodo fill).
                    miAdaptadorSql.Fill(pedidoTabla);


                    pedidosCliente.DisplayMemberPath = "fechaPago";
                    pedidosCliente.SelectedValuePath = "Id";
                    pedidosCliente.ItemsSource = pedidoTabla.DefaultView;
                }

            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void MuestraTodosPedidos() //mostrar todos los pedidos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        {
            try
            {
                string consulta3 = "SELECT *, CONCAT (CCliente, ' ', fechaPago, ' ',formaPago) AS INFOCOMPLETA FROM PEDIDOS";
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta3, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable pedidosTabla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTabla);

                    todosPedidos.DisplayMemberPath = "INFOCOMPLETA";
                    todosPedidos.SelectedValuePath = "Id";
                    todosPedidos.ItemsSource = pedidosTabla.DefaultView;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)//eliminar de la lista de pedidos>>>>>>>>>>>>>>>>>>>>
        {
            try
            {
                string consulta4 = " DELETE FROM PEDIDOS WHERE ID=@PEDIDOID";

                SqlCommand miSqlComand = new SqlCommand(consulta4, miConexionSql);

                miConexionSql.Open();

                miSqlComand.Parameters.AddWithValue("@PEDIDOID", todosPedidos.SelectedValue);
                miSqlComand.ExecuteNonQuery();

                miConexionSql.Close();

                MessageBox.Show("Ha eliminado la fecha del pedido numero  [" + todosPedidos.SelectedValue.ToString() + "]");

                MuestraTodosPedidos();
            }catch(Exception error)
            {
                MessageBox.Show($"{error.ToString()} \n\n\n Debe seleccionar un pedido de la lista de pedidos \n NO SEA IMBECIL!!!");
                miConexionSql.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//añadir nombre>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        {
            try
            {
                string consulta4 = "INSERT INTO CLIENTE (NOMBRE) VALUES (@NOMBRE)";

                SqlCommand miSqlComand = new SqlCommand(consulta4, miConexionSql);

                miConexionSql.Open();

                miSqlComand.Parameters.AddWithValue("@NOMBRE", insertaCliente.Text);
                miSqlComand.ExecuteNonQuery();

                miConexionSql.Close();

                MessageBox.Show("Has añadido a " + insertaCliente.Text + " " + " a la lista de clientes ");
                insertaCliente.Text = "";
                MuestaClientes();
            }catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                insertaCliente.Text = "";
                miConexionSql.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//borrar nombres >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        {
            try
            {
                string consulta4 = " DELETE FROM CLIENTE WHERE ID=@CLIENTE";

                SqlCommand miSqlComand = new SqlCommand(consulta4, miConexionSql);

                miConexionSql.Open();

                miSqlComand.Parameters.AddWithValue("@CLIENTE", listaClientes.SelectedValue);
                miSqlComand.ExecuteNonQuery();

                miConexionSql.Close();

                MessageBox.Show($"Ha borrado el nombre del cliente seleccionado");

                MuestaClientes();
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.ToString()} \n\n\n Debe seleccionar un cliente de la lista de clientes \n NO SEA IMBECIL!!!");
                miConexionSql.Close();
            }
        }

        private void listaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)//doble clic para mostrar la fecha. 
        {                                                                                 //doble clic puesto que lanzaba excepciones
            MuestraPedidos();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Edición ventanaActualizar = new Edición((int)listaClientes.SelectedValue);
            ventanaActualizar.Show();
            
            try
            {
                string consulta = "SELECT nombre FROM CLIENTE WHERE Id=@ClId";
                SqlCommand miSqlcommand = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSQL = new SqlDataAdapter(miSqlcommand);

                using (miAdaptadorSQL)
                {
                    miSqlcommand.Parameters.AddWithValue("@ClId", listaClientes.SelectedValue);
                    
                    DataTable clientesTabla = new DataTable();

                    miAdaptadorSQL.Fill(clientesTabla);

                    ventanaActualizar.nombreActualiza.Text = clientesTabla.Rows[0]["nombre"].ToString();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());


            }

         

        }


        private void insertaCliente_MouseEnter(object sender, MouseEventArgs e) //borrar el texto de la caja de texto al pasar el mouse por arriba
        {
            string C = insertaCliente.Text;

            if (C == "Cliente")
            {
                insertaCliente.Clear();
            }
        }

        private void insertaCliente_MouseLeave(object sender, MouseEventArgs e)
        {
            string C = insertaCliente.Text;
           
            if(C == "")
            {
                insertaCliente.Text = "Cliente";
            }

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            MuestaClientes();
        }
    }
}
