using System;

namespace eje5
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolares =0;
            double euros = 0;
            string valor = "";

            Console.WriteLine("Digitar Digite la taza del dia:");
            valor = Console.ReadLine();
            euros = Convert.ToDouble(valor);
            Console.WriteLine("Digitar Monto de dolares a convertir a Euros:");
            valor = Console.ReadLine();
            dolares = Convert.ToDouble(valor);
            double conversion = dolares * euros;

            Console.WriteLine("{0} Dolares = {1} Euros", dolares, conversion);
        }
    }
}
