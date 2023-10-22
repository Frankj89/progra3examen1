using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class ClsSubmenu
    {
        

        static public void SubMenuReportes() 
        {

            int opcion = 0;
            do
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ");
                Console.WriteLine("--------SUB-MENU--------");
                Console.WriteLine(" ");
                Console.WriteLine("1- Consultar empleados");
                Console.WriteLine("2- Listar todos los empleados");
                Console.WriteLine("3- Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("4- Calcular y mostrar el salario más alto y el más bajo de todos los empleados");
                Console.WriteLine("5- Salir");
                Console.WriteLine(" ");
                Console.WriteLine("Por favor digite una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: ClsEmpleado.Consultar();break;
                    case 2: ClsEmpleado.ListarEmpleado(); break;
                    case 3: ClsEmpleado.PromedioSalarios(); break;
                    case 4: ClsEmpleado.SalarioMinMax(); break;
                    case 5:
                        Console.WriteLine("Find del programa");
                        break;
                    
                    
                        
                }
                if (opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Ingrese una opcion correcta(1 al 5)");
                }
            } while (opcion!=5);
        
        }
    
    }
}
