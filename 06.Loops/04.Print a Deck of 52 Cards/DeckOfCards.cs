using System;

class DeckOfCards
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        int[] colors = { 5, 4, 3, 6 };

        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < colors.Length; j++)
            {
                Console.Write(cards[i] + (char)(colors[j]) + " ");
            }
            Console.WriteLine();
        }
    }
}

