using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Csharp_Getters_y_Seters
{
    partial class Auto
    {
        private int llantas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapicería;

        public Auto()
        {
            llantas = 4;
            largo = 2.17;
            ancho = 1.80;
        }
        public Auto(double otroLargo, double otroAncho)
        {
            llantas = 4;
            largo = otroLargo;
            ancho = otroAncho;
        }
    }

    partial class Auto 
    { 
        public string InfoCoche() { return $"info coche \n[{llantas} llantas] \n[{largo}mts de largo] \n[{ancho}mts de ancho]"; }

        public void SetInfoExtra(bool climatizador, string tapicería) 
        {
            this.climatizador = climatizador;
            this.tapicería = tapicería;
        }

        public string GetExtras() { return $"climatizador: [{climatizador}] \n Tapicería: [{tapicería}]"; }

       
    }
}
