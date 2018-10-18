using Lab07_Collections.Classes;
using System;
using System.Collections.Generic;

namespace Lab07_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GenericCollection();
        }

        static void GenericCollection()
        {
            //assign array size
            Deck<Card> myCards = new Deck<Card>()
            {
                new Card { Suit = CardSuit.Spades, Value = Value.Ace },
                new Card { Suit = CardSuit.Hearts, Value = Value.Eight },
                new Card { Suit = CardSuit.Diamonds, Value = Value.Two },
                new Card { Suit = CardSuit.Hearts, Value = Value.King },
                new Card { Suit = CardSuit.Clubs, Value = Value.Queen },
                new Card { Suit = CardSuit.Spades, Value = Value.Four },
                new Card { Suit = CardSuit.Spades, Value = Value.Five },
                new Card { Suit = CardSuit.Hearts, Value = Value.Six },
                new Card { Suit = CardSuit.Clubs, Value = Value.Ace },
                new Card { Suit = CardSuit.Spades, Value = Value.Jack }
            };

            myCards.Remove();
        }
    }
}
