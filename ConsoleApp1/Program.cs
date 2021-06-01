using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определим параметры массива!");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Сколько строк?");
            string countRows = Console.ReadLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Сколько столбцов?");
            string countCols = Console.ReadLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Параметры массива: {countRows} Х {countCols}");
            Console.WriteLine("----------------------------");
            NumberGeneratorBase generator = new RandomNumberGenerator(100);
            ArrayFactory factory = new ArrayFactory(generator);
            Array array = factory.Create(Int32.Parse(countRows), Int32.Parse(countCols));
            factory.Write("Первоначальный массив", array);
            array.Sort();
            factory.Write("Отсортированный массив", array);

            Console.ReadKey();
        }
    }
}
