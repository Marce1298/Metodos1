using System;

namespace Metodos1
{
    class Program
    {
        static void Main(string[] args)
        {

            mensajeEnPantalla();//un metodo se puede llamar las veces que se requiera.

            Console.WriteLine("Mensaje desde el mein");

            sumaNumeros(7, 9);

        }



        static void mensajeEnPantalla()
        {

            Console.WriteLine("Mensaje desde el método mensajeEnPantalla");


        }



        static void sumaNumeros(int num1, int num2)
        {
            
            Console.WriteLine($"La suma de los numeros es: {num1 + num2} ");

        }

    }
}
