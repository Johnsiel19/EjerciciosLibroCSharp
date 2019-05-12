using System;

namespace eje3
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            float radianes = 0.0f;
            float result = 0.0f;


            Console.WriteLine("Ingrese cantidad de radianes  "); 
            entrada = Console.ReadLine();
            radianes = Convert.ToSingle(entrada);
            result = (3.14f * radianes) / 180;

            Console.Write("Resultado es " + result);
            Console.ReadKey();
        }
    }
}
