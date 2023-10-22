using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class ClsEmpleado
    {

        //Atributos
        static int cantidad = 3;
        static byte indice;
        static int posicion;
        static public string[] cedula = new string[cantidad];
        static public string[] nombre = new string[cantidad];
        static public string[] direccion = new string[cantidad];
        static public int[] telefono = new int[cantidad];
        static public int[] salario = new int[cantidad];

        //El constructor define como crear un objeto.
        public ClsEmpleado()
        {
            cantidad = 0;
            indice = 0;
            posicion = 0;
       
        
        }

        

        //Metodos

        public static void SalarioMinMax() 
        
        {
            for (int i = 0; i < cantidad; i++)
            {
                

                Console.WriteLine("El salario Maximo es: " + salario.Max());
                Console.WriteLine("El salario Minimo es: " + salario.Min());

                Console.ReadLine();
            }


        }
        public static void PromedioSalarios()

        {


            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                var promedio = salario.Average();


                Console.WriteLine("El Promedio de los salarios es: {0}", promedio);

                Console.ReadLine();
            }

            
        }
        public static void ListarEmpleado()

        {

            Console.WriteLine($"********** Lista de empleados ************");



            List<string> nombre = new List<string>();
            nombre.Sort();

            for (int i = 0; i < cantidad; i++)
            {

                Console.WriteLine(nombre[i]);



            }
            Console.ReadLine();

        }
        public static void BorrarEmpleado()


       
        {
            string ced = "";
            Console.Write("Digite la cedula: ");
            ced = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    
                    cedula[i] = " ";
                    Console.WriteLine("Se borro correctmente el empleado ");
                    Console.WriteLine(" ");
                    break;
                }
                else
                {
                    Console.WriteLine("El empleado no existe");
                }
            }

            

        }
        public static void InicializarArreglo() 
        { 
            cedula = Enumerable.Repeat("",cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            direccion = Enumerable.Repeat("", cantidad).ToArray();
            telefono = Enumerable.Repeat(0, cantidad).ToArray();
            salario = Enumerable.Repeat(0, cantidad).ToArray();
            Console.WriteLine("");
            Console.WriteLine("Se han inicializado los arreglos");
            Console.WriteLine(" ");

        }
    
        public static void Consultar() 
        {

            
            string ced = "";
            Console.Write("Digite la cedula del empleado: ");
            ced = Console.ReadLine();
            

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.WriteLine("Su nombre es: " + nombre[i]);
                    Console.WriteLine("Su Direccion es: " + direccion[i]);
                    Console.WriteLine("Su telefono es: " + telefono[i]);
                    Console.WriteLine("Su salario es: " + salario[i]);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    break;


                }
                else
                {
                    Console.WriteLine("No hay datos para mostrar");
                }

                Console.ReadLine();
            }

           

        }


        public static void AgregarEmpleado() 
        
        {
            char respuesta; ;

            do
            {
                Console.Clear();
                Console.WriteLine($"Ingrese la cedula ({posicion})");
                cedula[indice] = Console.ReadLine();
                Console.WriteLine($"Ingrese el Nombre ({posicion})");
                nombre[indice] = Console.ReadLine();
                Console.WriteLine($"Ingrese la Direccion ({posicion})");
                direccion[indice] = Console.ReadLine();
                Console.WriteLine($"Ingrese el numero de Telefono ({posicion})");
                int.TryParse(Console.ReadLine(), out telefono[indice]);
                Console.WriteLine($"Ingrese el Salario ({posicion})");
                int.TryParse(Console.ReadLine(), out salario[indice]);
                Console.WriteLine("Empleado agregado correctamente");
                Console.WriteLine("Desea agregar otro empleado (s/n):");
                respuesta = char.Parse(Console.ReadLine().ToLower());
                switch (respuesta)
                {
                    case 's':
                    case 'n': break;
                    
                    default:
                        Console.WriteLine("Digito una opcion incorrecta");
                        respuesta = 'n';
                        break;

                }
                indice++;
                posicion++;

            } while (respuesta.Equals('s'));
            

        }

        

        public static void ConsultarEmpleados()

        {
            Console.Clear();
            string ced = "";
            Console.Write("Digite la cedula: ");
            ced = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.Write($"\n Su nombre es: {nombre[i]}");
                    Console.Write($"\n Su Direccion es: {direccion[i]}");
                    Console.Write($"\n Su telefono es: {telefono[i]}");
                    Console.Write($"\n Su salario es: {salario[i]}");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    break;


                }

                
            }
        }
        public static void ModificarEmpleados() 
        {
            string ced = "";
            Console.Write("Digite la cedula: ");
            ced = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.Write("Digite el nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.Write("Digite la direccion: ");
                    direccion[i] = Console.ReadLine();
                    Console.Write("Digite el telefono: ");
                    int.TryParse(Console.ReadLine(), out telefono[i]);
                    Console.Write("Digite el salario: ");
                    int.TryParse(Console.ReadLine(), out salario[i]);
                    break;
                }
            }

        }

    }
}
