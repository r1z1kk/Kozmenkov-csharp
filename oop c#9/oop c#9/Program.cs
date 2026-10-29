using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_c_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> intBox = new Box<int>();
            intBox.Put(42);

            Box<string> stringBox = new Box<string>();
            stringBox.Put("Hello");

            Console.WriteLine($"Число в коробке: {intBox.Get()}");
            Console.WriteLine($"Строка в коробке: {stringBox.Get()}");

            Console.WriteLine();

            int x = 5, y = 10;
            Utils.Swap(ref x, ref y);
            Console.WriteLine($"Числа после Swap: {x}, {y}");

            string s1 = "Hello", s2 = "World";
            Utils.Swap(ref s1, ref s2);
            Console.WriteLine($"Строки после Swap: {s1}, {s2}");

            Console.WriteLine();

            Pair<int, string> pair = new Pair<int, string>(5, "Hello");
            Console.WriteLine($"Первое значение: {pair.First}, Второе значение: {pair.Second}");
        }
    }
}