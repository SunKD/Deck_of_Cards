using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Deck
    {
        List<Card> cards = new List<Card>(52);
        public void Setcard()
        {
            string  [] strvals  = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string  [] suits    = { "Clubs", "Spades", "Hearts", "Diamonds" };
            int     [] numval   = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            for (var i = 0; i < suits.Length; i++)
            {
                for (var j = 0; j < strvals.Length; j++)
                {
                    cards.Add(new Card(strvals[j], suits[i], numval[j]));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count - 1, j = cards.Count - 1; i > 0; i--, j--)
            {
                int randIndex = rand.Next(j);
                Card temp = cards[i];
                cards[i] = cards[randIndex];
                cards[randIndex] = temp;
            }
        }
        public Card Deal(){
            Card topcard = cards[cards.Count-1];
            cards.Remove(topcard);
            return topcard;
        }
        public void Reset(){
            cards.Clear();
            Setcard();
        }
    }
}