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

namespace Curso_Csharp_RadioButtom
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            Rojo.Visibility = Visibility.Visible;
            Amarillo.Visibility = Visibility.Hidden;
            verde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            Amarillo.Visibility = Visibility.Visible;
            Rojo.Visibility = Visibility.Hidden;
            verde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            verde.Visibility = Visibility.Visible;
            Amarillo.Visibility = Visibility.Hidden;
            Rojo.Visibility = Visibility.Hidden;
        }

        private void AllAcrivation_Click(object sender, RoutedEventArgs e)
        {
            verde.Visibility = Visibility.Visible;
            Amarillo.Visibility = Visibility.Visible;
            Rojo.Visibility = Visibility.Visible;
        }

        private void Alldesactivation_Click(object sender, RoutedEventArgs e)
        {

            verde.Visibility = Visibility.Hidden;
            Amarillo.Visibility = Visibility.Hidden;
            Rojo.Visibility = Visibility.Hidden;
        }
    }
}
