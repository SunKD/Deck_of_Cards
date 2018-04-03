using System;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck cards = new Deck();
            cards.Setcard();
            cards.Shuffle();
            Player player1 = new Player("Mario", cards);
            Player player2 = new Player("Luige", cards);
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Player1 Card: " + player1.Draw());
                System.Console.WriteLine("Player2 Card: " + player2.Draw());
            }

            System.Console.WriteLine(player1.Discard(2));
            System.Console.WriteLine(player2.Discard(4));

        }
    }
}
