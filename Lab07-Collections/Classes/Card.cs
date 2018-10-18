using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    class Card       
        {
            // the Suit is an enum
            public CardSuit Suit { get; set; }
            public Value Value { get; set; }
        }
        
        enum CardSuit
        {
            Diamonds,
            Hearts,
            Spades,
            Clubs
        }
        
        enum Value
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }  
    
}
