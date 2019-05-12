using System;

namespace eje1
{
    class Program
    {
        static void Main(string[] args)
        {

            string entrada = "";
            int i = 0;
            int numero = 0;

     
            Console.WriteLine("Ingrese un numero ");

            entrada = Console.ReadLine();
            numero = System.Int32.Parse(entrada);
            if (numero % 2 == 0)
            {
                Console.WriteLine("Numero es par");
            }
            else
            {
                Console.WriteLine("Numero es Impar");
            }

            Console.ReadKey();
        }
    }
}
