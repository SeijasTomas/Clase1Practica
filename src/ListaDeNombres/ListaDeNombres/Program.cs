using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese nombre " + i + " :");
                string nombre;
                nombre = Console.ReadLine();
                nombres.Add(nombre);
            }
            Console.WriteLine("Nombres ordenados alfabeticamente:");
            nombres.Sort();

            foreach (string item in nombres)
            {
                Console.WriteLine(item);
            }
        }
    }
}
