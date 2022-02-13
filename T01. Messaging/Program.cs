using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string allSymbols = Console.ReadLine();

            List<char> finalMessage = new List<char>();

            foreach (int index in numbers)
            {
                int sumIndex = GetSumOfNumbers(index);

                finalMessage.Add(allSymbols[sumIndex]);
            }

            Console.WriteLine(string.Join("", finalMessage));
        }

        static int GetSumOfNumbers(int currentNumber)
        {
            int sum = 0;

            while (currentNumber != 0)
            {
                currentNumber %= 10;
                sum += currentNumber;
                currentNumber /= 10;
            }

            return sum;
        }
    }
}
