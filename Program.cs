using System;
using System.Collections.Generic;
using System.Linq;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            deck1.shuffle().displayDeck();
            //deck1. shuffletop card
            //deck1  displays deck
            //Console.WriteLine("Hello World!");
            deck1.getDeckCount();
            //deck1.reset().displaydeck().getDeckCount();

            Player kate = new Player("Kate");
            kate.drawCard(deck1);
            kate.drawCard(deck1);
            kate.showHand();
            deck1.getDeckCount();
            kate.discardCard(1);
            kate.showHand();

            List<Card> AllHeartCards = deck1.cards.Where(card => card.suit == "Hearts").OrderBy(card => card.val).ToList();

            int highestVal = AllHeartCards.Max(c => c.val);
            AllHeartCards.First(c => c.val == highestVal);

        }
    }
}
