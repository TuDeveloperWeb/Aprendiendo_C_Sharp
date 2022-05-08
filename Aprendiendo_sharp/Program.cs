using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_sharp
{
    internal class Program // Esto es una clase
    {
       
        static void Main(string[] args) //Esto es un metodo
        {

            //Manejo de errores

            //try :Intenta el codigo ejecutar
            //Catch :Captura el error 

            //ManejodeError();


            //Tipos de Exception

            //1.FormatException: Cuando asignamos una letra en vez de un numero 
            //TipoErrorFormatException();

            //2.OverflowException: Si el tipo de dato no coincide con el valor que damos, es como darle un valor alto
            //TipoErrorOverflowException();

            //3.DivideByZeroException: Error al dividir por 0;
            TipoerrorDivideByZeroException();

            Console.ReadLine();

        }

        static void ManejodeError()
        {
            int numero;
            Console.WriteLine("Ingresa un numero");

            try
            {
                // Intentamos ejecutar el programa.
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("El valor ingresado es {0}", numero);
            }
            catch (Exception ex)
            {
             /* Este bloque lo ejecutará solo si existe algun error.
                En este bloque solo mostraremos un mensaje.
                Podemos mostrar un mensaje personalizado de esta forma*/
                //Console.WriteLine("El valor ingresado no es un numero");

             /* O podemos mostrar la excepción que nos de el programa
                mostrando el valor de la la variable*/
                Console.WriteLine(ex.Message);
            }

           
        }

        static void TipoErrorFormatException()
        {
            Console.WriteLine("Ingrese un numero por favor :");
            int numero;
            try
            {
                numero=int.Parse(Console.ReadLine());
                Console.WriteLine("El valor ingresado es :{0}",numero);
            }
            catch (FormatException error)
            {
                Console.WriteLine("El formato ingresado es incorrecto");
                Console.WriteLine(error.Message);
                                
            }
        }


        static void TipoErrorOverflowException()
        {
            Console.WriteLine("Ingrese un numero por favor :");
            int numero;

            try
            {
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("El valor ingresado es :{0}", numero);
            }
            catch (OverflowException error)
            {

                Console.WriteLine("El valor ingresado es demasiado alto al tipo de dato");
                Console.WriteLine(error.Message);
            }

        }

        static void TipoerrorDivideByZeroException()
        {
            Console.WriteLine("Ingrese el primer numero :");
            float numero;
            numero = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero :");
            float numero2;
            numero2 = float.Parse(Console.ReadLine());
            float resultado;
            try
            {
                resultado = numero / numero2;
                Console.WriteLine("El resultado es :{0}",resultado);
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("No se puede divir entre 0");
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine("Este mensaje siempre aparecera no importa el error");
            }

        }



    }
}
