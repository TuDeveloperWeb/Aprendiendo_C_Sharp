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
            //Metodos 
            IngreasrNumeros();
            Console.ReadLine();
        }

        static void IngreasrNumeros()
        {
            Console.WriteLine("Ingrese el primer numero :");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero :");
            int y=int.Parse(Console.ReadLine());

            Console.WriteLine("la suma es :"+sumar(x,y));
            Console.WriteLine("La resta es :"+restar(x, y));
            Console.WriteLine("La multiplicacion es :"+multiplicar(x, y));

            if (y == 0)
            {
                Console.WriteLine("Error!, Ingrese otro numero diferente a 0");
            }
            else
            {
                Console.WriteLine("La division es :" + dividir(x, y));
            }

   

        }

        static int sumar(int x, int y)
        {
            return x + y;
        }
        
        static int restar(int x, int y)
        {
            return (x - y);

        }
        
        static int multiplicar(int x, int y)
        {
            return x * y;
        }

        static float dividir(float x, float y)
        {
            return x / y;
        }
    }
}
