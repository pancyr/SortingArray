using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Array
    {
        public Array(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.Body = new double[Rows, Columns];
        }

        public int Rows { get; set; }
        public int Columns { get; set; }

        private double[,] Body { get; set; }

        public double this[int i, int j]
        {
            get
            {
                return Body[i, j];
            }
            set
            {
                Body[i, j] = value;
            }
        }

        public void Sort()
        {
            //Объявляем временный массив
            double[] TempArr = new double[Rows*Columns];
            //Заполняем временный массив
            int i, j;

            for (i = 0; i < Rows; i++)
                for (j = 0; j < Columns; j++)
                    TempArr[i* Columns + j] = this[i, j];

            double temp;
            for (i = 0; i < TempArr.Length - 1; i++)
            {
                for (j = i + 1; j < TempArr.Length; j++)
                {
                    if (TempArr[i] > TempArr[j])
                    {
                        temp = TempArr[i];
                        TempArr[i] = TempArr[j];
                        TempArr[j] = temp;
                    }
                }
            }

            for (i = 0; i < Rows; i++)
                for (j = 0; j < Columns; j++)
                    this[i, j] = TempArr[i * Columns + j];
        }
    }
}
