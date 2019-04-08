using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lowenstein
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите слово");
            string str2 = Console.ReadLine();

            Low obj = new Low();
            obj.Lows(str1, str2);
            obj.Levenstein();
            Console.ReadKey();
        }
    }
}
