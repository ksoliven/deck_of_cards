using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Card
    {
        public string stringVal; //(Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King)
        public string suit;
        public int val; // numerical value of the card 1-13 as integers

    
    public Card(int val, string suit)
    {
        this.val = val;
        this.suit = suit;
        if(val == 1)
        {
            stringVal = "Ace";
        }
        else if (val == 11)
        {
            stringVal ="Jack";    
        }
        else if(val == 12)
        {
            stringVal ="Queen";
        }
        else if(val == 13)
        {
            stringVal = "King";
        }
        else{
            stringVal = val.ToString();
        }
    }
}
}