using System;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // digitar a tabuada desejada
             
            Console.WriteLine("digite o numero da tabuada?");

            int numero =int.Parse(Console.ReadLine());

            //mostrar o resultado
            Console.WriteLine("resposta");
            
            for (int i = 0; i <= 10; i++)
                

            {
                int total = numero * i;
                Console.WriteLine(numero + "x" + i + "=" + total);
                
            }







        }
    }
}
