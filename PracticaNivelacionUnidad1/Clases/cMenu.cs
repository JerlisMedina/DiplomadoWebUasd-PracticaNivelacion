using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PracticaNivelacionUnidad1.Clases;

namespace PracticaNivelacionUnidad1.Clases
{
    public class cMenu
    {
        public void mostrar() {
            string opcion = "";
            cPersona npersona = new cPersona();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("                     ==========================================================================");
                Console.WriteLine("                                     UNIVERSIDAD AUTONOMA DE SANTO DOMINGO      ");
                Console.WriteLine("                                                     UASD      ");
                Console.WriteLine("                                              FACULTAD DE CIENCIAS      ");
                Console.WriteLine("                                             ESCUELA DE INFORMATICA     ");
                Console.WriteLine("                     ==========================================================================");

                Console.WriteLine();
                Console.WriteLine("                     ==========================================================================");
                Console.WriteLine("                                         Practica De Nivelación Unidad I      ");
                Console.WriteLine("                     ==========================================================================");
                Console.WriteLine();


                Console.WriteLine("**************** ELIJA UNA OPCION DEL SIGUIENTE MENU *********************");
                Console.WriteLine("1 - Información Personal");
                Console.WriteLine("2 - Saludar Usuario");
                Console.WriteLine("3 - Promedio de 4 Notas");
                Console.WriteLine("4 - Calcular ITBIS 18% De Un Producto");
                Console.WriteLine("5 - Calcular Sueldo Neto De Un Empleado");
                Console.WriteLine("6 - Convertir de Centimetros a Pulgadas");
                Console.WriteLine("7 - Calcular Cuota De Prestamo Simple");
                Console.WriteLine("S - Presione la tecla 'S' para salir");
                Console.WriteLine("*************************************************************************");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        npersona.MostrarDatos();
                        break;
                    case "2":
                        cUtilidades.SaludarUsuario();
                        break;
                    case "3":
                        cUtilidades.CalcularNotas();
                        break;
                    case "4":
                        cUtilidades.CalcularItbis();
                        break;

                    case "5":
                        cUtilidades.CalcularSueldoNeto();
                        break;

                    case "6":
                        cUtilidades.CentimetrosPulgadas();
                        break;

                    case "7":
                        cUtilidades.CalcularCuotaPrestamo();
                        break;

                    default:
                        Console.WriteLine("<<<<<<<<<<< Hasta pronto!!! >>>>>>>>>>");
                        opcion = "s";
                        break;
                }

            } while (opcion != "s" & opcion != "S");

            Console.ReadKey();

        }
    }
}
