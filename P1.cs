using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

        int k = 3;

        Console.Write("Before: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
        Console.WriteLine("k = " + k);

        for (int rotation = 0; rotation < k; rotation++)
        {
            int lastElement = numbers[numbers.Length - 1];

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            numbers[0] = lastElement;
        }

        Console.Write("After: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}