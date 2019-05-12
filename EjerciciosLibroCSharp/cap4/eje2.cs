using System;

namespace eje2
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0;
            double numero = 0;
            double potencia = 0;
            double r = 0;

            Console.WriteLine("Ingrese Numero a elevar");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Potencia");
            potencia = int.Parse(Console.ReadLine());
            r = numero;

            for(int i= 0; i < potencia-1; i++)
            {
                resultado = numero * r;

                numero = resultado;
            }

    

            Console.Write("Resultado " + resultado);

            Console.ReadKey();
        }
    }
}
