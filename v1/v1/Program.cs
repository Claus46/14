using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v1
{
    internal class Program
    {
        static void SortLastRow(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int lastRowIndex = rows - 1;

            int[] LastRow = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                LastRow[j] = array[lastRowIndex, j];
            }

            Array.Sort(LastRow);

            for (int j = 0; j <cols; j++)
            {
                array[lastRowIndex, j] = LastRow[j];
            }
        }

        static void PrintArray(int[,] array) 
        {
            int rows = array.GetLength (0);
            int cols = array.GetLength (1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] array = {
                { 5, 2, 9, 1,},
                { 3, 8, 7, 4,},
                { 6, 0, 2, 3 }
            };
            Console.WriteLine("исходный массив");
            PrintArray(array);

            SortLastRow(array);

            Console.WriteLine("Массив после сортировки последней строки: ");
            PrintArray(array);
            Console.ReadKey();
        }
        
        
    }
}
