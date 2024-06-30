using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
       
        static StreamWriter Escribir;
        static void Main(string[] args)
        {
          
            int opcion = 0;
            int Identificacion = 0;




            Dictionary<int, Registro> registroGlobal = new Dictionary<int, Registro>();
            Dictionary<int, Matricula> registroMaterias = new Dictionary<int, Matricula>();
            Dictionary<int, Factura> registroFacturas = new Dictionary<int, Factura>();



            Registro[] resultadoRG = new Registro[0];
            Matricula[] resultadoRM = new Matricula[0];
            Factura[] resultadoFa = new Factura[0];


            bool continuar = true;

            {
                while (continuar)
                {

                    Console.Clear();
                    Console.WriteLine("Digite (1) para acceder al formulario de registro de estudiantes.");
                    Console.WriteLine("");
                    Console.WriteLine("Digite (2) para acceder al  formulario de matricula de materias.");
                    Console.WriteLine("");
                    Console.WriteLine("Digite (3) para realizar una busqueda a partir del numero de identificacion del estudiante.");
                    Console.WriteLine("");
                    Console.WriteLine("Digite (4) para eliminar o actualizar los datos  de un estudiante.");
                    Console.WriteLine("");
                    Console.WriteLine("Digite (5) para salir del sistema");
                    Console.WriteLine("");
                    
                 

                    opcion = int.Parse(Console.ReadLine());


                    switch (opcion)
                    {



                        case 1:

                            Console.WriteLine("Ingrese el numero de identificacion del estudiante:");
                            Identificacion = int.Parse(Console.ReadLine());


                            if (registroGlobal.ContainsKey(Identificacion))

                            {
                                Console.WriteLine("");
                                Console.WriteLine("-----------------Ya existe un registro con ese numero de Identificacion-----------------");
                                Console.WriteLine("");
                            }

                            Console.WriteLine("Ingrese el Nombre del estudiante:");
                            String nombre = Console.ReadLine();

                            Console.WriteLine("Ingrese el Primer apellido del estudiante:");
                            String primerApellido = Console.ReadLine();

                            Console.WriteLine("Ingrese el Segundo apellido del estudiante:");
                            String segundoApellido = Console.ReadLine();

                            Console.WriteLine("Ingrese el correo del estudiante:");
                            String correo = Console.ReadLine();

                            Console.WriteLine("Ingrese la nacionalidad del estudiante:");
                            String nacionalidad = Console.ReadLine();

                            Console.WriteLine("Ingrese el estado civil estudiante:");
                            String estadoCivil = Console.ReadLine();

                            Registro datosglobales = new Registro(nombre, primerApellido, segundoApellido, correo, nacionalidad, estadoCivil);

                            registroGlobal.Add(Identificacion, datosglobales);

                            Console.WriteLine("Listo Agregado");

                            Escribir = new StreamWriter("Archivo.txt", true);
                            Escribir.WriteLine(datosglobales.ToString());
                            Console.WriteLine("Listo Agregado a Archivo txt");
                            Escribir.Close();
                            Console.Clear();
                            break;

                        case 2:

                            Console.WriteLine("Ingrese el numero de identificacion del estudiante:  ");
                            Identificacion = int.Parse(Console.ReadLine());

                            if (registroGlobal.ContainsKey(Identificacion))
                            {

                                Console.WriteLine("Ingrese ingrese el valor de creditos de la materia");
                                string creditos = Console.ReadLine();
                                Console.WriteLine("");

                                Factura factura = new Factura();
                                Console.WriteLine("Recuerde:El precio de la materia de la materia es de 50 mil colones por materia");
                                Console.WriteLine("Ingrese la cantidad materias a llevar");
                                factura.materiasCan = int.Parse(Console.ReadLine());
                                Console.WriteLine("");



                                List<string> nombresMaterias = new List<string>();
                                string materia;

                                Console.WriteLine("Ingrese el nombre de las materias  (escriba 'fin' para terminar):");

                               
                                while (true)
                                {
                                    Console.Write("Nombre: ");
                                     materia= Console.ReadLine();

                                  
                                    if (materia.ToLower() == "fin")
                                        break;

                                    
                                    nombresMaterias.Add(materia);
                                }


                                Console.WriteLine("Escriba el tipo de pago que desea realizar Transferencia Bancaria, Sinpe o Efectivo");
                                factura.tipodePAGO = Console.ReadLine();
                                Console.WriteLine("");

                                Matricula datosMaterias = new Matricula(creditos, materia);
                                
                                registroMaterias.Add(Identificacion, datosMaterias);

                                factura.Calculofactura();
                                Console.WriteLine("");
                                Console.WriteLine("Gracias por usar nuestro sistema");
                                Console.ReadKey();
                            }

                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("-----------------La persona con ese numero de Identificacion, no esta registrada.-----------------");
                                Console.WriteLine("");

                            }



                            
                            break;

                        case 3:

                            Console.WriteLine("Para realizar una busqueda");
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el numero de Identificacion del estudiante:");
                            Identificacion = int.Parse(Console.ReadLine());


                            if (registroGlobal.ContainsKey(Identificacion))
                            {
                                Registro registro1 = registroGlobal[Identificacion];


                                Console.WriteLine("");
                                Console.WriteLine(resultadoRG);
                                Console.WriteLine("");

                                if (registroMaterias.ContainsKey(Identificacion))
                                {
                                    Matricula matricula1 = registroMaterias[Identificacion];

                                    Console.WriteLine("");
                                    Console.WriteLine(resultadoRM);
                                    Console.WriteLine("");

                                }
                                else
                                {

                                    Console.WriteLine("");
                                    Console.WriteLine("-----------------La persona con ese numero de Identificacion, no tienen materias asignadas-----------------");
                                    Console.WriteLine("");

                                }


                            }

                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("-----------------La persona con ese numero de Identificacion, no esta registrada.-----------------");
                                Console.WriteLine("");
                            }
                            Console.Clear();
                            break;


                        case 4:

                            Console.WriteLine("Ingrese el numero de Identificacion del estudiante:");
                                Identificacion = int.Parse(Console.ReadLine());

                            if (registroGlobal.ContainsKey(Identificacion))
                            {
                                do
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite (1) para eliminar el registro de un estudiante. ");
                                    Console.WriteLine("");

                                    Console.WriteLine("Digite (2) actualziar los datos de un estudiante.");
                                    Console.WriteLine("");

                                    Console.WriteLine("Digite (3) para volver al menu principal.");
                                    Console.WriteLine("");
                                    opcion = int.Parse(Console.ReadLine());

                                    switch (opcion)
                                    {
                                        case 1:
                                            registroGlobal.Remove(Identificacion);
                                            registroMaterias.Remove(Identificacion);
                                            Console.WriteLine("Los datos fueron eliminados con exito");
                                            break;

                                        case 2:
                                            Console.WriteLine("Ingrese el Nombre del estudiante:");
                                            nombre = Console.ReadLine();

                                            Console.WriteLine("Ingrese el Primer apellido del estudiante:");
                                            primerApellido = Console.ReadLine();

                                            Console.WriteLine("Ingrese el Segundo apellido del estudiante:");
                                            segundoApellido = Console.ReadLine();

                                            Console.WriteLine("Ingrese el correo del estudiante:");
                                             correo = Console.ReadLine();

                                            Console.WriteLine("Ingrese la nacionalidad del estudiante:");
                                            nacionalidad = Console.ReadLine();

                                            Console.WriteLine("Ingrese el estado civil estudiante:");
                                            estadoCivil = Console.ReadLine();
                                            Console.WriteLine("");


                                            Registro datosglobaless = new Registro(nombre, primerApellido, segundoApellido, correo, nacionalidad, estadoCivil);

                                            registroGlobal.Add(Identificacion,datosglobaless);
                                            

                                            break;


                                    }


                                } while (opcion != 3);

                            }

                            else
                            {

                                Console.WriteLine("");
                                Console.WriteLine("-----------------La persona con ese numero de Identificacion, no esta registrada.-----------------");
                                Console.WriteLine("");

                            }


                            break;




                        case 5:
                           
                            Environment.Exit(0);
                            break;


                    }


                }
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();


            }
        }
    }
}
    


