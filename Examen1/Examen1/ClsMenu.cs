using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class ClsMenu
    {
        private static int opcion = 0;
        

        public static void desplegar() 
        {
            do
            {
               
             
                DateTime fecha = DateTime.Now;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hoy es: {fecha.Day}/{fecha.Month}/{fecha.Year} y son las: {fecha.Hour}:{fecha.Minute}");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("-----MENU PRINCIPAL-----");
                Console.WriteLine(" ");
                Console.WriteLine("1- Agregar Empleados");
                Console.WriteLine("2- Consultar Empleados");
                Console.WriteLine("3- Modificar Empleados");
                Console.WriteLine("4- Borrar Empleados");
                Console.WriteLine("5- Inicializar Arreglos");
                Console.WriteLine("6- Reportes");
                Console.WriteLine("7- Salir");
                Console.WriteLine(" ");
                Console.WriteLine("Por favor digite una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);



                switch (opcion)
                {
                    case 1: ClsEmpleado.AgregarEmpleado(); break;
                    case 2: ClsEmpleado.ConsultarEmpleados(); break;
                    case 3: ClsEmpleado.ModificarEmpleados(); break;
                    case 4: ClsEmpleado.BorrarEmpleado(); break;
                    case 5: ClsEmpleado.InicializarArreglo(); break;
                    case 6: ClsSubmenu.SubMenuReportes(); break;
                    case 7:

                        Console.WriteLine("Has elegido salir del programa");
                        break;
                }

                if (opcion < 1 || opcion >7)
                {
                   
                    Console.WriteLine("Ingresa una opcion correcta (1 al 7)");
                    Console.WriteLine(" ");
                }
            } while (opcion!=7);
        }
    }
}
