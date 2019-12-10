using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SimpleArray
            //Console.Write("Введите размер массива: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[] { 3, 5, 8, 13, 21 };
            //Random rand = new Random();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rand.Next(100, 200);
            //}

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + "\t");
            //}
            //Console.WriteLine();

            //foreach(int i in arr)
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine();
            #endregion
            #region MultiArray
            ////type[,] name = new type[rows, cols];
            ////name[i, j];

            //int[,] arr = new int[ROWS, COLS] 
            //    {
            //        {3, 5, 8 },
            //        { 13, 21, 34},
            //        { 55, 89, 144}
            //    };
            ////foreach(int i in arr)
            ////{
            ////    Console.Write(i + "\t");
            ////}
            ////Console.WriteLine();
            //Console.WriteLine(arr.GetLength());
            //for(int i = 0; i < ROWS; i++)
            //{
            //    for (int j = 0; j < COLS; j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            #endregion
            //type [][] arr =new int [rows][]
            //{
            //    new type[size1],
            //    new Type[size2],

            //    new type [sizeN]
            //}
            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество строк: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[rows][];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[cols];
            }
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length;j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        
    }
}