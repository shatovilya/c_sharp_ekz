using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Введите сроку со словами через пробел");
            text = Console.ReadLine();
            var newText = text.Split(' ').Select(x => x.Length).ToArray();
            Console.WriteLine("Результат с длинами слов");
            Console.WriteLine(string.Join(" ", newText));
            Console.ReadLine();
        }
    }
}
