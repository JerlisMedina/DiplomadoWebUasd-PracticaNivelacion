using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaNivelacionUnidad1.Clases
{
    public class cPersona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string apodo { get; set; }
        public string fechaNacimiento { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string pais { get; set; }
        public string ciudad { get; set; }
        public string direccion { get; set; }
        public string lugarTrabajo { get; set; }
        public float sueldo { get; set; }
        public cPersona() { }

        public cPersona(string pNombre, string pApellido, string pApodo, string pFechaNacimiento, string pTelefono, string pCelular, 
                 string pPais, string pCiudad, string pDireccion, string pLugarTrabajo, float pSueldo)
        {
            nombre = pNombre;
            apellido =  pApellido;
            apodo = pApodo;
            fechaNacimiento = pFechaNacimiento;
            telefono = pTelefono;
            celular = pCelular;
            pais = pPais;
            ciudad = pCiudad;
            direccion = pDireccion;
            lugarTrabajo = pLugarTrabajo;
            sueldo = pSueldo;
        }

        public void MostrarDatos() {

            Console.WriteLine();
            Console.WriteLine("                     ========================== INFORMACION PERSONAL ===================");
            Console.WriteLine();

            Console.WriteLine("                                    Nombre: Manolo");

            Console.WriteLine("                                    Apellido: Gutierrez");

            Console.WriteLine("                                    Apodo: Manolito");

            Console.WriteLine("                                    Fecha de nacimiento: 25/05/1965");

            Console.WriteLine("                                    Telefono: (809) 999 9999");

            Console.WriteLine("                                    Celular: (829) 999 9999");

            Console.WriteLine("                                    Pais: Republica Dominicana");

            Console.WriteLine("                                    Ciudad: Puerto Plata");

            Console.WriteLine("                                    Direccion: San Felipe De Puerto Plata");

            Console.WriteLine("                                    Lugar de trabajo: Puerto Plata");

            Console.WriteLine("                                    Sueldo: RD$ 50,000.00");
            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public void IntroducirDatos()
        {

            Console.WriteLine();
            Console.WriteLine("                     ========================== DIGITE INFORMACION PERSONAL ===================");
            Console.WriteLine();

            Console.Write("                                    Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("                                    Apellido: ");
            apellido = Console.ReadLine();

            Console.Write("                                    Apodo: ");
            apodo = Console.ReadLine();

            Console.Write("                                    Fecha de nacimiento: ");
            fechaNacimiento = Console.ReadLine();

            Console.Write("                                    Telefono: ");
            telefono = Console.ReadLine();

            Console.Write("                                    Celular: ");
            celular = Console.ReadLine();

            Console.Write("                                    Pais: ");
            pais = Console.ReadLine();

            Console.Write("                                    Ciudad: ");
            ciudad = Console.ReadLine();

            Console.Write("                                    Direccion: ");
            direccion = Console.ReadLine();

            Console.Write("                                    Lugar de trabajo: ");
            lugarTrabajo = Console.ReadLine();

            Console.Write("                                    Sueldo: ");
            sueldo = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

    }
}
