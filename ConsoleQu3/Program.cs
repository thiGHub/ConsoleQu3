using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQu3
{
    class Program
    {
        static void Main()
        {
            double nm1, nm2;

            Console.Write("Digite um número: ");
            nm1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            nm2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Adição: " + (nm1 + nm2));
            Console.WriteLine("Subtração: " + (nm1 - nm2));
            Console.WriteLine("Multiplicação " + (nm1 * nm2));
            Console.WriteLine("Divisão: " + (nm1 / nm2));
            Console.ReadKey();
            


        }
    }
}
