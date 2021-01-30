using System;
using System.Collections.Generic;

namespace HFC_CardComparer
{
    class Program
    {
        static Random random = new Random();
        static CardComparerByValue compara = new CardComparerByValue();
        static Card RandomCard()
        {
            Values generatedValue = (Values)random.Next(1, 14);
            Suits generatedSuit = (Suits)random.Next(4);
            Card generatedCard = new Card(generatedValue,generatedSuit);
            return generatedCard;
        }

        static void PrintCard(List<Card>myList)
        {
            foreach (Card card in myList)
            {
                Console.WriteLine(card.Name);
            }
        }




        static void Main(string[] args)
        {
            List<Card> cardList = new List<Card>();

            while (true)
            {
            Console.WriteLine("How many cards do you want? ");
            string noOfCards = Console.ReadLine();
            if(int.TryParse(noOfCards, out int noCards))
                {
                    for(int i = 0; i < noCards; i++)
                    {
                        cardList.Add(RandomCard());
                    }
                }
                PrintCard(cardList);
                Console.WriteLine("\n Now let's sort them\n");
                cardList.Sort(compara);
                PrintCard(cardList);
            }

        }
    }
}
