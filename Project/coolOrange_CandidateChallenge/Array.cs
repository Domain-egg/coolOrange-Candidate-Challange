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

        public static int[][] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
        {
            throw new NotImplementedException();
        }

        public static int[][] CopyArray(int[] array)
        {
            throw new NotImplementedException();
        }

        public static int FindInSortedArray(int[] array, int number)
        {
            throw new NotImplementedException();
        }
    }
}