using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[7,7]
            {
                {1,4,5,-6,7,8,-12 },
                {21,42,33,22, 5, 6, 4},
                {43, 56, -62, 44, 2, -1, 5},
                {21,42,33,22, -5, 6, 4},
                {1,4,5,6,7,8,12 },
                {2,42,-3,2, 25, 65, 43},
                {21,-42,33,-22, 5, -6, 4},
            };
            
            Class1 class1 = new Class1();

            Console.WriteLine(class1.po(array));

        }
    }
}
