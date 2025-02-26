using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2
{
    internal class Class1
    {
        public int po(int[,] array)
        {
            int sum = 0;

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (array[i, j] < 0 && array[i, j] % 2 != 0)
                    {
                        sum += Math.Abs(array[i, j]);
                    }
                }
            }
            return sum;
        }
    }
}
