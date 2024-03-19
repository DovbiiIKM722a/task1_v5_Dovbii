/*
 Напишіть програму, яка знаходить: суму всіх елементів у заданому
масиві.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 3, 7, 9, 1 };
        int sum = SumOfArrayElements(array);
        Console.WriteLine($"Sum of all array elements: {sum}");
    }

    static int SumOfArrayElements(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }
}
