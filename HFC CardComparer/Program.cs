using System;
using System.Collections.Generic;

namespace HFC_CardComparer
{
    class Program
    {
        static Random random = new Random();
        static Card RandomCard()
        {
            Values generatedValue = (Values)random.Next(1, 15);
            Suits generatedSuit = (Suits)random.Next(4);
            Card generatedCard = new Card(generatedValue,generatedSuit);
            return generatedCard;
        }

        static void PrintCard(List<Card>myList)
        {
            foreach (Card card in myList)
            {
                Console.WriteLine(card);
            }
        }




        static void Main(string[] args)
        {
            List<Card> cardList = new List<Card>();

            Console.WriteLine();

        }
    }
}
