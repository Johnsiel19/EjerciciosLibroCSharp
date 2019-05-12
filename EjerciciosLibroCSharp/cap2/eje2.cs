using System;

namespace eje2
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimetro = 0;
            double lado = 0;
            double cantidad = 0;

           
            Console.WriteLine("Encontrar el Perimetro  de un Poligono\n");
           

            Console.Write("Ingrese cantidad de lados del Poligono: ");
            cantidad = Int32.Parse(Console.ReadLine());

           
            Console.Write("Ingrese el lados del Poligono:");
            lado = Int32.Parse(Console.ReadLine());
        
            perimetro = cantidad * lado;
     
            Console.WriteLine("\n El Area del Poligono: {0}", perimetro);

            Console.ReadKey();
        }
    }
}
