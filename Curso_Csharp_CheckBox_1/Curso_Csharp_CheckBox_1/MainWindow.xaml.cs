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

namespace Curso_Csharp_CheckBox_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Ciudades> ListadeCiudades = new List<Ciudades>();

            ListadeCiudades.Add(new Ciudades() { nombreCiudad = "Washington" });
            ListadeCiudades.Add(new Ciudades() { nombreCiudad = "Moscú" });
            ListadeCiudades.Add(new Ciudades() { nombreCiudad = "Pekín" });
            ListadeCiudades.Add(new Ciudades() { nombreCiudad = "Berlin" });
            ListadeCiudades.Add(new Ciudades() { nombreCiudad = "Londres" });
            ListadeCiudades.Add(new Ciudades() { nombreCiudad = "París" });
            ListadeCiudades.Add(new Ciudades() { nombreCiudad = "Pyong Yang" });
            ListadeCiudades.Add(new Ciudades() { nombreCiudad = "Tokyo" });
            ListadeCiudades.Add(new Ciudades() { nombreCiudad = "Seul" });

            CiudadesCapitales.ItemsSource = ListadeCiudades;


            
        }

      

        private void TodasC_Checked(object sender, RoutedEventArgs e)
        {
            Washington.IsChecked = true;
            Moscu.IsChecked = true;
            Pekin.IsChecked = true;
            Berlin.IsChecked = true;
            Londres.IsChecked = true;
            Paris.IsChecked = true;
            PyongYang.IsChecked = true;
            Tokyo.IsChecked = true;
            Seul.IsChecked = true;
        }

        private void TodasC_Unchecked(object sender, RoutedEventArgs e)
        {
            Washington.IsChecked = false;
            Moscu.IsChecked = false;
            Pekin.IsChecked = false;
            Berlin.IsChecked = false;
            Londres.IsChecked = false;
            Paris.IsChecked = false;
            PyongYang.IsChecked = false;
            Tokyo.IsChecked = false;
            Seul.IsChecked = false;
        }


        private void Individual_Checked(object sender, RoutedEventArgs e)
        {
            if (Washington.IsChecked == true && Moscu.IsChecked == true && Pekin.IsChecked == true && Berlin.IsChecked == true && Londres.IsChecked == true && Paris.IsChecked == true && PyongYang.IsChecked == true && Tokyo.IsChecked == true && Seul.IsChecked == true)
            {
                TodasC.IsChecked = true;

            }
            else
            {
                TodasC.IsChecked = null;
            }
        }
        private void individual_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Washington.IsChecked == false && Moscu.IsChecked == false && Pekin.IsChecked == false && Berlin.IsChecked == false && Londres.IsChecked == false && Paris.IsChecked == false && PyongYang.IsChecked == false && Tokyo.IsChecked == false && Seul.IsChecked == false)
            {
                TodasC.IsChecked = false;

            }
            else
            {
                TodasC.IsChecked = null;
            }
        }
    }

    public class Ciudades
    {
        public string nombreCiudad { get; set; }


    }

}
