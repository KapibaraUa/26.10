using System;

namespace ArrayDelegatesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 7, 8, 10, 13, 15, 17, 21, 24, 34 };

            Console.WriteLine("Початковий масив:");
            ArrayFilter.ShowArray(numbers);

            ArrayOperation operation = ArrayFilter.GetEvenNumbers;
            Console.WriteLine("Парні числа:");
            ArrayFilter.ShowArray(operation.Invoke(numbers));

            operation = ArrayFilter.GetOddNumbers;
            Console.WriteLine("Непарні числа:");
            ArrayFilter.ShowArray(operation.Invoke(numbers));

            operation = ArrayFilter.GetPrimeNumbers;
            Console.WriteLine("Прості числа:");
            ArrayFilter.ShowArray(operation.Invoke(numbers));

            operation = ArrayFilter.GetFibonacciNumbers;
            Console.WriteLine("Числа Фібоначчі:");
            ArrayFilter.ShowArray(operation.Invoke(numbers));
        }
    }
}