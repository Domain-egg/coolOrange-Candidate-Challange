using System;
using System.Linq;

namespace coolOrange_CandidateChallenge
{
    public class Array
    {
        //ToDo

        public static int FindMaxValue(int[] array, int position1, int position2)
        {
            var length = position2 - position1 + 1;
            var slicedArray = new int[length];
            System.Array.Copy(array, position1, slicedArray, 0, length);
            return slicedArray.Max();
        }

        public static int FindMinPosition(int[] array, int position1, int position2)
        {
            var length = position2 - position1 + 1;
            var slicedArray = new int[length];
            System.Array.Copy(array, position1, slicedArray, 0, length);
            return System.Array.IndexOf(array, slicedArray.Min());
        }

        public static void Swap(int[] array, int position1, int position2)
        {
            var valueOfPosition2 = array.GetValue(position2);
            array.SetValue(array.GetValue(position1), position2);
            array.SetValue(valueOfPosition2, position1);
        }

        public static void ShiftLeftByOne(int[] array, int position1, int position2)
        {
            var firstValue = array.GetValue(position1);
            for (var i = position1; i < position2 - 1; i++)
            {
                array.SetValue(array.GetValue(i + 1), i);
            }

            array.SetValue(firstValue, position2 - 1);
        }

        public static int[] CreateRandomArray(int size, int minValue, int maxValue)
        {
            var array = new int[size];

            var random = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array.SetValue(random.Next(minValue, maxValue), i);
            }

            return array;
        }

        //changed jagged array to two-dimensional array, since in test .GetLength(<dimension>) was used but does not work with jagged arrays
        public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
        {
            int[,] array2D = new int[rows,columns];
            for (var i = 0; i < array2D.GetLength(0); i++)
            {
                int[] row = CreateRandomArray(columns, minValue, maxValue);
                for (int j = 0; j < row.Length; j++)
                {
                    array2D[i, j] = row[j];
                }
                
            }

            return array2D;
        }

        //changed jagged array to two-dimensional array, since in test .GetLength(<dimension>) was used but does not work with jagged arrays
        public static int[,] CopyArray(int[] array)
        {
            var result = new int[2,array.Length];

            var copy = new int[array.Length];
            array.CopyTo(copy, 0);
            
            for (int i = 0; i < array.Length; i++)
            {
                result[0, i] = array[i];
                result[1, i] = copy[i];
            }
            
            return result;
        }

        public static int FindInSortedArray(int[] array, int number)
        {
            throw new NotImplementedException();
        }
    }
}