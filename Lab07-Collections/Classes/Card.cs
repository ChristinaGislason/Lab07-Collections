using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Card       
        {
            // The Suit and Values are an enums
            public CardSuit Suit { get; set; }
            public Value Value { get; set; }
        }
        
        public enum CardSuit
        {
            Diamonds,
            Hearts,
            Spades,
            Clubs
        }
        
        public enum Value
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
