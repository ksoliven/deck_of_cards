using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        string[] suits;

        public Deck()
        {
            buildDeck();
        }
        public Deck buildDeck()
        {
        suits = new string [] {"Spades", "Clubs", "Hearts", "Diamonds" };
        for (int val = 1; val < 14; val++) // Card value between 1 - 13
        {
            for (int suit = 0; suit < suits.Length; suit++)
            {
                cards.Add( new Card(val, suits[suit]) );
            }
        }
        return this;
        }
        public int chooseRandomIdx()
        {
        Random rand = new Random();
        int randomIdx = rand.Next(0, cards.Count -1);
        //random index
        return randomIdx;   
        }
        public Deck shuffle()
        {
        Random rand = new Random();
        for (int i = 0; i <cards.Count; i++)
        {
            int randomIdx = chooseRandomIdx();
            Card temp = cards[i];
            cards[i] = cards[randomIdx];
            cards[randomIdx] = temp;
        }
        return this;
        }
        public Card dealTopCard()
        {
        Card topCard = cards[0];
        Console.WriteLine($"You are removing the first card in the deck, {topCard.stringVal} of {topCard.suit}");
        cards.RemoveAt(0);
        return topCard; 
        }
        public Card dealRandomCard()
        {
        int randomIdx = chooseRandomIdx();
        Card randomCard = cards[randomIdx];
        Console.WriteLine($"Random Card : {randomCard.stringVal} of {randomCard.suit}");
        cards.RemoveAt(randomIdx);
        return randomCard;
        }
        public Deck reset()
        {
        cards.Clear();
        buildDeck().shuffle();
        return this;
        }
        public Deck displayDeck()
        {
        for(var i = 0; i < cards.Count; i++)
        {
        Console.WriteLine($"{cards[i].stringVal} of {cards[i].suit}");
        }
        return this;
        }
        public void getDeckCount()
        {
        Console.WriteLine(cards.Count);
        }
    }
}