using System;

namespace HomeWork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] fibonacci = { 0, 1, 1, 2, 3, 5, 8, 13};
            string[] months = { 
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
            int[][] array3 = new int[3][] {new [] {2,3,4},new []{2^2, 3^2, 4^2},new []{2^3, 3^3, 4^3}};

            double[][] array4 = new double[3][] { new double[] { 1, 2, 3, 4, 5 }, new double[] { Math.E, Math.PI }, new double[]{Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000)} };

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array, 0, array2, 0, 3);
            foreach (var num in array2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            
            Array.Resize(ref array, array.Length * 2);
            Console.WriteLine("Array after resizing:");
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

        }
    }
}