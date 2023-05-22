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
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;  
using System.Data;


namespace Curso_Csharp_BaseDeDatos_Pedidos
{
    /// <summary>
    /// Lógica de interacción para Edición.xaml
    /// </summary>
    public partial class Edición : Window
    {
        SqlConnection miConexionSql;
        private int z;
       

        public Edición(int elId)
        {
            z = elId;

            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["Curso_Csharp_BaseDeDatos_Pedidos.Properties.Settings.miPrimerDataBaseConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);
        }

        private void actualizarEnOtraVentena_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "UPDATE CLIENTE SET nombre=@nombre WHERE Id=" + z;

            SqlCommand miSqlComand = new SqlCommand(consulta, miConexionSql);
        
            miConexionSql.Open();

            miSqlComand.Parameters.AddWithValue("@nombre", nombreActualiza.Text);
            miSqlComand.ExecuteNonQuery();

            miConexionSql.Close();

            this.Close();
        }
    }

}
