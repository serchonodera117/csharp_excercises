using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Interfaces
{
    interface IAvisos
    {
        void MostrarAviso();

        string GetFecha();
    }


    class AvisosTrafico : IAvisos
    {

        private string remitente;
        private string fecha;
        private string mensaje;

        public AvisosTrafico()
        {
            remitente = "Peñin";
            mensaje = "Sancion cometida, Page antes de tres dias y recibirá una reducción del 50%";
            fecha = "none";
        }

        public AvisosTrafico(string remitente, string fecha, string mensaje)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        public void MostrarAviso() { Console.WriteLine( "mensaje {0} ha sido otorgado por {1} el día {2}", mensaje,remitente,fecha); }
        public string GetFecha() { return fecha; }


    }
}
