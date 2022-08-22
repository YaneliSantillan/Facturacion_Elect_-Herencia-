using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Facturacion_Electronica
{
    public class Consola
    {
        public ConsoleColor colorTextoDeaulft;
        public Consola(ConsoleColor _colorTextoDeaulft)
        {
            this.colorTextoDeaulft = _colorTextoDeaulft;
        }
        public void Marco(int x, int y, int x2, int y2)
        {
            Escribir(x, y, ConsoleColor.DarkRed, "╔");
            Escribir(x2, y2, ConsoleColor.DarkRed, "╝");
            Escribir(x, y2, ConsoleColor.DarkRed, "╚");
            Escribir(x2, y, ConsoleColor.DarkRed, "╗");
            for (int i = x + 1; i < x2; i++)
            {
                Escribir(i, y, ConsoleColor.DarkYellow, "═");
                Escribir(i, y2, ConsoleColor.DarkYellow, "═");
            }
            for (int i = y + 1; i < y2; i++)
            {
                Escribir(x, i, ConsoleColor.DarkYellow, "║");
                Escribir(x2, i, ConsoleColor.DarkYellow, "║");
            }
        }
        public void Escribir(int left, int top, ConsoleColor color, String Texto)
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = color;
            Console.Write(Texto);
            Console.ForegroundColor = colorTextoDeaulft;
        }
        public int leerNumeroEntero(int left, int top)
        {
            int valor;
            do
            {
                Console.SetCursorPosition(left, top); Console.Write("          ");

                Console.SetCursorPosition(left, top);
            } while (!int.TryParse(Console.ReadLine(), out valor));
            return valor;
        }
        public int leerOpcion()
        {
            int opcion = 0;
            do
            {
                Escribir(25, 14, ConsoleColor.White, "Ingrese una opción: ");
                opcion = leerNumeroEntero(45, 14);
            } while (opcion <= 0 || opcion > 6);
            return opcion;
        }
        public int leerOpcion2()
        {
            int opcion2 = 0;
            do
            {
                Escribir(25, 14, ConsoleColor.White, "Ingrese una opción: ");
                opcion2 = leerNumeroEntero(45, 14);
            } while (opcion2 <= 0 || opcion2 > 8);
            return opcion2;
        }
        public int leerOpcion3()
        {
            int opcion3 = 0;
            do
            {
                Escribir(25, 14, ConsoleColor.White, "Ingrese una opción: ");
                opcion3 = leerNumeroEntero(45, 14);
            } while (opcion3 <= 0 || opcion3 > 8);
            return opcion3;
        }
        public int leerOpcion4()
        {
            int opcion4 = 0;
            do
            {
                Escribir(25, 14, ConsoleColor.White, "Ingrese una opción: ");
                opcion4 = leerNumeroEntero(45, 14);
            } while (opcion4 <= 0 || opcion4 > 8);
            return opcion4;
        }
        public int leerOpcion5()
        {
            int opcion5 = 0;
            do
            {
                Escribir(25, 14, ConsoleColor.White, "Ingrese una opción: ");
                opcion5 = leerNumeroEntero(45, 14);
            } while (opcion5 <= 0 || opcion5 > 8);
            return opcion5;
        }
    }
}
