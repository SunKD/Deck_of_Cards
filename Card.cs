using System;

namespace deckOfCards
{
    class Card
    {
        string stringVal;
        string suit;
        int val;

        public Card(string stringVal, string suit, int val)
        {
            this.stringVal = stringVal;
            this.suit = suit;
            this.val = val;
        }

        public override string ToString()
        {
            return "|" + stringVal + " " + suit + " " + val + "|";
        }
    }
}