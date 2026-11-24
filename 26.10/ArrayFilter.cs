using System;

namespace ArrayDelegatesApp
{
    public class ArrayFilter
    {
        private static int[] FilterByCondition(int[] array, Predicate<int> predicate)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    result[index] = array[i];
                    index++;
                }
            }

            return result;
        }

        public static int[] GetEvenNumbers(int[] array)
        {
            return FilterByCondition(array, NumberChecker.IsEven);
        }

        public static int[] GetOddNumbers(int[] array)
        {
            return FilterByCondition(array, NumberChecker.IsOdd);
        }

        public static int[] GetPrimeNumbers(int[] array)
        {
            return FilterByCondition(array, NumberChecker.IsPrime);
        }

        public static int[] GetFibonacciNumbers(int[] array)
        {
            return FilterByCondition(array, NumberChecker.IsFibonacci);
        }

        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}