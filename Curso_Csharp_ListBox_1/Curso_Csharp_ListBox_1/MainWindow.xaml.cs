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

namespace Curso_Csharp_ListBox_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<poblacion> listaPoblacion = new List<poblacion>();

            listaPoblacion.Add(new poblacion() { Poblacion1 = "Kolima", Poblacion2 = "Colima", Temperatura1 = 30, Temperatura2 = 20, DiefrenciaTemperatura = 10});
            listaPoblacion.Add(new poblacion() { Poblacion1 = "Jalisco", Poblacion2 = "Monterrey", Temperatura1 = 15, Temperatura2 = 30, DiefrenciaTemperatura = 15});
            listaPoblacion.Add(new poblacion() { Poblacion1 = "Cdmx", Poblacion2 = "Morelos", Temperatura1 = 10, Temperatura2 = 15, DiefrenciaTemperatura = 5 });
            listaPoblacion.Add(new poblacion() { Poblacion1 = "Hidalgo", Poblacion2 = "Yucatán", Temperatura1 = 7, Temperatura2 = 35, DiefrenciaTemperatura = 28 });
            Lista_de_Población.ItemsSource = listaPoblacion;    
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (Lista_de_Población.SelectedItem != null)
            {
                MessageBox.Show($"{(Lista_de_Población.SelectedItem as poblacion).Poblacion1} " + " " +
                                $"{(Lista_de_Población.SelectedItem as poblacion).Temperatura1} °C" + " " +
                                $"{(Lista_de_Población.SelectedItem as poblacion).Poblacion2}" + " " +
                                $"{(Lista_de_Población.SelectedItem as poblacion).Temperatura2} °C" + "    " +
                                $"La diferencia de temperatura es : {(Lista_de_Población.SelectedItem as poblacion).DiefrenciaTemperatura}"
                                );
                                 
            }
            else { MessageBox.Show("Seleccione un elemento no sea imecil");}

        }
    }

    public class poblacion
    {
        public string Poblacion1 { get; set; }
        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }
        public int Temperatura2 { get; set; }

        public int DiefrenciaTemperatura { get; set;}

    }
}
