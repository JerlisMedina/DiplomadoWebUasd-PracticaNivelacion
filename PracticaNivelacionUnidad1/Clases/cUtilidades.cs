using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PracticaNivelacionUnidad1.Clases;

namespace PracticaNivelacionUnidad1.Clases
{
    public class cUtilidades
    {
        public static void SaludarUsuario() {
            string nombre = "";

            Console.WriteLine();
            Console.WriteLine("                     ========================== DIGITE NOMBRE DE USUARIO ===================");
            Console.WriteLine();


            Console.Write("                                   Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("                                        Hola {0}", nombre.ToUpper() + "!!!");
            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void CalcularNotas() {
            float notaEnero = 0, notaFebro = 0, notaMarzo = 0, notaAbril = 0, promedio = 0;

            Console.WriteLine();
            Console.WriteLine("                     ========================== DIGITE LAS NOTAS CORRESPONDIENTES ===================");
            Console.WriteLine();


            Console.Write("                                   Nota Enero: ");
            notaEnero = float.Parse(Console.ReadLine());

            Console.Write("                                   Nota Febrero: ");
            notaFebro = float.Parse(Console.ReadLine());

            Console.Write("                                   Nota Marzo: ");
            notaMarzo = float.Parse(Console.ReadLine());

            Console.Write("                                   Nota Abril: ");
            notaAbril = float.Parse(Console.ReadLine());

            promedio = (notaEnero + notaFebro + notaMarzo + notaAbril)/4;

            Console.WriteLine();
            Console.WriteLine("                               El promedio de las notas digitadas es: {0}", promedio);
            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void CalcularItbis() {
            string producto = "";
            int cantidad = 0;
            double precio = 0, montoItbis =0;
            double subtotal = 0, total = 0;
            const double itbis = 0.18;

            Console.WriteLine();
            Console.WriteLine("                     ========================== DIGITE DATOS DEL PRODUCTO ===================");
            Console.WriteLine();


            Console.Write("                                   Producto: ");
            producto = Console.ReadLine();

            Console.Write("                                   Cantidad: ");
            cantidad = Int32.Parse(Console.ReadLine());

            Console.Write("                                   Precio: ");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("                               =================================");

            subtotal = (cantidad * precio);
            montoItbis = (subtotal * itbis);
            total = (subtotal + montoItbis);

            Console.WriteLine();
            Console.WriteLine("                               Sub-Total: {0}", subtotal);
            Console.WriteLine("                               ITBIS 18%: {0}", montoItbis);
            Console.WriteLine("                               Total: {0}", total);

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void CentimetrosPulgadas() {
            double cmt = 0, conv = 0;
            const double pulgadas = 2.54;

            Console.WriteLine();
            Console.WriteLine("                     ========================== CONVERTIR DE CENTIMETROS A PULGADAS ===================");
            Console.WriteLine();

            Console.Write("                                   Centimetros: ");
            cmt = double.Parse(Console.ReadLine());

            conv = Math.Round((cmt / pulgadas),2);

            Console.WriteLine();
            Console.WriteLine($"                                         {cmt} centimetro(s) convertido(s) a pulgada(s) es igual a: {conv}");

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void CalcularSueldoNeto() {
            string nombreEmpleado = "";
            string puesto = "";
            double sueldoBruto = 0, sueldoNeto = 0;
            double descuento = 0, tarifaHora = 0, horaTrabajada = 0;
            const double descPorciento = 0.10;

            Console.WriteLine();
            Console.WriteLine("                     ========================== DIGITE DATOS SIGUIENTES ===================");
            Console.WriteLine();

            Console.Write("                                   Empleado: ");
            nombreEmpleado = Console.ReadLine();

            Console.Write("                                   Puesto: ");
            puesto = Console.ReadLine();

            Console.Write("                                   Horas Trabajadas: ");
            horaTrabajada = double.Parse(Console.ReadLine());

            Console.Write("                                   Tarifas x Horas: ");
            tarifaHora = double.Parse(Console.ReadLine());
            Console.WriteLine("                               =================================");

            sueldoBruto = Math.Round((horaTrabajada * tarifaHora),2);
            descuento = Math.Round((sueldoBruto * descPorciento), 2);
            sueldoNeto = Math.Round((sueldoBruto - descuento), 2);

            Console.WriteLine();
            Console.WriteLine("                               Sueldo Bruto: {0}", sueldoBruto);
            Console.WriteLine("                               Descuento 10%: {0}", descuento);
            Console.WriteLine("                               Sueldo Neto: {0}", sueldoNeto);

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void CalcularCuotaPrestamo() {

            string tipoCuota = "", descCuota = "";
            double cuota = 0, monto = 0, interes = 0, tiempo = 0, pInteres = 0;

            Console.WriteLine();
            Console.WriteLine("                     ========================== DIGITE DATOS DEL PRESTAMO ===================");
            Console.WriteLine();

            Console.Write("                                   Monto: ");
            monto = double.Parse(Console.ReadLine());

            Console.Write("                                   Interes: ");
            interes = double.Parse(Console.ReadLine());

            pInteres = Math.Round((interes/100),2);

            Console.WriteLine("                                   Seleccione el tipo de prestamo");
            Console.WriteLine("                                   1 - Semanal ");
            Console.WriteLine("                                   2 - Quincenal ");
            Console.WriteLine("                                   3 - Mensual ");
            Console.WriteLine("                                   4 - Anual");

            tipoCuota = Console.ReadLine();

            switch (tipoCuota)
            {
                case "1":
                    tiempo = 7;
                    descCuota = "Semanal";
                    break;

                case "2":
                    tiempo = 15;
                    descCuota = "Quincenal";
                    break;
                case "3":
                    tiempo = 30;
                    descCuota = "Mensual";
                    break;
                case "4":
                    tiempo = 365;
                    descCuota = "Anual";
                    break;

                default:
                    break;
            }

            cuota = Math.Round(((monto * pInteres)/tiempo) + (monto / tiempo),2);

            Console.WriteLine($"                               La cuota a pagar por un prestamo de {monto} con un {interes} % de interes {descCuota} es {cuota}");

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

    }
}
