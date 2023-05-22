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

namespace Curso__Csharp_Dependency_Properties
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Creación de una propiedad

       public int MyPropiedad
        {
            get { return (int)GetValue(MyNuevaDeoendencia); }
            set { SetValue(MyNuevaDeoendencia, value); }
        }

        //registro de la propiedad, para poderla utilizar en la aplicación
        public static readonly DependencyProperty MyNuevaDeoendencia =
          DependencyProperty.Register("MyPropiefaf", typeof(int), typeof(MainWindow), new PropertyMetadata (0));
                                                        
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
