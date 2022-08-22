using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Facturacion_Electronica
{
    class Program
    {
        static void Main(string[] args)
        {
            Consola consola = new Consola(ConsoleColor.White);
            BD_Productos PDN = new BD_Productos();
            BD_Clientes CLN = new BD_Clientes();
            BD_Proveedores PRN = new BD_Proveedores();
            BD_Empleados EMN = new BD_Empleados();

            int opcion;
            
            do
            {
                Console.Clear();
                consola.Marco(30, 1, 80, 10); 
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(50, 1);
                Console.WriteLine("BIENVENIDO");
                Console.SetCursorPosition(45, 3); 
                Console.WriteLine("FACTURACIÓN ELECTRÓNICA");
                Console.SetCursorPosition(48, 4);
                Console.WriteLine("OPCIONES A ELEGIR=");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(52, 5);
                Console.WriteLine("PRODUCTOS");
                Console.SetCursorPosition(52, 6);
                Console.WriteLine("CLIENTES");
                Console.SetCursorPosition(52, 7);
                Console.WriteLine("PROVEEDORES");
                Console.SetCursorPosition(52, 8);
                Console.WriteLine("EMPLEADOS");
                Console.SetCursorPosition(52, 9);
                Console.WriteLine("SALIR");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(49, 5);
                Console.WriteLine("1. ");
                Console.SetCursorPosition(49, 6);
                Console.WriteLine("2. ");
                Console.SetCursorPosition(49, 7);
                Console.WriteLine("3. ");
                Console.SetCursorPosition(49, 8);
                Console.WriteLine("4. ");
                Console.SetCursorPosition(49,9);
                Console.WriteLine("5. ");
                opcion = consola.leerOpcion();
                Console.Read();
                switch (opcion)
                {
                    case 1:
                        int opcion2;
                        do
                        {
                            Console.Clear();
                            consola.Marco(30, 0, 100, 10);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(45, 1);
                            Console.WriteLine("BASE DE DATOS DE UN PRODUCTO");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.SetCursorPosition(52, 3);
                            Console.WriteLine("AGREGAR PRODUCTO");
                            Console.SetCursorPosition(52, 4);
                            Console.WriteLine("MOSTRAR PRODUCTO");
                            Console.SetCursorPosition(52, 5);
                            Console.WriteLine("BUSCAR Y MOSTRAR PRODUCTO");
                            Console.SetCursorPosition(52, 6);
                            Console.WriteLine("BUSCAR Y ACTUALIZAR DIRECCION");
                            Console.SetCursorPosition(52, 7);
                            Console.WriteLine("BUSCAR Y ACTUALIZAR PRECIO DEL PRODUCTO");
                            Console.SetCursorPosition(52, 8);
                            Console.WriteLine("BUSCAR Y ELIMINAR PRODUCTO");
                            Console.SetCursorPosition(52, 9);
                            Console.WriteLine("REGRESAR AL MENÚ PRINCIPAL");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(49, 3);
                            Console.WriteLine("1. ");
                            Console.SetCursorPosition(49, 4);
                            Console.WriteLine("2. ");
                            Console.SetCursorPosition(49, 5);
                            Console.WriteLine("3. ");
                            Console.SetCursorPosition(49, 6);
                            Console.WriteLine("4. ");
                            Console.SetCursorPosition(49, 7);
                            Console.WriteLine("5. ");
                            Console.SetCursorPosition(49, 8);
                            Console.WriteLine("6. ");
                            Console.SetCursorPosition(49, 9);
                            Console.WriteLine("7. ");
                            opcion2 = consola.leerOpcion2();
                            Console.Read();
                            switch (opcion2)
                            {
                                case 1:
                                    Console.Clear();
                                    PDN.AgregarN();
                                    Console.Read();
                                    break;
                                case 2:
                                    Console.Clear();
                                    PDN.MostrarN();
                                    Console.Read();
                                    break;
                                case 3:
                                    Console.Clear();
                                    PDN.Buscar_y_MostrarN();
                                    Console.Read();
                                    break;
                                case 4:
                                    Console.Clear();
                                    PDN.Buscar_y_ActualizarDireccionN();
                                    Console.Read();
                                    break;
                                case 5:
                                    Console.Clear();
                                    PDN.ActualizarPrecio();
                                    Console.Read();
                                    break;
                                case 6:
                                    Console.Clear();
                                    PDN.Buscar_y_EliminarN();
                                    Console.Read();
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
                        }
                        while (opcion2 != 7);
                        break;
                    case 2:
                        int opcion3;
                        do
                        {
                            Console.Clear();
                            consola.Marco(30, 0, 100, 10);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(45, 1);
                            Console.WriteLine("BASE DE DATOS DE UN CLIENTE");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.SetCursorPosition(52, 3);
                            Console.WriteLine("AGREGAR CLIENTE");
                            Console.SetCursorPosition(52, 4);
                            Console.WriteLine("MOSTRAR CLIENTE");
                            Console.SetCursorPosition(52, 5);
                            Console.WriteLine("BUSCAR Y MOSTRAR CLIENTE");
                            Console.SetCursorPosition(52, 6);
                            Console.WriteLine("BUSCAR Y ACTUALIZAR DIRECCION");
                            Console.SetCursorPosition(52, 7);
                            Console.WriteLine("BUSCAR Y ACTUALIZAR PRECIO DEL CLIENTE");
                            Console.SetCursorPosition(52, 8);
                            Console.WriteLine("BUSCAR Y ELIMINAR CLIENTE");
                            Console.SetCursorPosition(52, 9);
                            Console.WriteLine("REGRESAR AL MENÚ PRINCIPAL");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(49, 3);
                            Console.WriteLine("1. ");
                            Console.SetCursorPosition(49, 4);
                            Console.WriteLine("2. ");
                            Console.SetCursorPosition(49, 5);
                            Console.WriteLine("3. ");
                            Console.SetCursorPosition(49, 6);
                            Console.WriteLine("4. ");
                            Console.SetCursorPosition(49, 7);
                            Console.WriteLine("5. ");
                            Console.SetCursorPosition(49, 8);
                            Console.WriteLine("6. ");
                            Console.SetCursorPosition(49, 9);
                            Console.WriteLine("7. ");
                            opcion3 = consola.leerOpcion3();
                            Console.Read();
                            switch (opcion3)
                            {
                                case 1:
                                    Console.Clear();
                                    CLN.AgregarN();
                                    Console.Read();
                                    break;
                                case 2:
                                    Console.Clear();
                                    CLN.MostrarN();
                                    Console.Read();
                                    break;
                                case 3:
                                    Console.Clear();
                                    CLN.Buscar_y_MostrarN();
                                    Console.Read();
                                    break;
                                case 4:
                                    Console.Clear();
                                    CLN.Buscar_y_ActualizarDireccionN();
                                    Console.Read();
                                    break;
                                case 5:
                                    Console.Clear();
                                    CLN.ActualizarMetodoDePago();
                                    Console.Read();
                                    break;
                                case 6:
                                    CLN.Buscar_y_EliminarN();
                                    Console.Read();
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
                        }
                        while (opcion3 != 7);
                        break;
                    case 3:
                        int opcion4;
                        do
                        {
                            Console.Clear();
                            consola.Marco(30, 0, 100, 10);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(45, 1);
                            Console.WriteLine("BASE DE DATOS DE UN PROVEEDOR");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.SetCursorPosition(52, 3);
                            Console.WriteLine("AGREGAR PROVEEDOR");
                            Console.SetCursorPosition(52, 4);
                            Console.WriteLine("MOSTRAR PROVEEDOR");
                            Console.SetCursorPosition(52, 5);
                            Console.WriteLine("BUSCAR Y MOSTRAR PROVEEDOR");
                            Console.SetCursorPosition(52, 6);
                            Console.WriteLine("BUSCAR Y ACTUALIZAR DIRECCION");
                            Console.SetCursorPosition(52, 7);
                            Console.WriteLine("BUSCAR Y ACTUALIZAR PRECIO DEL PROVEEDOR");
                            Console.SetCursorPosition(52, 8);
                            Console.WriteLine("BUSCAR Y ELIMINAR PROVEEDOR");
                            Console.SetCursorPosition(52, 9);
                            Console.WriteLine("REGRESAR AL MENÚ PRINCIPAL");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(49, 3);
                            Console.WriteLine("1. ");
                            Console.SetCursorPosition(49, 4);
                            Console.WriteLine("2. ");
                            Console.SetCursorPosition(49, 5);
                            Console.WriteLine("3. ");
                            Console.SetCursorPosition(49, 6);
                            Console.WriteLine("4. ");
                            Console.SetCursorPosition(49, 7);
                            Console.WriteLine("5. ");
                            Console.SetCursorPosition(49, 8);
                            Console.WriteLine("6. ");
                            Console.SetCursorPosition(49, 9);
                            Console.WriteLine("7. ");
                            opcion4 = consola.leerOpcion4();
                            Console.Read();
                            switch (opcion4)
                            {
                                case 1:
                                    Console.Clear();
                                    PRN.AgregarN();
                                    Console.Read();
                                    break;
                                case 2:
                                    Console.Clear();
                                    PRN.MostrarN();
                                    Console.Read();
                                    break;
                                case 3:
                                    Console.Clear();
                                    PRN.Buscar_y_MostrarN();
                                    Console.Read();
                                    break;
                                case 4:
                                    Console.Clear();
                                    PRN.Buscar_y_ActualizarDireccionN();
                                    Console.Read();
                                    break;
                                case 5:
                                    Console.Clear();
                                    PRN.ActualizarNombreDeLaEmpresa();
                                    Console.Read();
                                    break;
                                case 6:
                                    Console.Clear();
                                    PRN.Buscar_y_EliminarN();
                                    Console.Read();
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
                        }
                        while (opcion4 != 7);
                        break;
                    case 4:
                        int opcion5;
                        do
                        {
                            Console.Clear();
                            consola.Marco(30, 0, 100, 10);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(45, 1);
                            Console.WriteLine("BASE DE DATOS DE UN EMPLEADO");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.SetCursorPosition(52, 3);
                            Console.WriteLine("AGREGAR EMPLEADO");
                            Console.SetCursorPosition(52, 4);
                            Console.WriteLine("MOSTRAR EMPLEADO");
                            Console.SetCursorPosition(52, 5);
                            Console.WriteLine("BUSCAR Y MOSTRAR EMPLEADO");
                            Console.SetCursorPosition(52, 6);
                            Console.WriteLine("BUSCAR Y ACTUALIZAR DIRECCION");
                            Console.SetCursorPosition(52, 7);
                            Console.WriteLine("BUSCAR Y ACTUALIZAR PRECIO DEL EMPLEADO");
                            Console.SetCursorPosition(52, 8);
                            Console.WriteLine("BUSCAR Y ELIMINAR EMPLEADO");
                            Console.SetCursorPosition(52, 9);
                            Console.WriteLine("REGRESAR AL MENÚ PRINCIPAL");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(49, 3);
                            Console.WriteLine("1. ");
                            Console.SetCursorPosition(49, 4);
                            Console.WriteLine("2. ");
                            Console.SetCursorPosition(49, 5);
                            Console.WriteLine("3. ");
                            Console.SetCursorPosition(49, 6);
                            Console.WriteLine("4. ");
                            Console.SetCursorPosition(49, 7);
                            Console.WriteLine("5. ");
                            Console.SetCursorPosition(49, 8);
                            Console.WriteLine("6. ");
                            Console.SetCursorPosition(49, 9);
                            Console.WriteLine("7. ");
                            opcion5 = consola.leerOpcion5();
                            Console.Read();
                            switch (opcion5)
                            {
                                case 1:
                                    Console.Clear();
                                    EMN.AgregarN();
                                    Console.Read();
                                    break;
                                case 2:
                                    Console.Clear();
                                    EMN.MostrarN();
                                    Console.Read();
                                    break;
                                case 3:
                                    Console.Clear();
                                    EMN.Buscar_y_MostrarN();
                                    Console.Read();
                                    break;
                                case 4:
                                    Console.Clear();
                                    EMN.Buscar_y_ActualizarDireccionN();
                                    Console.Read();
                                    break;
                                case 5:
                                    Console.Clear();
                                    EMN.ActualizarSueldo();
                                    Console.Read();
                                    break;
                                case 6:
                                    Console.Clear();
                                    EMN.Buscar_y_EliminarN();
                                    Console.Read();
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
                        }
                        while (opcion5 != 7);
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(35, 1);
                        Console.WriteLine("GRACIAS POR USAR LA FACTURACIÓN ELECTRONICA:)");
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 5);
            
        }
       
    }

}
