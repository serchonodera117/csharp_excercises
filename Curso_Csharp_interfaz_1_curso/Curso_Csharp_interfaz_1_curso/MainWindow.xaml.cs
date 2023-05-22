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

namespace Curso_Csharp_interfaz_1_curso
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Grid miGrid = new Grid();                    // La programación de interfaces en c# se hace por capas,
            //                                             // primero se instancia la capa donde va todo Grid, la 
            //this.Content = miGrid;                       // instrucción this.content, envía la instancia a la ventana 
            //                                             // los botonos y aditamentos similares se instancian como
            //Button miBoton = new Button();               // ojetos en la programación orientada a onjetos, sus propiedades 
            //                                             // se programan cual propiedad de un objeto, (nombre del objeto).propiedad
            //miBoton.Width = 150;                            
            //miBoton.Height = 80;
            //miBoton.Background = Brushes.Aqua;

            //WrapPanel miWrap = new WrapPanel();         // La declaración del WarpPanel es para personalizar los elementos del
            //                                            // objeto, ya que quí es donde se guardan, cual etiqetas del html   
            //                                            // ejemplo <WarpPanel> -personalización del boton </warpPanel>
            //TextBlock txt1 = new TextBlock();           
            //txt1.Foreground = Brushes.White;
            //txt1.Text = "CLic";
            //txt1.FontSize = 18;

            //miWrap.Children.Add(txt1);                   // Para añadir la configuración al warpPanel, se requiere de la nomenclatura
            //                                             // (nombre del WarpPanel).Children.Add(nombre del onjeto).
            //TextBlock txt2 = new TextBlock();            // La instrucción children  hace mencionar que es "hija" del onjeto/instancia  
            //txt2.Foreground = Brushes.Violet;            // WarpPanel
            //txt2.FontSize = 18;
            //txt2.Text = " Enviar";

            //miWrap.Children.Add(txt2);

            //TextBlock txt3 = new TextBlock();
            //txt3.FontSize = 18;

            //txt3.Text = " Dale";

            //miWrap.Children.Add(txt3);

            //miBoton.Content = miWrap;                     //finalmente, el contenido del botón guarda el warpPanel

            //miGrid.Children.Add(miBoton);                //y el Grid, guarda el boton.

        }



        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<eventos funciones del Boton>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        string a = "prueba.jpg";
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has desovedecido hijo de tu puta madre, estoy mamadisimo");
        }
        private void BotonPermitido(object sender, RoutedEventArgs e)
        {
            Console.WriteLine($"Canridad indicada de Texto: [{a}]");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)                 //La forma en la que se programan los 
        {                                                                             //eventos de un botón, pueden ser de 
            MessageBox.Show("Poco Texto");                                            // forma automática, generando el nombre
        }                                                                             //predeterminado o a mano como una funcion normal

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("le has dado al Panel");
        }
    }                                                                                 //los parametros que tiene, son obligatorios
}                                                                                     //de lo contrario da error 
