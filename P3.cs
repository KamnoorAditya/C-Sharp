using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            3, 7, 3, 9, 7, 1, 3
        };

        Dictionary<int, int> frequency = new Dictionary<int, int>();

        Console.Write("Numbers: ");

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i]);

            if (i < numbers.Count - 1)
            {
                Console.Write(", ");
            }

            if (frequency.ContainsKey(numbers[i]))
            {
                frequency[numbers[i]]++;
            }
            else
            {
                frequency[numbers[i]] = 1;
            }
        }

        Console.WriteLine();

        Console.WriteLine("Duplicates:");

        foreach (KeyValuePair<int, int> pair in frequency)
        {
            if (pair.Value > 1)
            {
                Console.WriteLine(
                    $"{pair.Key} appears {pair.Value} times"
                );
            }
        }
    }
}