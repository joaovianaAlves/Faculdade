using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static float CalculaVolume(int r, int a)
        {
            float volume = (float)Math.PI * (float)Math.Pow(r, 2) * a;
            return volume;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Raio da lata: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura da lata: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("O volume da lata é´{0:f2}", CalculaVolume(r, a));
            Console.ReadKey();
            {
            }
        }
    }
}
