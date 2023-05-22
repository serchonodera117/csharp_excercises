using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp__INotifyPropertyChanged
{
    public class Nombre_Xd: INotifyPropertyChanged
    {
        private string nombre, apellido, nombreCompleto;

        public event PropertyChangedEventHandler PropertyChanged; //para usarlo se tiene que exportar la lirería using System.ComponentModel;
                                                                  //esta herramienta permite cambiar las propiedades
        private void CambioDeLaPropiedad( string propiedad)
        {                          //propiedad que se cambiará

            if(PropertyChanged != null)                         //esta condición se aplica cuando se hace un cambio en la caja de texti (en este caso)
            {                                                   //"Si la propiedad cambiada es diferente de nulo" o "si la propiedad no se ha cambiado"
                PropertyChanged(this, new PropertyChangedEventArgs (propiedad)); 
            }

        }

        public string Nombre
        {
            get { return nombre; }
            set {
                nombre = value;
                CambioDeLaPropiedad("Nombre_Completo");
               }
        }

        public string Apellido
        {
            get { return apellido; }
            set { 
                apellido = value;
                CambioDeLaPropiedad("Nombre_Completo"); //aquí se puede ver el cambio de la propiedad nombre completo.
                }
        }

        public string Nombre_Completo
        {
            get {
                nombreCompleto = nombre + " " + apellido;
                return nombreCompleto;
                 }
            set {

                CambioDeLaPropiedad("Nombre");
                CambioDeLaPropiedad("Apellido");
            }
        }
    }
}
