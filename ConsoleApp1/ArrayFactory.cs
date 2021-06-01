using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayFactory
    {
        public ArrayFactory(NumberGeneratorBase generator)
        {
            this.Generator = generator;
        }

        public readonly NumberGeneratorBase Generator;

        public Array Create(int rows, int columns)
        {
            Array result = new Array(rows, columns);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = Generator.GetValue(i, j);
                }
            return result;
        }

        public void Write(string comment, Array array)
        {
            Console.WriteLine(comment);
            for (int i = 0; i < array.Rows; i++)
            {
                for (int j = 0; j < array.Columns; j++)
                    Console.Write(String.Format("{0:F2} ", array[i, j]));
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
