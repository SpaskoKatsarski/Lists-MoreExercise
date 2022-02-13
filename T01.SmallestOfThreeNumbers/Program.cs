using System;

namespace T01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(FindSmallestNubmer(n1, n2, n3));
        }

        static int FindSmallestNubmer(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                return num1;
            }
            else if (num2 < num3)
            {
                return num2;
            }

            return num3;
        }
    }
}
