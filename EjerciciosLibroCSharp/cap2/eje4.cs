using System;

namespace eje4
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = 0 ;
            double fahrenheit = 0;
            string valor = "";

            Console.WriteLine("Digite en grados celcius: ");
            valor = Console.ReadLine();
            celsius = Convert.ToDouble(valor);

            fahrenheit = (1.8 * celsius) + 32;

            Console.WriteLine("{0} celcius = {1} fahreheit", celsius, fahrenheit);

            Console.Read();
        }
    }
}
