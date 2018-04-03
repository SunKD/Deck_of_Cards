using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Player
    {
        string name;
        List<Card> hand = new List<Card>();
        Deck cards;

        public Player(string name, Deck cards){
            this.name = name;
            this.cards = cards;
        }

        public Card Draw()
        {
            Card topcard = cards.Deal();
            hand.Add(topcard);
            return topcard;
        }

        public Card Discard(int index){
            if(hand.Count < index){
                return null;
            }else{
                Card discard = hand[index];
                hand.Remove(discard);
                return discard;
            }
        }
    }
}