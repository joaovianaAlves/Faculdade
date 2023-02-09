using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static int Fatorial(int num)
        {
            int fat = 1;
            for (int i = num; i > 0; i--)
            {
                fat *= i;
            }
            return (fat);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para calculo do fatorial");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("O fatorial de {0} é {1}", num, Fatorial(num));
            Console.ReadKey();
        }
    }
}
