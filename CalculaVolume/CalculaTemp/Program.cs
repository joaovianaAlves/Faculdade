using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTemp
{
    internal class Program
    {
           static int CalculaTempFahrenheit(int celsius)
        {
            int fahrenheit = (celsius - 160) * 5/9;
            return fahrenheit;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em celsius");
            int celsius = int.Parse(Console.ReadLine());
            Console.WriteLine("Temperatura em fahrenheit", celsius , CalculaTempFahrenheit(celsius));
        }
    }
}
