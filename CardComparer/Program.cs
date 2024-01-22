using System;
using System.Collections.Generic;

namespace CardComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of cards: ");
            List<Card> cards = new List<Card>();

            if (int.TryParse(Console.ReadLine(), out int noOfCards))
            {
                for (int i = 0; i < noOfCards; i++)
                {
                    cards.Add(RandomCard());
                }
            }    

            PrintCards(cards);

            Console.WriteLine("\n... sorting the cards ...\n");

            cards.Sort(new CardComparerByValue());

            PrintCards(cards);
        }

        static Card RandomCard()
        {
            Random random = new Random();
            return new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
        }

        static void PrintCards(List<Card> cards)
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
