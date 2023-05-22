using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Cshap_Clases_e_Insancias
{
    class Funciones
    {
        public static void fuguraCirculo()
        {
            int parametro;
            Circulo miCirculo; //creación del objeto de tipo circulo. Variable/objeto de tipo circulo 

            miCirculo = new Circulo(); //iniciación de variable/objeto de tipo circulo. Instanciar una clase
                                       //Instanciación. Ejemplarizacipon. Creación de ejemplar de clase (sinonimos)

            Console.WriteLine($"el calculo de alrea es: {miCirculo.calculoArea(5)}");
            Console.ReadLine();

            Circulo circulo2 = new Circulo();

            Console.WriteLine($"objeto circulo2, Area: {miCirculo.calculoArea(9)}");
            Console.ReadLine();
            Console.Write("ingrese oarametro nuevo para el objeto mi circulo ");
            parametro = int.Parse(Console.ReadLine());
            Console.WriteLine($"el calculo de alrea con el pi cambiado es: {miCirculo.calculoArea(parametro)}");
            Console.ReadLine();
        }

        public static void FiguraEsfera()
        {
            int r;
            Esfera LeEsfere = new Esfera();

            Console.WriteLine("Ingrese el radio de la esfera:  ");
            r = int.Parse(Console.ReadLine());

            Console.WriteLine($"El Volumern del objeto esfera es [{LeEsfere.calculoVolumen(r)}Cm^3]");
            Console.ReadLine();
        }

        public static void InteracciónCajero()
        {
            Cuenta usuario = new Cuenta();

            Console.Write("Ingresa tu nombre: ");
            string nombreUsuario = Console.ReadLine();
            usuario.Nombre = nombreUsuario;
            Console.Write($"¿[{nombreUsuario}] su saldo actual es de {usuario.saldo}\n¿legustaría retirar o ingresar dinero? (escriba ingresar o retirar según sea su caso): ");        
            string desicion = Console.ReadLine();

            float cantidad;

            if (desicion == "Retirar" || desicion == "retirar")
            {
                Console.Write("escriba la cantidad a retirar: ");
                cantidad = float.Parse(Console.ReadLine());

                Console.Write($"{nombreUsuario} usted ha retirado: [{cantidad}] \nSu saldo anterior era de: [{usuario.saldo}] \nSu saldo actual es de: [{usuario.Retiro(cantidad)}]");
                Console.ReadLine();
            }
            else if (desicion == "Ingresar" || desicion == "ingresar")
            {
                Console.Write("escriba la cantidad a ingresar: ");
                cantidad = float.Parse(Console.ReadLine());

                Console.Write($"{nombreUsuario} usted ha ingresado: [{cantidad}] \nSu saldo anterior era de: [{usuario.saldo}] \nSu saldo actual es de: [{usuario.Ingreso(cantidad)}$]");
                Console.ReadLine();
            }

            else { Console.WriteLine("Esa nomenclatura no existe, intenta hacerla de nuevo"); }

        }


        public static void LanzamientoDados()
        {
            Dado dado1 = new Dado();
            Dado dado2 = new Dado();
            Dado dado3 = new Dado();
            int puntos = 0;  
            char Lanzamiento;

            do
            {
                Console.Clear();
                Console.Write("Oprima [t] para tirar el dado \nOprima [s] para salir \n\nEscriba la letra correspondiente: ");
                Lanzamiento = Console.ReadKey().KeyChar;
               
                switch (Lanzamiento)
                {
                    case 't':
                            Console.Clear();
                        Console.WriteLine($"El dado 1 dio la cara de [{dado1.Lanzamiento_1(puntos)} puntos]");
                        Console.WriteLine($"El dado 2 dio la cara de [{dado2.Lanzamiento_2(puntos)} puntos]");
                        Console.WriteLine($"El dado 3 dio la cara de [{dado3.Lanzamiento_3(puntos)} puntos]");
                        break;


                    case 's':
                        Console.Clear();
                        Console.WriteLine("Has seleccionado salir");
                        break;

                    default: Console.Clear();
                        Console.WriteLine("Caracter invalido");
                        break;
                }
                Console.ReadKey();
            } while (Lanzamiento != 's');

        }

    }
}
