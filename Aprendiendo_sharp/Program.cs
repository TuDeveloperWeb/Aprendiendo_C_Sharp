using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_sharp
{
    internal class Program // Esto es una clase
    {
        //Para agregar una variable float se pone al ultimo una F
        static float pi = 3.1416f;
        static String nombre="Oscar";

        static void Main(string[] args) //Esto es un metodo
        {
            //Podemos leer las variables estaticas
            Console.WriteLine(pi);
            Console.WriteLine("Bienvenido {0} ", nombre);
            Console.ReadLine();

        }

    }
}
