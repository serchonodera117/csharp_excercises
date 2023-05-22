using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Curso_Csharp_Expresiones_Regulares
{
    class Regulares
    {

        public static void uno()
        {
            string frase = "Hoal mi nombre es SerchOnodera, y mi numero de telefono es 312-150-6694";
            string patron = @"\d{3}-"; //para que la expresión regular encuentre el patrón, se neceita 
                                       //poner los caracteres a buscar entre comillas y corchetes.
                                       //string patron = "[caracter o caracteres a buscar]"
                                       //@"\d" es para buscar sucesiones numericas. @"\d{n}" para encontrar 
                                       //grupos de numeros de n tamaño.
            Regex myRegex = new Regex(patron);

            MatchCollection myColeccion = myRegex.Matches(frase);

            if (myColeccion.Count > 0) Console.WriteLine("Se han encontrado numeros");
            else Console.WriteLine("No se ha encontrado numeros");
        }


        public static void dos()
        {
            string frase = "Hoal mi nombre es SerchOnodera, y mi numero de telefono es (+34)312-150-6694 (+44)";
            string patron = @"\+34 || \+44"; 
            Regex myRegex = new Regex(patron);

            MatchCollection myColeccion = myRegex.Matches(frase);

            if (myColeccion.Count > 0) Console.WriteLine("Se han encontrado numeros de españa e ingleterra");
            else Console.WriteLine("No se ha encontrado numeros");
        }


        public static void unoB()
        {
            string frase = "mi web es https://www.PildorasInformaticas.com";
            string patron = "https?://(www.)?PildorasInformaticas.com";
            Regex myRegex = new Regex(patron);

            MatchCollection myColeccion = myRegex.Matches(frase);

            if (myColeccion.Count > 0) Console.WriteLine("Se han encontrado web");
            else Console.WriteLine("No se ha encontrado web ");
        }

        public static void dosB()
        {
            string frase = "mi correo es Sergio.lobo117@gmail.com";
            string patron = "(@)";
            string patron2 = "gmail";
            string patron3 = ".com";
            Regex myRegex = new Regex(patron + patron2 + patron3);

            MatchCollection myColeccion = myRegex.Matches(frase);

            if (myColeccion.Count > 0) Console.WriteLine("Se ha encontrado Correo Electronico");
            else Console.WriteLine("No se ha encontrado Correo Electronico ");

        }
    }
}
