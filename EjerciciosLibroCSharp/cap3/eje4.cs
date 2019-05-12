using System;

namespace eje4
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            int i = 0;

            Console.WriteLine(" Ingrese Un numero entre 1-7 el programa devolvera el dia  \n "); // Escribe por pantalla un string

            entrada = Console.ReadLine();
            i = System.Int32.Parse(entrada);
      
            switch (i)
            {
                case 1:
                    Console.WriteLine("Dia selecionado es Domingo");  
                    break;
                case 2:
                    Console.WriteLine("Dia selecionado es Lunes");  
                    break;
                case 3:
                    Console.WriteLine("Dia selecionado es Martes"); 
                    break;
                case 4:
                    Console.WriteLine("Dia selecionado es Miercoles"); 
                    break;
                case 5:
                    Console.WriteLine("Dia selecionado es Jueves"); 
                    break;
                case 6:
                    Console.WriteLine("Dia selecionado es Viernes"); 
                    break;
                case 7:
                    Console.WriteLine("Dia selecionado es Sabado  "); 
                    break;
                default:

                    break;
            }

            Console.ReadKey();

        }
    }
}
