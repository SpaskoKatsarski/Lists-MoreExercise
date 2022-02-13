using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                if (firstDeck.Count == 0 || secondDeck.Count == 0)
                {
                    break;
                }

                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(secondDeck[0]);
                    firstDeck.Add(firstDeck[0]);

                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                else if (secondDeck[0] > firstDeck[0])
                {
                    secondDeck.Add(firstDeck[0]);
                    secondDeck.Add(secondDeck[0]);

                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                else
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
            }

            string winner = GetTheWinner(firstDeck, secondDeck);
            int sum = GetWinnerSum(firstDeck, secondDeck, winner);

            Console.WriteLine($"{winner} player wins! Sum: {sum}");
        }

        static string GetTheWinner(List<int> cards1, List<int> cards2)
        {
            string winner = string.Empty;

            if (cards1.Count == 0)
            {
                winner = "Second";
            }
            else
            {
                winner = "First";
            }

            return winner;
        }

        static int GetWinnerSum(List<int> cards1, List<int> cards2, string winner)
        {
            if (winner == "First")
            {
                return cards1.Sum();
            }
            else
            {
                return cards2.Sum();
            }
        }
    }
}
