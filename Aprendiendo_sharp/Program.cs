using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales

            int x,y;
            Console.WriteLine("Ingrese el primer numero");
            x= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("El numero " + x + " es mayor que " + y);
            }
            else if(x == y)
            {
                Console.WriteLine("El numero "+x+" es igual que "+y);
            }
            else
            {
                Console.WriteLine("El numero " + x + " es menor que " + y);
            }

            Console.ReadLine();
        }
    }
}
