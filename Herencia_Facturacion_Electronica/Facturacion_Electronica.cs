using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Facturacion_Electronica
{
    public class ClaseMadre
    {
        public int Cedula;
        public string Nombre;
        public string Apellido;
        public double Telefono;
        public string Direccion;
        public string Email;

        public void AgregarN()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Ingrese los siguientes datos: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("PROXIMAMENTE.....:)");
            Console.Read();
        }
        public void MostrarN()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Datos Ingresados: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("PROXIMAMENTE.....:)");
            Console.Read();
        }
        public void Buscar_y_MostrarN()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Mostrar y Buscar Información: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("PROXIMAMENTE.....:)");
            Console.Read();
        }
        public void Buscar_y_ActualizarDireccionN()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Buscar y Actualizar Informacion: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("PROXIMAMENTE.....:)");
            Console.Read();
        }
        public void Buscar_y_EliminarN()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Buscar y Eliminar Informacion: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("PROXIMAMENTE.....:)");
            Console.Read();
        }

    }
}
