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
			throw new NotImplementedException();
		}

		public static void ShiftLeftByOne(int[] array, int position1, int position2)
		{
			throw new NotImplementedException();
		}

		public static int[] CreateRandomArray(int size, int minValue, int maxValue)
		{
			throw new NotImplementedException();
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
