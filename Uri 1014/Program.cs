using System;
using System.Globalization;
namespace Uri_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, valor, valor1;

            Console.WriteLine();
            Console.Write("Digite a distância percorrida : ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o valor total do combustível : ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valor = x / y;

            //valor1 = valor / x;

            Console.WriteLine();
            Console.Write(valor.ToString("F3", CultureInfo.InvariantCulture)+" km/l");
           
        }

    }
    
    
}
